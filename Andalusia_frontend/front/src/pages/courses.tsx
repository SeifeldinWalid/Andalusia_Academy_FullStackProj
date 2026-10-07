import { useCallback, useMemo, useState, type FormEvent } from "react";
import { useSearchParams } from "react-router-dom";
import {
  Box,
  Button,
  Chip,
  InputAdornment,
  MenuItem,
  Pagination,
  Paper,
  TextField,
  Typography,
} from "@mui/material";
import { Search } from "lucide-react";
import useFetch from "../hooks/useFetch";
import { getCategories, searchCourses } from "../services/courseService";
import type { CourseFilter, CourseLevel, CourseStatus, CourseType } from "../types";
import CourseCard from "../components/catalog/CourseCard";
import { CardGrid } from "../components/catalog/Section";
import { ErrorState, Loading } from "../components/catalog/PageState";
import { levels, publicStatuses, statusLabel, types } from "../components/catalog/labels";

const PAGE_SIZE = 9;

// Each option maps to the backend's sortBy + order params
const sortOptions = [
  { value: "", label: "Default" },
  { value: "title-asc", label: "Title (A-Z)" },
  { value: "title-desc", label: "Title (Z-A)" },
  { value: "price-asc", label: "Price: low to high" },
  { value: "price-desc", label: "Price: high to low" },
  { value: "duration-asc", label: "Shortest first" },
  { value: "duration-desc", label: "Longest first" },
  { value: "createdAt-desc", label: "Newest" },
];

function toNumber(value: string | null) {
  if (!value) return undefined;
  const n = Number(value);
  return Number.isFinite(n) ? n : undefined;
}

function Courses() {
  const [searchParams, setSearchParams] = useSearchParams();
  const [searchText, setSearchText] = useState(searchParams.get("search") ?? "");

  const sort = searchParams.get("sort") ?? "";
  const skillName = searchParams.get("skillName");

  // The URL is the single source of truth, so filtered views can be shared and the back button works
  const filter = useMemo<CourseFilter>(() => {
    const [sortBy, order] = sort ? sort.split("-") : [];
    return {
      search: searchParams.get("search") || undefined,
      categoryId: toNumber(searchParams.get("categoryId")),
      skillId: toNumber(searchParams.get("skillId")),
      level: (searchParams.get("level") as CourseLevel) || undefined,
      type: (searchParams.get("type") as CourseType) || undefined,
      status: (searchParams.get("status") as CourseStatus) || undefined,
      sortBy: (sortBy as CourseFilter["sortBy"]) || undefined,
      order: (order as CourseFilter["order"]) || undefined,
      page: toNumber(searchParams.get("page")) ?? 1,
      pageSize: PAGE_SIZE,
    };
  }, [searchParams, sort]);

  const fetchCourses = useCallback(() => searchCourses(filter), [filter]);
  const { data, loading, error } = useFetch(fetchCourses);
  const { data: categories } = useFetch(getCategories);

  // Any filter change goes back to page 1
  function updateParam(key: string, value: string) {
    setSearchParams((prev) => {
      const next = new URLSearchParams(prev);
      if (value) next.set(key, value);
      else next.delete(key);
      if (key !== "page") next.delete("page");
      return next;
    });
  }

  function handleSearch(e: FormEvent) {
    e.preventDefault();
    updateParam("search", searchText.trim());
  }

  function clearSkill() {
    setSearchParams((prev) => {
      const next = new URLSearchParams(prev);
      next.delete("skillId");
      next.delete("skillName");
      next.delete("page");
      return next;
    });
  }

  function clearAll() {
    setSearchText("");
    setSearchParams({});
  }

  const hasFilters = [...searchParams.keys()].some((k) => k !== "page");

  return (
    <Box>
      <Typography variant="h4" sx={{ mb: 1 }}>
        Courses
      </Typography>
      <Typography color="text.secondary" sx={{ mb: 3 }}>
        Browse the catalog, search by keyword and narrow down by category, level and format.
      </Typography>

      <Paper variant="outlined" sx={{ p: 2, mb: 3 }}>
        <Box component="form" onSubmit={handleSearch} sx={{ display: "flex", gap: 1, mb: 2 }}>
          <TextField
            fullWidth
            size="small"
            placeholder="Search courses..."
            value={searchText}
            onChange={(e) => setSearchText(e.target.value)}
            slotProps={{
              input: {
                startAdornment: (
                  <InputAdornment position="start">
                    <Search size={18} />
                  </InputAdornment>
                ),
              },
            }}
          />
          <Button type="submit" variant="contained">
            Search
          </Button>
        </Box>

        <Box
          sx={{
            display: "grid",
            gap: 2,
            gridTemplateColumns: { xs: "1fr", sm: "repeat(2, 1fr)", md: "repeat(5, 1fr)" },
          }}
        >
          <TextField
            select
            size="small"
            label="Category"
            value={searchParams.get("categoryId") ?? ""}
            onChange={(e) => updateParam("categoryId", e.target.value)}
          >
            <MenuItem value="">All categories</MenuItem>
            {categories?.map((c) => (
              <MenuItem key={c.id} value={String(c.id)}>
                {c.name} ({c.courseCount})
              </MenuItem>
            ))}
          </TextField>

          <TextField
            select
            size="small"
            label="Level"
            value={filter.level ?? ""}
            onChange={(e) => updateParam("level", e.target.value)}
          >
            <MenuItem value="">All levels</MenuItem>
            {levels.map((l) => (
              <MenuItem key={l} value={l}>
                {l}
              </MenuItem>
            ))}
          </TextField>

          <TextField
            select
            size="small"
            label="Format"
            value={filter.type ?? ""}
            onChange={(e) => updateParam("type", e.target.value)}
          >
            <MenuItem value="">All formats</MenuItem>
            {types.map((t) => (
              <MenuItem key={t} value={t}>
                {t}
              </MenuItem>
            ))}
          </TextField>

          <TextField
            select
            size="small"
            label="Availability"
            value={filter.status ?? ""}
            onChange={(e) => updateParam("status", e.target.value)}
          >
            <MenuItem value="">All</MenuItem>
            {publicStatuses.map((s) => (
              <MenuItem key={s} value={s}>
                {statusLabel(s)}
              </MenuItem>
            ))}
          </TextField>

          <TextField
            select
            size="small"
            label="Sort by"
            value={sort}
            onChange={(e) => updateParam("sort", e.target.value)}
          >
            {sortOptions.map((o) => (
              <MenuItem key={o.value} value={o.value}>
                {o.label}
              </MenuItem>
            ))}
          </TextField>
        </Box>

        {hasFilters && (
          <Box sx={{ display: "flex", alignItems: "center", gap: 1, mt: 2, flexWrap: "wrap" }}>
            {filter.skillId && (
              <Chip
                label={`Skill: ${skillName ?? `#${filter.skillId}`}`}
                onDelete={clearSkill}
                color="primary"
                size="small"
              />
            )}
            <Button size="small" onClick={clearAll}>
              Clear all filters
            </Button>
          </Box>
        )}
      </Paper>

      {loading && <Loading />}
      {!loading && error && <ErrorState message={error} />}

      {!loading && !error && data && (
        <>
          <Typography color="text.secondary" sx={{ mb: 2 }}>
            {data.totalCount} {data.totalCount === 1 ? "course" : "courses"} found
          </Typography>

          {data.data.length === 0 ? (
            <Box sx={{ textAlign: "center", py: 6 }}>
              <Typography variant="h6">No courses match your filters.</Typography>
              <Button sx={{ mt: 2 }} onClick={clearAll}>
                Clear filters
              </Button>
            </Box>
          ) : (
            <CardGrid>
              {data.data.map((course) => (
                <CourseCard key={course.id} course={course} />
              ))}
            </CardGrid>
          )}

          {data.totalPages > 1 && (
            <Box sx={{ display: "flex", justifyContent: "center", mt: 4 }}>
              <Pagination
                count={data.totalPages}
                page={data.page}
                color="primary"
                onChange={(_, page) => {
                  updateParam("page", page === 1 ? "" : String(page));
                  window.scrollTo({ top: 0, behavior: "smooth" });
                }}
              />
            </Box>
          )}
        </>
      )}
    </Box>
  );
}

export default Courses;

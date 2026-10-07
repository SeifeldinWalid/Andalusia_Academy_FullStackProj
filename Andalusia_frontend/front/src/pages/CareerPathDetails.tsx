import { useCallback } from "react";
import { Link as RouterLink, useParams } from "react-router-dom";
import { Box, Divider, Link, Paper, Typography } from "@mui/material";
import useFetch from "../hooks/useFetch";
import { getCareerPathDetails } from "../services/careerPathService";
import DetailHeader from "../components/catalog/DetailHeader";
import StatList from "../components/catalog/StatList";
import CourseCard from "../components/catalog/CourseCard";
import ProgramCard from "../components/catalog/ProgramCard";
import { CardGrid, Section, SkillChips } from "../components/catalog/Section";
import { ErrorState, Loading } from "../components/catalog/PageState";

function CareerPathDetails() {
  const id = Number(useParams().id);
  const fetchPath = useCallback(() => getCareerPathDetails(id), [id]);
  const { data: path, loading, error } = useFetch(fetchPath);

  if (loading) return <Loading />;
  if (error || !path) return <ErrorState message={error} backTo="/career-paths" backLabel="All career paths" />;

  return (
    <>
      <DetailHeader
        backTo="/career-paths"
        backLabel="Career Paths"
        title={path.title}
        description={path.description}
        aside={
          <StatList
            stats={[
              { label: "Estimated time", value: `~${path.estimatedMonths} months` },
              { label: "Programs", value: path.programCount },
              { label: "Skills", value: path.skills.length },
            ]}
          />
        }
      />

      <Divider sx={{ my: 4 }} />

      <Section title="Recommended skills" empty={path.skills.length === 0}>
        <SkillChips skills={path.skills} />
      </Section>

      <Section title="Your roadmap" empty={path.programs.length === 0}>
        {/* Programs arrive in the order they should be taken */}
        <Box sx={{ display: "flex", flexDirection: "column", gap: 2 }}>
          {path.programs.map((p, i) => (
            <Box
              key={p.id}
              sx={{
                display: "grid",
                gap: 2,
                alignItems: "stretch",
                gridTemplateColumns: { xs: "1fr", md: "80px 1fr" },
              }}
            >
              <Paper
                variant="outlined"
                sx={{ display: "flex", alignItems: "center", justifyContent: "center", p: 2 }}
              >
                <Typography variant="h6" color="primary">
                  Step {i + 1}
                </Typography>
              </Paper>
              <ProgramCard program={p} />
            </Box>
          ))}
        </Box>
      </Section>

      <Section title="Recommended courses" empty={path.recommendedCourses.length === 0}>
        <CardGrid>
          {path.recommendedCourses.map((c) => (
            <CourseCard key={c.id} course={c} />
          ))}
        </CardGrid>
      </Section>

      <Link component={RouterLink} to="/career-paths">
        ← Back to all career paths
      </Link>
    </>
  );
}

export default CareerPathDetails;

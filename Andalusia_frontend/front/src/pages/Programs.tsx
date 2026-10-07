import { useMemo, useState } from "react";
import { Box, MenuItem, TextField, Typography } from "@mui/material";
import useFetch from "../hooks/useFetch";
import { getPrograms } from "../services/programService";
import ProgramCard from "../components/catalog/ProgramCard";
import { CardGrid } from "../components/catalog/Section";
import { ErrorState, Loading } from "../components/catalog/PageState";
import { levels } from "../components/catalog/labels";

function Programs() {
  const { data, loading, error } = useFetch(getPrograms);
  const [level, setLevel] = useState("");

  // Only a handful of programs, so filtering happens client side
  const programs = useMemo(
    () => (data ?? []).filter((p) => !level || p.level === level),
    [data, level]
  );

  return (
    <Box>
      <Typography variant="h4" sx={{ mb: 1 }}>
        Programs
      </Typography>
      <Typography color="text.secondary" sx={{ mb: 3 }}>
        Structured learning programs that combine several courses in a recommended order.
      </Typography>

      <TextField
        select
        size="small"
        label="Level"
        value={level}
        onChange={(e) => setLevel(e.target.value)}
        sx={{ mb: 3, minWidth: 200 }}
      >
        <MenuItem value="">All levels</MenuItem>
        {levels.map((l) => (
          <MenuItem key={l} value={l}>
            {l}
          </MenuItem>
        ))}
      </TextField>

      {loading && <Loading />}
      {!loading && error && <ErrorState message={error} />}
      {!loading && !error && (
        programs.length === 0 ? (
          <Typography>No programs found.</Typography>
        ) : (
          <CardGrid>
            {programs.map((p) => (
              <ProgramCard key={p.id} program={p} />
            ))}
          </CardGrid>
        )
      )}
    </Box>
  );
}

export default Programs;

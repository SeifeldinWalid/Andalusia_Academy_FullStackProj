import { Box, Chip, Stack, Typography } from "@mui/material";
import { Link as RouterLink } from "react-router-dom";
import type { ReactNode } from "react";
import type { Skill } from "../../types";

interface SectionProps {
  title: string;
  children: ReactNode;
  empty?: boolean;
  emptyText?: string;
}

// Titled block used on the detail pages
export function Section({ title, children, empty, emptyText }: SectionProps) {
  return (
    <Box sx={{ py: 3 }}>
      <Typography variant="h5" sx={{ mb: 2 }}>
        {title}
      </Typography>
      {empty ? <Typography color="text.secondary">{emptyText ?? "Nothing here yet."}</Typography> : children}
    </Box>
  );
}

export function CardGrid({ children }: { children: ReactNode }) {
  return (
    <Box
      sx={{
        display: "grid",
        gap: 2,
        gridTemplateColumns: { xs: "1fr", sm: "repeat(2, 1fr)", md: "repeat(3, 1fr)" },
      }}
    >
      {children}
    </Box>
  );
}

// Each skill links to the course search filtered by that skill
export function SkillChips({ skills }: { skills: Skill[] }) {
  return (
    <Stack direction="row" sx={{ flexWrap: "wrap", gap: 1 }}>
      {skills.map((s) => (
        <Chip
          key={s.id}
          label={s.name}
          component={RouterLink}
          to={`/courses?skillId=${s.id}&skillName=${encodeURIComponent(s.name)}`}
          clickable
          color="primary"
          variant="outlined"
        />
      ))}
    </Stack>
  );
}

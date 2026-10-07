import { Card, CardActionArea, CardContent, Chip, Stack, Typography } from "@mui/material";
import { Link as RouterLink } from "react-router-dom";
import type { ProgramSummary } from "../../types";
import { levelColor } from "./labels";

interface Props {
  program: ProgramSummary;
}

function ProgramCard({ program }: Props) {
  return (
    <Card sx={{ height: "100%" }}>
      <CardActionArea
        component={RouterLink}
        to={`/programs/${program.id}`}
        sx={{ height: "100%", display: "flex", flexDirection: "column", alignItems: "stretch" }}
      >
        <CardContent sx={{ flexGrow: 1, display: "flex", flexDirection: "column" }}>
          <Typography variant="h6" sx={{ mb: 1 }}>
            {program.title}
          </Typography>
          <Typography color="text.secondary" variant="body2" sx={{ mb: 2 }}>
            {program.description}
          </Typography>
          <Stack direction="row" spacing={1} sx={{ mt: "auto", flexWrap: "wrap" }}>
            <Chip label={program.level} color={levelColor[program.level]} size="small" variant="outlined" />
            <Chip label={`${program.courseCount} courses`} size="small" variant="outlined" />
            <Chip label={`${program.durationWeeks} weeks`} size="small" variant="outlined" />
          </Stack>
        </CardContent>
      </CardActionArea>
    </Card>
  );
}

export default ProgramCard;

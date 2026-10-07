import { Card, CardActionArea, CardContent, Chip, Stack, Typography } from "@mui/material";
import { Link as RouterLink } from "react-router-dom";
import type { CareerPathSummary } from "../../types";

interface Props {
  careerPath: CareerPathSummary;
}

function CareerPathCard({ careerPath }: Props) {
  return (
    <Card sx={{ height: "100%" }}>
      <CardActionArea
        component={RouterLink}
        to={`/career-paths/${careerPath.id}`}
        sx={{ height: "100%", display: "flex", flexDirection: "column", alignItems: "stretch" }}
      >
        <CardContent sx={{ flexGrow: 1, display: "flex", flexDirection: "column" }}>
          <Typography variant="h6" sx={{ mb: 1 }}>
            {careerPath.title}
          </Typography>
          <Typography color="text.secondary" variant="body2" sx={{ mb: 2 }}>
            {careerPath.description}
          </Typography>
          <Stack direction="row" spacing={1} sx={{ mt: "auto", flexWrap: "wrap" }}>
            <Chip label={`~${careerPath.estimatedMonths} months`} size="small" variant="outlined" />
            <Chip label={`${careerPath.programCount} programs`} size="small" variant="outlined" />
          </Stack>
        </CardContent>
      </CardActionArea>
    </Card>
  );
}

export default CareerPathCard;

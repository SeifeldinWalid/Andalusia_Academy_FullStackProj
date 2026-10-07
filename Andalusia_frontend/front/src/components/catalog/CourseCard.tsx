import {
  Box,
  Card,
  CardActionArea,
  CardContent,
  Chip,
  Stack,
  Typography,
} from "@mui/material";
import { Link as RouterLink } from "react-router-dom";
import type { CourseSummary } from "../../types";
import { formatPrice, levelColor, statusLabel } from "./labels";

interface Props {
  course: CourseSummary & { description?: string };
  order?: number;
}

function CourseCard({ course, order }: Props) {
  return (
    <Card sx={{ height: "100%" }}>
      <CardActionArea
        component={RouterLink}
        to={`/courses/${course.id}`}
        sx={{ height: "100%", display: "flex", flexDirection: "column", alignItems: "stretch" }}
      >
        <CardContent sx={{ flexGrow: 1, display: "flex", flexDirection: "column" }}>
          <Box sx={{ display: "flex", alignItems: "center", gap: 1, mb: 0.5 }}>
            {order !== undefined && <Chip label={`Step ${order}`} color="primary" size="small" />}
            <Typography color="primary" variant="body2" sx={{ flexGrow: 1 }}>
              {course.categoryName}
            </Typography>
            {course.status === "ComingSoon" && (
              <Chip label={statusLabel(course.status)} color="secondary" size="small" />
            )}
          </Box>
          <Typography variant="h6" sx={{ mb: 1 }}>
            {course.title}
          </Typography>
          {course.description && (
            <Typography color="text.secondary" variant="body2" sx={{ mb: 2 }}>
              {course.description}
            </Typography>
          )}
          <Stack direction="row" spacing={1} sx={{ mt: "auto", mb: 1, flexWrap: "wrap" }}>
            <Chip label={course.level} color={levelColor[course.level]} size="small" variant="outlined" />
            <Chip label={course.type} size="small" variant="outlined" />
          </Stack>
          <Box sx={{ display: "flex", justifyContent: "space-between" }}>
            <Typography color="text.secondary" variant="body2">
              {course.durationHours} hours
            </Typography>
            <Typography sx={{ fontWeight: 600 }}>{formatPrice(course.price)}</Typography>
          </Box>
        </CardContent>
      </CardActionArea>
    </Card>
  );
}

export default CourseCard;

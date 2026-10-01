import {
  Alert,
  Box,
  Card,
  CardContent,
  CircularProgress,
  Typography,
} from "@mui/material";
import useFetch from "../hooks/useFetch";
import { getCourses } from "../services/courseService";
import type { Course } from "../types";

function Courses() {
  const { data, loading, error } = useFetch<Course[]>(getCourses);

  if (loading) return <Box sx={{ display: "flex", justifyContent: "center", alignItems: "center", minHeight: "60vh" }}><CircularProgress /></Box>;
  if (error) return <Alert severity="error">{error}</Alert>;
  if (!data || data.length === 0)
    return <Typography>No courses found.</Typography>;

  return (
    <Box>
      <Typography variant="h4" sx={{ mb: 3 }}>
        Courses
      </Typography>
      <Box
        sx={{
          display: "grid",
          gap: 2,
          gridTemplateColumns: { xs: "1fr", md: "repeat(3, 1fr)" },
        }}
      >
        {data.map((course) => (
          <Card key={course.id} sx={{ mb: 2 }}>
            <CardContent>
              <Typography variant="h6">{course.title}</Typography>
              <Typography color="primary" variant="body2">
                {course.categoryName}
              </Typography>
              <Typography color="text.secondary" variant="body2">
                {course.price} L.E
              </Typography>
            </CardContent>
          </Card>
        ))}
      </Box>
    </Box>
  );
}

export default Courses;

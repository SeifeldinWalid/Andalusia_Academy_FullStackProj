import { Alert, Box, Card, CardContent, CircularProgress, Typography } from "@mui/material";
import useFetch from "../hooks/useFetch";
import { getCourses } from "../services/courseService";
import type { Course } from "../types";

function Courses() {
  const { data, loading, error } = useFetch<Course[]>(getCourses);

  if (loading) return <CircularProgress />;
  if (error) return <Alert severity="error">{error}</Alert>;
  if (!data || data.length === 0) return <Typography>No courses found.</Typography>;

  return (
    <Box>
      <Typography variant="h4" sx={{ mb: 3 }}>Courses</Typography>
      {data.map((course) => (
        <Card key={course.id} sx={{ mb: 2 }}>
          <CardContent>
            <Typography variant="h6">{course.title}</Typography>
            <Typography color="text.secondary">
              {course.categoryName} · ${course.price}
            </Typography>
          </CardContent>
        </Card>
      ))}
    </Box>
  );
}

export default Courses;
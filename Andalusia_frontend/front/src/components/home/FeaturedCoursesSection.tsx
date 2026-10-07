import { Box, Button, Typography } from "@mui/material";
import { Link as RouterLink } from "react-router-dom";
import type { Course } from "../../types";
import CourseCard from "../catalog/CourseCard";

interface Props {
  courses: Course[];
}

function FeaturedCoursesSection({ courses }: Props) {
  return (
    <Box sx={{ py: 5 }}>
      <Box sx={{ display: "flex", justifyContent: "space-between", alignItems: "center", mb: 3 }}>
        <Typography variant="h4">Featured Courses</Typography>
        <Button component={RouterLink} to="/courses">
          View all
        </Button>
      </Box>
      <Box
        sx={{
          display: "grid",
          gap: 2,
          gridTemplateColumns: {
            xs: "1fr",
            sm: "repeat(2, 1fr)",
            md: "repeat(4, 1fr)",
          },
        }}
      >
        {courses.map((c) => (
          <CourseCard key={c.id} course={c} />
        ))}
      </Box>
    </Box>
  );
}

export default FeaturedCoursesSection;

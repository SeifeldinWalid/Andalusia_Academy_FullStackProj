import { Box, Card, CardContent, CardMedia, Typography } from "@mui/material";
import type { Course } from "../../types";

interface Props {
  courses: Course[];
}

function FeaturedCoursesSection({ courses }: Props) {
  return (
    <Box sx={{ py: 4 }}>
      <Typography variant="h4" sx={{ mb: 3 }}>Featured Courses</Typography>
      <Box
        sx={{
          display: "grid",
          gap: 2,
          gridTemplateColumns: { xs: "1fr", sm: "repeat(2, 1fr)", md: "repeat(4, 1fr)" },
        }}
      >
        {courses.map((c) => (
          <Card key={c.id}>
            {c.imageUrl && (
              <CardMedia component="img" image={c.imageUrl} alt={c.title} sx={{ height: 140 }} />
            )}
            <CardContent>
              <Typography variant="h6">{c.title}</Typography>
              <Typography color="text.secondary">{c.categoryName}</Typography>
              <Typography sx={{ mt: 1, fontWeight: 600 }}>
                {c.price === 0 ? "Free" : `$${c.price}`}
              </Typography>
            </CardContent>
          </Card>
        ))}
      </Box>
    </Box>
  );
}

export default FeaturedCoursesSection;
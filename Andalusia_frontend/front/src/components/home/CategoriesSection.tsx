import { Box, Card, CardActionArea, CardContent, Typography } from "@mui/material";
import { Link as RouterLink } from "react-router-dom";
import type { Category } from "../../types";

interface Props {
  categories: Category[];
}

function CategoriesSection({ categories }: Props) {
  return (
    <Box sx={{ py: 4 }}>
      <Typography variant="h4" sx={{ mb: 3 }}>Popular Categories</Typography>
      <Box
        sx={{
          display: "grid",
          gap: 2,
          gridTemplateColumns: { xs: "1fr 1fr", md: "repeat(4, 1fr)" },
        }}
      >
        {categories.map((c) => (
          <Card key={c.id}>
            <CardActionArea component={RouterLink} to={`/courses?categoryId=${c.id}`} sx={{ height: "100%" }}>
              <CardContent>
                <Typography variant="h6">{c.name}</Typography>
                <Typography color="text.secondary">{c.courseCount} courses</Typography>
              </CardContent>
            </CardActionArea>
          </Card>
        ))}
      </Box>
    </Box>
  );
}

export default CategoriesSection;

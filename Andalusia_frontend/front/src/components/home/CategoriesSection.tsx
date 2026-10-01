import { Box, Card, CardContent, Typography } from "@mui/material";
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
            <CardContent>
              <Typography variant="h6">{c.name}</Typography>
              <Typography color="text.secondary">{c.courseCount} courses</Typography>
            </CardContent>
          </Card>
        ))}
      </Box>
    </Box>
  );
}

export default CategoriesSection;
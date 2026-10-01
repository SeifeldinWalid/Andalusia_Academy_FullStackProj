import { Avatar, Box, Card, CardContent, Typography } from "@mui/material";
import type { Testimonial } from "../../types";

interface Props {
  testimonials: Testimonial[];
}

function TestimonialsSection({ testimonials }: Props) {
  return (
    <Box sx={{ py: 4 }}>
      <Typography variant="h4" sx={{ mb: 3 }}>What Our Learners Say</Typography>
      <Box 
        sx={{
          display: "grid",
          gap: 2,
          gridTemplateColumns: { xs: "1fr", md: "repeat(3, 1fr)" },
        }}
      >
        {testimonials.map((t) => (
          <Card key={t.id} sx = {{backgroundColor: "info.main"}} >
            <CardContent>
              <Typography sx={{ mb: 2 }}>"{t.content}"</Typography>
              <Box sx={{ display: "flex", alignItems: "center", gap: 1.5 }}>
                <Avatar src={t.avatarUrl ?? undefined}>{t.authorName[0]}</Avatar>
                <Box>
                  <Typography sx={{ fontWeight: 600 }}>{t.authorName}</Typography>
                  <Typography variant="body2" color="text.secondary">{t.role}</Typography>
                </Box>
              </Box>
            </CardContent>
          </Card>
        ))}
      </Box>
    </Box>
  );
}

export default TestimonialsSection;
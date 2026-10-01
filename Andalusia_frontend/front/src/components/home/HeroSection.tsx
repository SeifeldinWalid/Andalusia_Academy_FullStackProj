import { Box, Button, Typography } from "@mui/material";
import { Link as RouterLink } from "react-router-dom";

interface Props {
  title: string;
  subtitle: string;
}

function HeroSection({ title, subtitle }: Props) {
  return (
    <Box sx={{ textAlign: "center", py: { xs: 6, md: 10 } }}>
      <Typography variant="h3" sx={{ fontWeight: 700 }}>{title}</Typography>
      <Typography variant="h6" color="text.secondary" sx={{ mt: 2 }}>
        {subtitle}
      </Typography>
      <Button variant="contained" size="large" component={RouterLink} to="/courses" sx={{ mt: 4 }}>
        Browse Courses
      </Button>
    </Box>
  );
}

export default HeroSection;
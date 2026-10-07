import { Box, Button, Typography } from "@mui/material";
import { Link as RouterLink } from "react-router-dom";

function NotFound() {
  return (
    <Box sx={{ textAlign: "center", py: 8 }}>
      <Typography variant="h3" sx={{ mb: 2 }}>
        Page not found
      </Typography>
      <Button variant="contained" component={RouterLink} to="/courses">
        Browse courses
      </Button>
    </Box>
  );
}

export default NotFound;

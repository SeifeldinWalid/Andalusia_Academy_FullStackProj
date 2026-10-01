import { Box, Button, Typography } from "@mui/material";
import { Link as RouterLink } from "react-router-dom";

interface Props {
  title: string;
  description: string;
}

function BusinessSection({ title, description }: Props) {
  return (
    <Box sx={{ py: 6, px: 3, textAlign: "center", bgcolor: "primary.main", color: "white", borderRadius: 2, my: 4 }}>
      <Typography variant="h4" sx={{ fontWeight: 700 }}>{title}</Typography>
      <Typography sx={{ mt: 1, mb: 3 }}>{description}</Typography>
      <Button variant="contained" color="secondary" component={RouterLink} to="/business">
        Learn More
      </Button>
    </Box>
  );
}

export default BusinessSection;
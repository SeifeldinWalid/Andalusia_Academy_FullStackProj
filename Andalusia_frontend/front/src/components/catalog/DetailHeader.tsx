import { Box, Breadcrumbs, Link, Typography } from "@mui/material";
import { Link as RouterLink } from "react-router-dom";
import type { ReactNode } from "react";

interface Props {
  backTo: string;
  backLabel: string;
  title: string;
  description: string;
  badges?: ReactNode;
  aside?: ReactNode;
}

// Shared hero block for course, program and career path details
function DetailHeader({ backTo, backLabel, title, description, badges, aside }: Props) {
  return (
    <Box>
      <Breadcrumbs sx={{ mb: 2 }}>
        <Link component={RouterLink} to={backTo} underline="hover" color="inherit">
          {backLabel}
        </Link>
        <Typography color="text.primary">{title}</Typography>
      </Breadcrumbs>

      <Box sx={{ maxWidth: 900 }}>
        {badges}
        <Typography variant="h3" component="h1" sx={{ my: 2, fontSize: { xs: "2rem", md: "2.75rem" } }}>
          {title}
        </Typography>
        <Typography color="text.secondary" sx={{ fontSize: "1.1rem", mb: 3 }}>
          {description}
        </Typography>
        {aside}
      </Box>
    </Box>
  );
}

export default DetailHeader;

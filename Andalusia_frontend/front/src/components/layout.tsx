import { Link as RouterLink, Outlet } from "react-router-dom";
import { AppBar, Box, Button, Container, Toolbar, Typography } from "@mui/material";
import logo from "../assets/logo.png";

const links = [
  { label: "Home", to: "/" },
  { label: "Courses", to: "/courses" },
  { label: "Programs", to: "/programs" },
  { label: "Career Paths", to: "/career-paths" },
  { label: "For Business", to: "/business" },
  { label: "About", to: "/about" },
  { label: "Contact", to: "/contact" },
];

function Layout() {
  return (
    <Box sx={{ minHeight: "100vh", display: "flex", flexDirection: "column" }}>
      <AppBar position="sticky">
        <Toolbar sx={{ flexWrap: "wrap" }}>
          <Box
            component={RouterLink}
            to="/"
            sx={{ flexGrow: 1, display: "flex", alignItems: "center", gap: 1.5, color: "inherit", textDecoration: "none" }}
          >
            <Box component="img" src={logo} alt="Andalusia Academy logo" sx={{ height: 40, width: 40 }} />
            <Typography variant="h6">Andalusia Courses Platform</Typography>
          </Box>
          {links.map((l) => (
            <Button key={l.to} color="secondary" component={RouterLink} to={l.to}>
              {l.label}
            </Button>
          ))}
        </Toolbar>
      </AppBar>

      <Container component="main" sx={{ flexGrow: 1, py: 4 }}>
        <Outlet />
      </Container>

      <Box component="footer" sx={{ py: 3, textAlign: "center", bgcolor: "grey.100" }}>
        <Typography variant="body2">© Andalusia Academy</Typography>
      </Box>
    </Box>
  );
}

export default Layout;
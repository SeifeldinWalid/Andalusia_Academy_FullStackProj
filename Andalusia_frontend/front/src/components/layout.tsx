import { useState } from "react";
import { Link as RouterLink, Outlet } from "react-router-dom";
import {
  AppBar,
  Box,
  Button,
  Container,
  Drawer,
  IconButton,
  List,
  ListItemButton,
  ListItemText,
  Toolbar,
  Typography,
} from "@mui/material";
import { Menu } from "lucide-react";
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
  const [open, setOpen] = useState(false);

  return (
    <Box sx={{ minHeight: "100vh", display: "flex", flexDirection: "column" }}>
      <AppBar position="sticky">
        <Toolbar>
          <Box
            component={RouterLink}
            to="/"
            sx={{
              flexGrow: 1,
              minWidth: 0,
              display: "flex",
              alignItems: "center",
              gap: 1.5,
              color: "inherit",
              textDecoration: "none",
            }}
          >
            <Box component="img" src={logo} alt="Andalusia Academy logo" sx={{ height: 40, width: 40 }} />
            <Typography variant="h6" noWrap sx={{ fontSize: { xs: "1rem", sm: "1.25rem" } }}>
              Andalusia Courses Platform
            </Typography>
          </Box>

          {/* Desktop: buttons */}
          <Box sx={{ display: { xs: "none", lg: "block" } }}>
            {links.map((l) => (
              <Button key={l.to} color="secondary" component={RouterLink} to={l.to}>
                {l.label}
              </Button>
            ))}
          </Box>

          {/* Mobile and tablet: hamburger */}
          <IconButton
            color="inherit"
            aria-label="Open menu"
            onClick={() => setOpen(true)}
            sx={{ display: { xs: "inline-flex", lg: "none" } }}
          >
            <Menu />
          </IconButton>
        </Toolbar>
      </AppBar>

      <Drawer anchor="right" open={open} onClose={() => setOpen(false)}>
        <List sx={{ width: 240 }}>
          {links.map((l) => (
            <ListItemButton key={l.to} component={RouterLink} to={l.to} onClick={() => setOpen(false)}>
              <ListItemText primary={l.label} />
            </ListItemButton>
          ))}
        </List>
      </Drawer>

      <Container component="main" sx={{ flexGrow: 1, py: { xs: 2, md: 4 } }}>
        <Outlet />
      </Container>

      <Box component="footer" sx={{ py: 3, textAlign: "center", bgcolor: "grey.100" }}>
        <Typography variant="body2">© Andalusia Academy</Typography>
      </Box>
    </Box>
  );
}

export default Layout;
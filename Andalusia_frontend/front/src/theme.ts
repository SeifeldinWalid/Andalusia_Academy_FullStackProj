import { createTheme } from "@mui/material/styles";

const theme = createTheme({
  palette: {
    primary: { main: "#7d1427" },
    secondary: { main: "#f9a825" },
    info: { main: "#d4d1ce"
    // info: { main: "rgb(127, 124, 124)"
     },
  },
  shape: { borderRadius: 10 },
});

export default theme;
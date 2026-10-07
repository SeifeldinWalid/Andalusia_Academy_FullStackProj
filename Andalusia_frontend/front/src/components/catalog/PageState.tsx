import { Alert, Box, Button, CircularProgress } from "@mui/material";
import { Link as RouterLink } from "react-router-dom";

export function Loading() {
  return (
    <Box sx={{ display: "flex", justifyContent: "center", alignItems: "center", minHeight: "40vh" }}>
      <CircularProgress />
    </Box>
  );
}

interface ErrorProps {
  message: string;
  backTo?: string;
  backLabel?: string;
}

export function ErrorState({ message, backTo, backLabel }: ErrorProps) {
  return (
    <Alert
      severity="error"
      action={
        backTo && (
          <Button color="inherit" size="small" component={RouterLink} to={backTo}>
            {backLabel ?? "Back"}
          </Button>
        )
      }
    >
      {message}
    </Alert>
  );
}

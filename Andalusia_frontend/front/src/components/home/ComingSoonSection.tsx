import { Box, Typography } from "@mui/material";

interface Props {
  text: string;
}

function ComingSoonSection({ text }: Props) {
  return (
    <Box
      sx={{
        display: "flex",
        justifyContent: "center",
        flexDirection: "column",
        py: 4,
        textAlign: "center",
        bgcolor: "secondary.light",
        borderRadius: 2,
        my: 4,
      }}
    >
      <Typography variant="h5" sx={{ fontWeight: 600 }}>
        Coming Soon
      </Typography>
      <Typography sx={{ mt: 1 }}>{text}</Typography>
    </Box>
  );
}

export default ComingSoonSection;

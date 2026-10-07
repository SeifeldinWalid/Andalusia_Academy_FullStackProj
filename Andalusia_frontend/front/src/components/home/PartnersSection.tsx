import { Box, Typography } from "@mui/material";
import type { Partner } from "../../types";

interface Props {
  partners: Partner[];
}

function PartnersSection({ partners }: Props) {
  return (
    <Box sx={{ py: 4, textAlign: "center" }}>
      <Typography variant="h4" sx={{ mb: 3 }}>Trusted by</Typography>
      <Box sx={{ display: "flex", flexWrap: "wrap", justifyContent: "center", gap: 4 }}>
        {partners.map((p) => (
          <Typography key={p.id} variant="h6" color="text.secondary" sx={{ fontWeight: 600 }}>
            {p.name}
          </Typography>
        ))}
      </Box>
    </Box>
  );
}

export default PartnersSection;
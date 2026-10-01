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
          <Box key={p.id} component="img" src={p.logoUrl} alt={p.name} sx={{ height: 50 }} color = "secondary" />
        ))}
      </Box>
    </Box>
  );
}

export default PartnersSection;
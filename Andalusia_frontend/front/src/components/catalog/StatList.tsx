import { Box, Paper, Typography } from "@mui/material";

interface Stat {
  label: string;
  value: string | number;
}

// Row of key facts shown under a detail page title
function StatList({ stats }: { stats: Stat[] }) {
  return (
    <Paper variant="outlined" sx={{ display: "flex", flexWrap: "wrap" }}>
      {stats.map((s, i) => (
        <Box
          key={s.label}
          sx={{
            flex: "1 1 120px",
            p: 2,
            borderLeft: i === 0 ? "none" : "1px solid",
            borderColor: "divider",
          }}
        >
          <Typography variant="body2" color="text.secondary">
            {s.label}
          </Typography>
          <Typography sx={{ fontWeight: 600 }}>{s.value}</Typography>
        </Box>
      ))}
    </Paper>
  );
}

export default StatList;

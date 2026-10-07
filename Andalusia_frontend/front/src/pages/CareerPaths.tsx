import { Box, Typography } from "@mui/material";
import useFetch from "../hooks/useFetch";
import { getCareerPaths } from "../services/careerPathService";
import CareerPathCard from "../components/catalog/CareerPathCard";
import { CardGrid } from "../components/catalog/Section";
import { ErrorState, Loading } from "../components/catalog/PageState";

function CareerPaths() {
  const { data, loading, error } = useFetch(getCareerPaths);

  return (
    <Box>
      <Typography variant="h4" sx={{ mb: 1 }}>
        Career Paths
      </Typography>
      <Typography color="text.secondary" sx={{ mb: 3 }}>
        Pick the job you want. Each path bundles the programs and skills that get you there.
      </Typography>

      {loading && <Loading />}
      {!loading && error && <ErrorState message={error} />}
      {!loading && !error && (
        !data || data.length === 0 ? (
          <Typography>No career paths found.</Typography>
        ) : (
          <CardGrid>
            {data.map((cp) => (
              <CareerPathCard key={cp.id} careerPath={cp} />
            ))}
          </CardGrid>
        )
      )}
    </Box>
  );
}

export default CareerPaths;

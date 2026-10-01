import { Alert, Box, CircularProgress } from "@mui/material";
import useFetch from "../hooks/useFetch";
import { getHomepage } from "../services/homepageService";
import type { Homepage } from "../types";
import HeroSection from "../components/home/HeroSection";
import CategoriesSection from "../components/home/CategoriesSection";
import FeaturedCoursesSection from "../components/home/FeaturedCoursesSection";
import ComingSoonSection from "../components/home/ComingSoonSection";
import BusinessSection from "../components/home/BusinessSection";
import PartnersSection from "../components/home/PartnersSection";
import TestimonialsSection from "../components/home/TestimonialsSection";

function Home() {
  const { data, loading, error } = useFetch<Homepage>(getHomepage);

  if (loading) return <Box sx={{ display: "flex", justifyContent: "center", alignItems: "center", minHeight: "60vh" }}><CircularProgress /></Box>;
  if (error) return <Alert severity="error">{error}</Alert>;
  if (!data) return null;

  return (
    <>
      <HeroSection title={data.heroTitle} subtitle={data.heroSubtitle} />
      <CategoriesSection categories={data.popularCategories} />
      <FeaturedCoursesSection courses={data.featuredCourses} />
      <Box
        sx={{
          display: "grid",
          gap: 2,
          gridTemplateColumns: { xs: "1fr", md: "repeat(2, 1fr)" },
          mb: 4,
        }}
      >
        <ComingSoonSection text={data.comingSoonText} />
        <BusinessSection
          title={data.corporateTitle}
          description={data.corporateDescription}
        />
      </Box>
      <PartnersSection partners={data.partners} />
      <TestimonialsSection testimonials={data.testimonials} />
    </>
  );
}

export default Home;

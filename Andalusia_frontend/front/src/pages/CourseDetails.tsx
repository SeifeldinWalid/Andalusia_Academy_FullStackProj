import { useCallback } from "react";
import { Link as RouterLink, useParams } from "react-router-dom";
import { Chip, Divider, Link, Stack } from "@mui/material";
import useFetch from "../hooks/useFetch";
import { getCourseDetails } from "../services/courseService";
import DetailHeader from "../components/catalog/DetailHeader";
import StatList from "../components/catalog/StatList";
import CourseCard from "../components/catalog/CourseCard";
import ProgramCard from "../components/catalog/ProgramCard";
import { CardGrid, Section, SkillChips } from "../components/catalog/Section";
import { ErrorState, Loading } from "../components/catalog/PageState";
import { formatPrice, levelColor, statusLabel } from "../components/catalog/labels";

function CourseDetails() {
  const id = Number(useParams().id);
  const fetchCourse = useCallback(() => getCourseDetails(id), [id]);
  const { data: course, loading, error } = useFetch(fetchCourse);

  if (loading) return <Loading />;
  if (error || !course) return <ErrorState message={error} backTo="/courses" backLabel="All courses" />;

  return (
    <>
      <DetailHeader
        backTo="/courses"
        backLabel="Courses"
        title={course.title}
        description={course.description}
        badges={
          <Stack direction="row" spacing={1} sx={{ flexWrap: "wrap" }}>
            {course.categoryName && (
              <Chip
                label={course.categoryName}
                color="primary"
                component={RouterLink}
                to={`/courses?categoryId=${course.categoryId}`}
                clickable
              />
            )}
            <Chip label={course.level} color={levelColor[course.level]} variant="outlined" />
            {course.status === "ComingSoon" && <Chip label={statusLabel(course.status)} color="secondary" />}
          </Stack>
        }
        aside={
          <StatList
            stats={[
              { label: "Price", value: formatPrice(course.price) },
              { label: "Duration", value: `${course.durationHours} hours` },
              { label: "Format", value: course.type },
              { label: "Availability", value: statusLabel(course.status) },
            ]}
          />
        }
      />

      <Divider sx={{ my: 4 }} />

      <Section title="Skills you'll gain" empty={course.skills.length === 0}>
        <SkillChips skills={course.skills} />
      </Section>

      <Section
        title="Part of these programs"
        empty={course.programs.length === 0}
        emptyText="This course is offered on its own."
      >
        <CardGrid>
          {course.programs.map((p) => (
            <ProgramCard key={p.id} program={p} />
          ))}
        </CardGrid>
      </Section>

      <Section title="Related courses" empty={course.relatedCourses.length === 0}>
        <CardGrid>
          {course.relatedCourses.map((c) => (
            <CourseCard key={c.id} course={c} />
          ))}
        </CardGrid>
      </Section>

      <Link component={RouterLink} to="/courses">
        ← Back to all courses
      </Link>
    </>
  );
}

export default CourseDetails;

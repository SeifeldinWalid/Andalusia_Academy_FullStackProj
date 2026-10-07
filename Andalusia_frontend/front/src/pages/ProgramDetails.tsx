import { useCallback } from "react";
import { Link as RouterLink, useParams } from "react-router-dom";
import { Chip, Divider, Link } from "@mui/material";
import useFetch from "../hooks/useFetch";
import { getProgramDetails } from "../services/programService";
import DetailHeader from "../components/catalog/DetailHeader";
import StatList from "../components/catalog/StatList";
import CourseCard from "../components/catalog/CourseCard";
import ProgramCard from "../components/catalog/ProgramCard";
import CareerPathCard from "../components/catalog/CareerPathCard";
import { CardGrid, Section, SkillChips } from "../components/catalog/Section";
import { ErrorState, Loading } from "../components/catalog/PageState";
import { levelColor } from "../components/catalog/labels";

function ProgramDetails() {
  const id = Number(useParams().id);
  const fetchProgram = useCallback(() => getProgramDetails(id), [id]);
  const { data: program, loading, error } = useFetch(fetchProgram);

  if (loading) return <Loading />;
  if (error || !program) return <ErrorState message={error} backTo="/programs" backLabel="All programs" />;

  const courses = [...program.courses].sort((a, b) => a.order - b.order);

  return (
    <>
      <DetailHeader
        backTo="/programs"
        backLabel="Programs"
        title={program.title}
        description={program.description}
        badges={<Chip label={program.level} color={levelColor[program.level]} variant="outlined" />}
        aside={
          <StatList
            stats={[
              { label: "Courses", value: program.courseCount },
              { label: "Duration", value: `${program.durationWeeks} weeks` },
              { label: "Total content", value: `${program.totalHours} hours` },
            ]}
          />
        }
      />

      <Divider sx={{ my: 4 }} />

      <Section title="Program structure" empty={courses.length === 0}>
        <CardGrid>
          {courses.map((c) => (
            <CourseCard key={c.id} course={c} order={c.order} />
          ))}
        </CardGrid>
      </Section>

      <Section title="Skills covered" empty={program.skills.length === 0}>
        <SkillChips skills={program.skills} />
      </Section>

      <Section
        title="Leads to these career paths"
        empty={program.careerPaths.length === 0}
        emptyText="This program isn't part of a career path yet."
      >
        <CardGrid>
          {program.careerPaths.map((cp) => (
            <CareerPathCard key={cp.id} careerPath={cp} />
          ))}
        </CardGrid>
      </Section>

      <Section title="Related programs" empty={program.relatedPrograms.length === 0}>
        <CardGrid>
          {program.relatedPrograms.map((p) => (
            <ProgramCard key={p.id} program={p} />
          ))}
        </CardGrid>
      </Section>

      <Link component={RouterLink} to="/programs">
        ← Back to all programs
      </Link>
    </>
  );
}

export default ProgramDetails;

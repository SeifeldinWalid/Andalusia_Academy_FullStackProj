// Enums are sent by the API as strings (JsonStringEnumConverter)
export type CourseStatus = "Draft" | "Published" | "ComingSoon" | "Archived";
export type CourseType = "Online" | "Onsite" | "Recorded" | "Hybrid";
export type CourseLevel = "Beginner" | "Intermediate" | "Advanced";

export interface Skill {
  id: number;
  name: string;
}

export interface CourseSummary {
  id: number;
  title: string;
  imageUrl: string | null;
  price: number;
  durationHours: number;
  status: CourseStatus;
  type: CourseType;
  level: CourseLevel;
  categoryName: string | null;
}

// Kept for the homepage sections
export type Course = CourseSummary;

export interface CourseListItem extends CourseSummary {
  description: string;
  categoryId: number | null;
}

export interface CourseDetails extends CourseListItem {
  skills: Skill[];
  programs: ProgramSummary[];
  relatedCourses: CourseSummary[];
}

export interface ProgramSummary {
  id: number;
  title: string;
  description: string;
  imageUrl: string | null;
  level: CourseLevel;
  durationWeeks: number;
  courseCount: number;
}

export interface ProgramCourse extends CourseSummary {
  order: number;
}

export interface ProgramDetails extends ProgramSummary {
  totalHours: number;
  courses: ProgramCourse[];
  skills: Skill[];
  careerPaths: CareerPathSummary[];
  relatedPrograms: ProgramSummary[];
}

export interface CareerPathSummary {
  id: number;
  title: string;
  description: string;
  imageUrl: string | null;
  estimatedMonths: number;
  programCount: number;
}

export interface CareerPathDetails extends CareerPathSummary {
  skills: Skill[];
  programs: ProgramSummary[];
  recommendedCourses: CourseSummary[];
}

export interface PageResult<T> {
  data: T[];
  page: number;
  pageSize: number;
  totalCount: number;
  totalPages: number;
  hasNextPage: boolean;
  hasPreviousPage: boolean;
}

export interface CourseFilter {
  search?: string;
  categoryId?: number;
  skillId?: number;
  status?: CourseStatus;
  type?: CourseType;
  level?: CourseLevel;
  minPrice?: number;
  maxPrice?: number;
  sortBy?: "title" | "price" | "duration" | "createdAt";
  order?: "asc" | "desc";
  page?: number;
  pageSize?: number;
}

export interface Category {
  id: number;
  name: string;
  courseCount: number;
}

export interface Partner {
  id: number;
  name: string;
  logoUrl: string;
}

export interface Testimonial {
  id: number;
  authorName: string;
  role: string;
  content: string;
  avatarUrl: string | null;
}

export interface Homepage {
  heroTitle: string;
  heroSubtitle: string;
  heroImageUrl: string | null;
  corporateTitle: string;
  corporateDescription: string;
  comingSoonText: string;
  featuredCourses: CourseSummary[];
  popularCategories: Category[];
  partners: Partner[];
  testimonials: Testimonial[];
}

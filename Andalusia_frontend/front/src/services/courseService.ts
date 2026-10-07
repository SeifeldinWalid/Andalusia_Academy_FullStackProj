import api from "./api";
import type {
  Category,
  CourseDetails,
  CourseFilter,
  CourseListItem,
  PageResult,
} from "../types";

export async function getCourses() {
  const response = await api.get<CourseListItem[]>("/PublicCatalog/courses");
  return response.data;
}

export async function searchCourses(filter: CourseFilter) {
  const response = await api.get<PageResult<CourseListItem>>(
    "/PublicCatalog/courses/search",
    { params: filter }
  );
  return response.data;
}

export async function getCourseDetails(id: number) {
  const response = await api.get<CourseDetails>(`/PublicCatalog/courses/${id}`);
  return response.data;
}

export async function getCategories() {
  const response = await api.get<Category[]>("/PublicCatalog/categories");
  return response.data;
}

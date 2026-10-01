import api from "./api";
import type { Course, Category } from "../types";

export async function getCourses() {
  const response = await api.get<Course[]>("/PublicCatalog/courses");
  return response.data;
}

export async function getCategories() {
  const response = await api.get<Category[]>("/PublicCatalog/categories");
  return response.data;
}
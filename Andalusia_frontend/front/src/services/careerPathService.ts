import api from "./api";
import type { CareerPathDetails, CareerPathSummary } from "../types";

export async function getCareerPaths() {
  const response = await api.get<CareerPathSummary[]>("/CareerPaths");
  return response.data;
}

export async function getCareerPathDetails(id: number) {
  const response = await api.get<CareerPathDetails>(`/CareerPaths/${id}`);
  return response.data;
}

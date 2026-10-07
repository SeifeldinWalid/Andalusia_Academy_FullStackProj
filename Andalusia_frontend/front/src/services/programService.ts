import api from "./api";
import type { ProgramDetails, ProgramSummary } from "../types";

export async function getPrograms() {
  const response = await api.get<ProgramSummary[]>("/Programs");
  return response.data;
}

export async function getProgramDetails(id: number) {
  const response = await api.get<ProgramDetails>(`/Programs/${id}`);
  return response.data;
}

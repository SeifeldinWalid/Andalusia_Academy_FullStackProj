import api from "./api";
import type { Homepage } from "../types";

export async function getHomepage() {
  const response = await api.get<Homepage>("/homepage");
  return response.data;
}
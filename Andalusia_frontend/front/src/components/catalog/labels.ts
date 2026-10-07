import type { CourseLevel, CourseStatus, CourseType } from "../../types";

export const levels: CourseLevel[] = ["Beginner", "Intermediate", "Advanced"];
export const types: CourseType[] = ["Online", "Onsite", "Recorded", "Hybrid"];
// Draft and Archived courses are never returned by the public API
export const publicStatuses: CourseStatus[] = ["Published", "ComingSoon"];

export function statusLabel(status: CourseStatus) {
  return status === "ComingSoon" ? "Coming Soon" : status;
}

export function formatPrice(price: number) {
  return price === 0 ? "Free" : `${price} L.E`;
}

export const levelColor: Record<CourseLevel, "success" | "warning" | "error"> = {
  Beginner: "success",
  Intermediate: "warning",
  Advanced: "error",
};

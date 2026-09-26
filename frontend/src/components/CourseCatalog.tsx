import { useEffect, useState } from "react";
import apiClient from "../api/axios";

// Define the matching TypeScript interface for CourseSummaryDTO
interface CourseSummary {
  id: number;
  title: string;
  imageUrl?: string;
  price: number;
  categoryName?: string;
}

export default function CourseCatalog() {
  const [courses, setCourses] = useState<CourseSummary[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState("");

  useEffect(() => {
    // Fetch courses from the backend
    apiClient
      .get<CourseSummary[]>("/PublicCatalog/courses")
      .then((response) => {
        setCourses(response.data);
        setLoading(false);
      })
      .catch((err) => {
        console.error(err);
        setError(
          "Failed to load courses. Please make sure the backend is running.",
        );
        setLoading(false);
      });
  }, []);

  if (loading)
    return (
      <div
        style={{
          padding: "4rem",
          textAlign: "center",
          color: "#D4AF37",
          fontSize: "1.2rem",
        }}
      >
        Loading our premium courses...
      </div>
    );
  if (error)
    return (
      <div style={{ padding: "4rem", color: "#e74c3c", textAlign: "center" }}>
        {error}
      </div>
    );
  if (courses.length === 0)
    return (
      <div style={{ padding: "4rem", textAlign: "center", color: "#555" }}>
        No courses available at the moment.
      </div>
    );

  return (
    <div style={{ padding: "3rem 2rem", maxWidth: "1200px", margin: "0 auto" }}>
      <div style={{ textAlign: "center", marginBottom: "3rem" }}>
        <h2
          style={{ fontSize: "2.5rem", color: "#333", marginBottom: "0.5rem" }}
        >
          Explore Our Programs
        </h2>
        <div
          style={{
            width: "60px",
            height: "3px",
            backgroundColor: "#D4AF37",
            margin: "0 auto",
          }}
        ></div>
      </div>

      {/* Clean Grid Layout */}
      <div
        style={{
          display: "grid",
          gridTemplateColumns: "repeat(auto-fill, minmax(320px, 1fr))",
          gap: "2rem",
        }}
      >
        {courses.map((course) => (
          <div
            key={course.id}
            style={{
              backgroundColor: "#FFFFFF",
              border: "1px solid #EAEAEA",
              borderRadius: "8px",
              overflow: "hidden",
              transition: "transform 0.2s, box-shadow 0.2s",
              cursor: "pointer",
            }}
            onMouseEnter={(e) => {
              e.currentTarget.style.transform = "translateY(-5px)";
              e.currentTarget.style.boxShadow = "0 10px 20px rgba(0,0,0,0.05)";
            }}
            onMouseLeave={(e) => {
              e.currentTarget.style.transform = "translateY(0)";
              e.currentTarget.style.boxShadow = "none";
            }}
          >
            {/* Image Placeholder if imageUrl is missing */}
            <div
              style={{
                width: "100%",
                height: "220px",
                backgroundColor: "#F5F5F5",
                display: "flex",
                alignItems: "center",
                justifyContent: "center",
              }}
            >
              {course.imageUrl ? (
                <img
                  src={course.imageUrl}
                  alt={course.title}
                  style={{ width: "100%", height: "100%", objectFit: "cover" }}
                />
              ) : (
                <span style={{ color: "#CCC", fontSize: "3rem" }}>📸</span>
              )}
            </div>

            <div style={{ padding: "1.5rem" }}>
              <div
                style={{
                  display: "flex",
                  justifyContent: "space-between",
                  alignItems: "flex-start",
                  marginBottom: "1rem",
                }}
              >
                {course.categoryName && (
                  <span
                    style={{
                      color: "#D4AF37",
                      fontSize: "0.8rem",
                      fontWeight: "600",
                      textTransform: "uppercase",
                      letterSpacing: "1px",
                    }}
                  >
                    {course.categoryName}
                  </span>
                )}
                <span
                  style={{
                    fontWeight: "bold",
                    fontSize: "1.2rem",
                    color: "#333",
                  }}
                >
                  ${course.price.toFixed(2)}
                </span>
              </div>

              <h3
                style={{
                  margin: "0 0 1.5rem 0",
                  color: "#222",
                  fontSize: "1.3rem",
                  lineHeight: "1.4",
                }}
              >
                {course.title}
              </h3>

              <button
                style={{
                  width: "100%",
                  padding: "0.8rem",
                  backgroundColor: "transparent",
                  color: "#D4AF37",
                  border: "1px solid #D4AF37",
                  borderRadius: "4px",
                  fontWeight: "600",
                  cursor: "pointer",
                  transition: "all 0.2s",
                }}
                onMouseEnter={(e) => {
                  e.currentTarget.style.backgroundColor = "#D4AF37";
                  e.currentTarget.style.color = "#FFF";
                }}
                onMouseLeave={(e) => {
                  e.currentTarget.style.backgroundColor = "transparent";
                  e.currentTarget.style.color = "#D4AF37";
                }}
              >
                View Course Details
              </button>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
}

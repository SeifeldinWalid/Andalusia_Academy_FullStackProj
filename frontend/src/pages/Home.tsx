import { Link } from "react-router-dom";

export default function Home() {
  return (
    <div
      style={{
        padding: "4rem 2rem",
        textAlign: "center",
        maxWidth: "800px",
        margin: "0 auto",
      }}
    >
      <h1 style={{ fontSize: "3rem", color: "#333", marginBottom: "1rem" }}>
        Welcome to <span style={{ color: "#D4AF37" }}>Andalusia Academy</span>
      </h1>
      <p
        style={{
          fontSize: "1.2rem",
          color: "#666",
          marginBottom: "2.5rem",
          lineHeight: "1.6",
        }}
      >
        Empowering the next generation of full-stack developers and leaders.
        Discover our world-class programs designed for your success.
      </p>

      <div style={{ display: "flex", gap: "1rem", justifyContent: "center" }}>
        <Link
          to="/courses"
          style={{
            padding: "1rem 2rem",
            backgroundColor: "#D4AF37",
            color: "white",
            fontWeight: "bold",
            borderRadius: "4px",
            boxShadow: "0 4px 6px rgba(212, 175, 55, 0.3)",
            transition: "transform 0.2s",
          }}
          onMouseEnter={(e) =>
            (e.currentTarget.style.transform = "translateY(-2px)")
          }
          onMouseLeave={(e) =>
            (e.currentTarget.style.transform = "translateY(0)")
          }
        >
          Explore Courses
        </Link>
        <Link
          to="/about"
          style={{
            padding: "1rem 2rem",
            backgroundColor: "transparent",
            color: "#333",
            border: "2px solid #333",
            fontWeight: "bold",
            borderRadius: "4px",
            transition: "transform 0.2s",
          }}
          onMouseEnter={(e) =>
            (e.currentTarget.style.transform = "translateY(-2px)")
          }
          onMouseLeave={(e) =>
            (e.currentTarget.style.transform = "translateY(0)")
          }
        >
          Learn More
        </Link>
      </div>
    </div>
  );
}

import { Link, useLocation } from "react-router-dom";

export default function Navbar() {
  const location = useLocation();

  const navLinks = [
    { name: "Home", path: "/" },
    { name: "About", path: "/about" },
    { name: "Courses", path: "/courses" },
    { name: "Contact", path: "/contact" },
  ];

  return (
    <nav
      style={{
        backgroundColor: "#FFFFFF",
        borderBottom: "2px solid #D4AF37", // Gold bottom border
        boxShadow: "0 4px 6px -1px rgba(0, 0, 0, 0.05)",
        position: "sticky",
        top: 0,
        zIndex: 1000,
      }}
    >
      <div
        style={{
          maxWidth: "1200px",
          margin: "0 auto",
          padding: "1rem 2rem",
          display: "flex",
          justifyContent: "space-between",
          alignItems: "center",
        }}
      >
        {/* Brand / Logo Area */}
        <Link
          to="/"
          style={{ display: "flex", alignItems: "center", gap: "10px" }}
        >
          <div
            style={{
              width: "40px",
              height: "40px",
              backgroundColor: "#D4AF37", // Gold Logo block
              borderRadius: "8px",
              display: "flex",
              alignItems: "center",
              justifyContent: "center",
              color: "white",
              fontWeight: "bold",
              fontSize: "1.2rem",
            }}
          >
            AA
          </div>
          <span
            style={{ fontSize: "1.5rem", fontWeight: "bold", color: "#333" }}
          >
            Andalusia <span style={{ color: "#D4AF37" }}>Academy</span>
          </span>
        </Link>

        {/* Desktop Navigation */}
        <ul style={{ display: "flex", gap: "2rem", alignItems: "center" }}>
          {navLinks.map((link) => {
            const isActive = location.pathname === link.path;
            return (
              <li key={link.name}>
                <Link
                  to={link.path}
                  style={{
                    color: isActive ? "#D4AF37" : "#555",
                    fontWeight: isActive ? "600" : "400",
                    transition: "color 0.2s",
                    fontSize: "1rem",
                  }}
                  onMouseEnter={(e) =>
                    (e.currentTarget.style.color = "#D4AF37")
                  }
                  onMouseLeave={(e) =>
                    (e.currentTarget.style.color = isActive
                      ? "#D4AF37"
                      : "#555")
                  }
                >
                  {link.name}
                </Link>
              </li>
            );
          })}
        </ul>

        {/* Action Buttons */}
        <div style={{ display: "flex", gap: "1rem" }}>
          <Link
            to="/login"
            style={{
              padding: "0.5rem 1.5rem",
              color: "#333",
              fontWeight: "600",
              border: "2px solid transparent",
            }}
          >
            Log in
          </Link>
          <Link
            to="/register"
            style={{
              padding: "0.5rem 1.5rem",
              backgroundColor: "#D4AF37", // Gold button
              color: "#FFFFFF",
              fontWeight: "600",
              borderRadius: "4px",
              transition: "background-color 0.2s",
              boxShadow: "0 2px 4px rgba(212, 175, 55, 0.3)",
            }}
          >
            Sign up
          </Link>
        </div>
      </div>
    </nav>
  );
}

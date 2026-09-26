import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Navbar from "./components/Navbar";
import CourseCatalog from "./components/CourseCatalog";
import Home from "./pages/Home";

function App() {
  return (
    <Router>
      <div
        style={{ minHeight: "100vh", display: "flex", flexDirection: "column" }}
      >
        {/* The Navbar will appear on every page */}
        <Navbar />

        {/* Main Content Area */}
        <main style={{ flex: 1 }}>
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/courses" element={<CourseCatalog />} />
            <Route
              path="/about"
              element={
                <div style={{ padding: "4rem", textAlign: "center" }}>
                  <h2 style={{ color: "#D4AF37" }}>About Us</h2>
                  <p style={{ marginTop: "1rem", color: "#555" }}>
                    We are Andalusia Academy. More details coming soon!
                  </p>
                </div>
              }
            />
            <Route
              path="/contact"
              element={
                <div style={{ padding: "4rem", textAlign: "center" }}>
                  <h2 style={{ color: "#D4AF37" }}>Contact</h2>
                  <p style={{ marginTop: "1rem", color: "#555" }}>
                    Contact form coming soon!
                  </p>
                </div>
              }
            />

            {/* Fallback route */}
            <Route
              path="*"
              element={
                <div style={{ padding: "4rem", textAlign: "center" }}>
                  <h2>404 - Page Not Found</h2>
                </div>
              }
            />
          </Routes>
        </main>

        {/* Footer */}
        <footer
          style={{
            backgroundColor: "#FFFFFF",
            borderTop: "1px solid #EAEAEA",
            padding: "2rem",
            textAlign: "center",
            color: "#888",
            fontSize: "0.9rem",
          }}
        >
          &copy; {new Date().getFullYear()} Andalusia Academy MVP. Built for
          Phase 1.
        </footer>
      </div>
    </Router>
  );
}

export default App;

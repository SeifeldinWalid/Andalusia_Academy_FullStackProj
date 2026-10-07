import { useEffect, useState } from "react";
import { isAxiosError } from "axios";

// Pass a stable fetcher (module function or useCallback) - it re-runs when the fetcher changes
function useFetch<T>(fetcher: () => Promise<T>) {
  const [data, setData] = useState<T | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState("");

  useEffect(() => {
    // Ignore responses that arrive after the fetcher changed (e.g. fast filter changes)
    let cancelled = false;

    async function load() {
      try {
        setLoading(true);
        setError("");
        const result = await fetcher();
        if (!cancelled) setData(result);
      } catch (err) {
        if (cancelled) return;
        setData(null);
        if (isAxiosError(err) && err.response?.status === 404) {
          setError("We couldn't find what you were looking for.");
        } else {
          setError("Could not load data.");
        }
      } finally {
        if (!cancelled) setLoading(false);
      }
    }

    load();
    return () => {
      cancelled = true;
    };
  }, [fetcher]);

  return { data, loading, error };
}

export default useFetch;

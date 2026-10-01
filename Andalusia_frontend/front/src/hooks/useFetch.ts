import { useEffect, useState } from "react";

function useFetch<T>(fetcher: () => Promise<T>) {
  const [data, setData] = useState<T | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState("");

  useEffect(() => {
    async function load() {
      try {
        setLoading(true);
        setError("");
        setData(await fetcher());
      } catch {
        setError("Could not load data.");
      } finally {
        setLoading(false);
      }
    }

    load();
  }, [fetcher]);

  return { data, loading, error };
}

export default useFetch;
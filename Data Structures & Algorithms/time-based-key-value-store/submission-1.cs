public class TimeMap {
    private Dictionary<string, Dictionary<int, List<string>>> keyStore;

    public TimeMap() {
        keyStore = new Dictionary<string, Dictionary<int, List<string>>>();
    }

    public void Set(string key, string value, int timestamp) {
        if (!keyStore.ContainsKey(key)) {
            keyStore[key] = new Dictionary<int, List<string>>();
        }
        if (!keyStore[key].ContainsKey(timestamp)) {
            keyStore[key][timestamp] = new List<string>();
        }
        keyStore[key][timestamp].Add(value);
    }

    public string Get(string key, int timestamp) {
        if (!keyStore.ContainsKey(key)) {
            return "";
        }
        var timestamps = keyStore[key];
        int seen = -1;

        foreach (var time in timestamps.Keys) {
            if (time <= timestamp) {
                seen = Math.Max(seen, time);
            }
        }
        return seen == -1 ? "" : timestamps[seen][^1];
    }
}
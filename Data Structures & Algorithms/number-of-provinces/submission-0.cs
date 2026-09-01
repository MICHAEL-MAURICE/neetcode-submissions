public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        int n = isConnected.Length;
        bool[] visited = new bool[n];
        int res = 0;

        for (int i = 0; i < n; i++) {
            if (!visited[i]) {
                Dfs(i, isConnected, visited, n);
                res++;
            }
        }
        return res;
    }

    private void Dfs(int node, int[][] isConnected, bool[] visited, int n) {
        visited[node] = true;
        for (int nei = 0; nei < n; nei++) {
            if (isConnected[node][nei] == 1 && !visited[nei]) {
                Dfs(nei, isConnected, visited, n);
            }
        }
    }
}
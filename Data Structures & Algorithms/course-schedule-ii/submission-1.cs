public class Solution
{
    private Dictionary<int, List<int>> preMap = new();
    private HashSet<int> visiting = new();
    private HashSet<int> visited = new();
    private List<int> result = new();

    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        for (int i = 0; i < numCourses; i++)
        {
            preMap[i] = new List<int>();
        }

        foreach (var pre in prerequisites)
        {
            preMap[pre[0]].Add(pre[1]);
        }

        for (int i = 0; i < numCourses; i++)
        {
            if (!Dfs(i))
            {
                return new int[0];
            }
        }

        return result.ToArray();
    }

    private bool Dfs(int course)
    {
        if (visiting.Contains(course))
        {
            return false;
        }

        if (visited.Contains(course))
        {
            return true;
        }

        visiting.Add(course);

        foreach (int pre in preMap[course])
        {
            if (!Dfs(pre))
            {
                return false;
            }
        }

        visiting.Remove(course);
        visited.Add(course);

        result.Add(course);
        preMap[course].Clear();

        return true;
    }
}
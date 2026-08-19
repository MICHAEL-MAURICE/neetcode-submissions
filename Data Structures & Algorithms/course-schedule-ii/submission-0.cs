public class Solution {
    private Dictionary<int,List<int>> map= new Dictionary<int,List<int>>() ;
    private HashSet<int>visiting= new HashSet<int>();
     private HashSet<int>visited= new HashSet<int>();
    private List<int>result=new List<int>();
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
       
        for(int i=0;i<numCourses;i++){
            map[i]=new List<int>();
        }
        foreach(var pair in prerequisites){
            map[pair[0]].Add(pair[1]);
        }

        for(int i=0;i<numCourses;i++){         
            if( !dfs(i)){
                return Array.Empty<int>();
            }
        }

        return result.ToArray();
    }

    private bool dfs(int i){
        if(visiting.Contains(i)){
            return false;
        }
         if(visited.Contains(i))return true;   

          visiting.Add(i);
        foreach(var val in map[i]){
            
            if(!dfs(val)){
                return false;
             }
        }
        visited.Add(i);
        result.Add(i);
        visiting.Remove(i);
        map[i].Clear();
        return true;


    }


}

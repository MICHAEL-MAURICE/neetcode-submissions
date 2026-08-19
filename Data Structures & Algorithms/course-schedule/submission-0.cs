public class Solution {
        private Dictionary<int, List<int>> preMap=new() ;
        private HashSet<int> visiting=new();
      
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        for(int i=0;i<numCourses;i++){
            preMap[i]=new List<int>();
        }

        foreach (var prop in prerequisites){
            preMap[prop[0]].Add(prop[1]);
        }

       for(int i=0;i<numCourses;i++){
            if(!dfs(i)){
                return false;
            }

       }
return true;
    }
private bool dfs(int i){
    if(visiting.Contains(i)){
        //cycle
        return false;
    }
    if(preMap[i].Count==0) return true;

visiting.Add(i);
foreach(var val in preMap[i]){
    if(!dfs(val)){
        return false;
    }
}

visiting.Remove(i);
preMap[i].Clear();
return true;
}

}

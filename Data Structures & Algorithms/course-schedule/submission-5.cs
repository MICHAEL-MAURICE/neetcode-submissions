public class Solution {
   private Dictionary<int,List<int>>pre= new();
    private HashSet<int>visiting=new();
   public bool CanFinish(int numCourses, int[][] prerequisites) {
        for(int i=0;i<numCourses;i++){
            pre[i]=new List<int>();
        }
        foreach(var preq in prerequisites ){
            pre[preq[0]].Add(preq[1]);
        }

         for(int i=0;i<numCourses;i++){
            if(!Dfs(i)){
                return false;
            }

       }
return true;


    }

   private bool Dfs(int course){
    if(visiting.Contains(course)){
        //we Have a cycle here 
        return false;
    }

    if(pre[course].Count==0) return true;
    
    visiting.Add(course);


    foreach(var preCourse in pre[course] ){
        if(!Dfs(preCourse)){

            return false;       
        }
    }

    visiting.Remove(course);
    pre[course].Clear();

return true;


   }



}

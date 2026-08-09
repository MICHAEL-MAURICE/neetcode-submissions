public class Solution {
   public  int findFirst(int []nums, int target){
    int answer=-1;
    int left=0;
    int right= nums.Length-1;
    while(left<=right){
        int mid= left+(right-left)/2;
        if(target== nums[mid]){
            answer=mid;
            right=mid-1;
        }
        else if(target> nums[mid]){
            left=mid+1;
        }
        else{
            right=mid-1;
        }
    }

    return answer;
   }
   int findlast(int []nums,int target){
int left=0;
int right=nums.Length-1;
int answer=-1;
while(left<=right){
    int mid= left+(right-left)/2;
    if(target == nums[mid]){
        answer=mid;
        left=mid+1;
    }
    else if (target>nums[mid] ){
      left=mid+1;

    }
    else
    right=mid-1;
}


return answer;

   }

    public int[] SearchRange(int[] nums, int target) {
        
return new int []{findFirst(nums,target),findlast(nums,target)};

    }
}
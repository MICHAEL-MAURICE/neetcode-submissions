/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
intervals.Sort((a,b)=>a.start.CompareTo(b.start));

PriorityQueue<int,int>pq=new();
foreach(var interval in intervals){
    if(pq.Count>0 && pq.Peek()<=interval.start){
        pq.Dequeue();
    }
    pq.Enqueue(interval.end,interval.end);
}

 return pq.Count>1?false:true;
    }
}

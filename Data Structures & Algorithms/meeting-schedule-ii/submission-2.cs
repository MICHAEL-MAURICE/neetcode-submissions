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
    public int MinMeetingRooms(List<Interval> intervals) {
intervals.Sort((a,b)=>a.start.CompareTo(b.start));
var MinQueue= new PriorityQueue<int,int>();
foreach(var interval in intervals){
    if(MinQueue.Count>0 && MinQueue.Peek()<=interval.start){
        MinQueue.Dequeue();
    }
    MinQueue.Enqueue(interval.end,interval.end);
}

return MinQueue.Count;
    }
}

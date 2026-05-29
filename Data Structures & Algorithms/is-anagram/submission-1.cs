public class Solution
{
    public bool IsAnagram(string s, string t)
    {
       char[] sArray=s.ToCharArray();
       char [] tArray= t.ToCharArray();

       Array.Sort(sArray);
       Array.Sort(tArray);
       return new string(sArray)==new String(tArray);
       
    }
}

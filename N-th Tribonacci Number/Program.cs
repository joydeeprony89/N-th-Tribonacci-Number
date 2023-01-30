// See https://aka.ms/new-console-template for more information

Solution s = new Solution();
var ans = s.Tribonacci(6);

Console.WriteLine(ans); 

public class Solution
{
  public int Tribonacci(int n)
  {
    if (n == 0) return 0;
    else if (n == 1 || n == 2) return 1;
    int n0 = 0; int n1 = 1; int n2 = 1;
    for (int i = 3; i <= n; i++)
    {
      int sum = n0 + n1 + n2;
      n0 = n1;
      n1 = n2;
      n2 = sum;
    }
    return n2;
  }
}

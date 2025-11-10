public static class MathUtils
{
public static int Factorial(int n)
{
if (n &lt; 0) throw new ArgumentException(&quot;n must be non-negative&quot;);
return n &lt;= 1 ? 1 : n * Factorial(n - 1);
}
}
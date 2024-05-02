namespace Algorithms.String;

/// <summary>
/// 1431. Kids With the Greatest Number of Candies
/// </summary>
public class Task3
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var max = candies.Max();
        var list = new List<bool>(candies.Length);
        
        foreach (var candy in candies)
        {
            list.Add(candy + extraCandies >= max);
        }

        return list;
    }
}
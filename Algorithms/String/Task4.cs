namespace Algorithms.String;

/// <summary>
/// 605. Can Place Flowers
/// </summary>
public class Task4
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0)
        {
            return true;
        }

        if (flowerbed.Length == 1 && flowerbed[0] == 0)
        {
            return true;
        }

        if (flowerbed[0] == 0 && flowerbed[1] == 0)
        {
            flowerbed[0] = 1;
            n--;
        }

        for (var i = 1; i < flowerbed.Length - 1; i++)
        {
            if (n == 0)
            {
                return true;
            }

            if (flowerbed[i] == 0 &&
                flowerbed[i - 1] == 0 &&
                flowerbed[i + 1] == 0)
            {
                flowerbed[i] = 1;
                n--;
            }
        }

        if (flowerbed[^1] == 0 && flowerbed[^2] == 0)
        {
            n--;
        }

        return n == 0;
    }
}
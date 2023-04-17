internal class Flowers
{
    internal static bool CanPlace(int[] flowerbed, int n)
    {
        // if there is no flowers to add
        if (n == 0)
            return true;

        for (int i = 0; i < flowerbed.Length; i++)
        {

            if (flowerbed[i] == 0) // if the current place is empty 
                if (i == 0 || flowerbed[i - 1] == 0) // and the prev. index is empty or it is the first place is empty
                    if (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0) // and if the next place is empty or the last place is empty
                    {
                        // fill the flace of flower
                        flowerbed[i] = 1;
                        n--;
                        // stop if the flowers are over
                        if (n == 0)
                            break;
                    }

        }
        // return true if all flowes out, or false
        return (n == 0);
    }
}
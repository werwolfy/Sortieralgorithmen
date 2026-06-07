using ItemsToSort;

namespace BubbleSort;

public class BubbleSort : ISort
{
    public void Sort(List<int> list)
    {
        bool swaped;
        do
        {
            swaped = false;
            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    int swapper = list[i];
                    list[i] = list[i + 1];
                    list[i + 1] = swapper;
                    swaped = true;
                }
            }
        } while (swaped);
    }
}
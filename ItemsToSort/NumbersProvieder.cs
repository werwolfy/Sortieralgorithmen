namespace ItemsToSort;

public class NumbersProvieder
{
    public List<int> CreateList(int amount)
    {
        Random rnd = new Random();
        List<int> returnList = new List<int>();
        for (int i = 0; i < amount; i++)
        {
            returnList.Add(rnd.Next(-100, 1001));
        }
        return returnList;
    }
}
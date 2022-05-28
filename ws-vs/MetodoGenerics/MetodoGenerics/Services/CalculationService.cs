namespace MetodoGenerics.Services;

public class CalculationService
{
    public X Max<X>(List<X> list) where X : IComparable
    {
        if (list.Count == 0)
        {
            throw new ArgumentException("The list can not be empty");
        }
        
        X max = list[0];
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i].CompareTo(max) > 0)
            {
                max = list[i];
            }
        }

        return max;
    }
}
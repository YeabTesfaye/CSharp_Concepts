

namespace IComparableIComparerInterface;

public class SortedDisplay : IComparer<Display>
{
    public int Compare(Display? x, Display? y)
    {
        Display? firstDisplay = x as Display;
        Display? secondDisplay = y as Display;
        return firstDisplay.PPI.CompareTo(secondDisplay?.PPI);
    }
}
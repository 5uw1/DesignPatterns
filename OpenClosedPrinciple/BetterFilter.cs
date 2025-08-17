namespace OpenClosedPrinciple;

public class BetterFilter : IFilter<Product>
{
    public static IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        foreach (var item in items)
        {
            if (spec.IsSatisfied(item))
                yield return item;
        }
    }
}
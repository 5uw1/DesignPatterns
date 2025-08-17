namespace OpenClosedPrinciple;

public interface IFilter<T>
{
    static abstract IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
}
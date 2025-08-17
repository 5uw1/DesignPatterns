namespace OpenClosedPrinciple;

public class SizeSpecification : ISpecification<Product>
{
    private Size _size;

    public SizeSpecification(Size size)
    {
        this._size = size;
    }
    
    public bool IsSatisfied(Product product)
    {
        return product.Size == _size;  
    }
}
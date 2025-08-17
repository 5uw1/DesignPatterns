namespace OpenClosedPrinciple;

public class ColorSpecification : ISpecification<Product>
{
    private Color _color;
    
    public ColorSpecification(Color color)
    {
        this._color = color;
    }
    
    public bool IsSatisfied(Product product)
    {
        return product.Color == _color;   
    }
}
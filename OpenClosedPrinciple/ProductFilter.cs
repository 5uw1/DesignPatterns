namespace OpenClosedPrinciple;

public static class ProductFilter
{
    public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
    {
        foreach (var product in products)
        {
            if (product.Size == size)
                yield return product;
        }
    }
    
    public static IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
    {
        foreach (var product in products)
        {
            if (product.Color == color)
                yield return product;
        }
    }

    public static IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
    {
        foreach (var product in products)
        {
            if (product.Size == size && product.Color == color)
                yield return product;
        }
    }
}
// See https://aka.ms/new-console-template for more information

using OpenClosedPrinciple;

var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Blue, Size.Large);

Product[] products = [apple, tree, house];
Console.WriteLine("Green products (old):");
foreach (var product in ProductFilter.FilterByColor(products, Color.Green))
{
    Console.WriteLine($" - {product.Name} is green");
}

Console.WriteLine("Green products (new):");
foreach (var product in BetterFilter.Filter(products, new ColorSpecification(Color.Green)))
{
    Console.WriteLine($" - {product.Name} is green");
}

Console.WriteLine("Blue products (new):");
foreach (var blueProduct in BetterFilter.Filter(products, new ColorSpecification(Color.Blue)))
{
    Console.WriteLine($" - {blueProduct.Name} is blue");
}

Console.WriteLine("Large blue items");
foreach (var product in BetterFilter.Filter(
     products, new AndSpecification<Product>(
         new ColorSpecification(Color.Blue), 
         new SizeSpecification(Size.Large)
     ))) {
    Console.WriteLine($" - {product.Name} is big and blue");
}
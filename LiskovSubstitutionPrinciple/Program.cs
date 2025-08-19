using LiskovSubstitutionPrinciple;

Rectangle rc = new Rectangle(2,3);
Console.WriteLine($"{rc} has area {Area(rc)}");

Rectangle sq = new Square();
sq.Width = 4;
Console.WriteLine($"{sq} has area {Area(sq)}");

static int Area(Rectangle r) => r.Width * r.Height;
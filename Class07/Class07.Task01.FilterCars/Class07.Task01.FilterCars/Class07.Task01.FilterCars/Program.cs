
using Class07.Task01.FilterCars;
using System.Linq;

Console.WriteLine("Cars EU: ");
List<Car> carEu = CarsData.Cars.Where
    (x => x.Origin == "Europe")
    .OrderBy(x => x.Model)
    .ToList();
foreach (Car car in carEu)
{
    Console.WriteLine(car);
}

Console.WriteLine($"==================================================================================================================");

Console.WriteLine("\nCars US:");
List<Car> carUS = CarsData.Cars.Where
    (x => x.Origin == "US")
    .OrderBy(x => x.Model)
    .ToList();
foreach (Car car in carUS)
{
    Console.WriteLine(car);
}
Console.WriteLine($"\nEu Cars: {carEu.Count} US Cars: {carUS.Count}\n\n");
Console.WriteLine($"==================================================================================================================");

Console.WriteLine("\nCylinders Plus 6: ");
List<Car> cylindersPlus6 = CarsData.Cars.Where
    (x => x.Cylinders >= 7 || x.Cylinders == 4 && x.HorsePower >= 110.0)
    .OrderBy(x => x.Cylinders)
    .ToList();
foreach (Car car in cylindersPlus6)
{
    Console.WriteLine(car);
}
Console.WriteLine($"==================================================================================================================");

Console.WriteLine("\nCylinders = 4 - Horsepower + 110.0: ");
List<Car> cylinders4 = CarsData.Cars.Where
    (x => x.Cylinders == 4 && x.HorsePower >= 110.0)
    .OrderBy(x => x.Model)
    .ToList();
foreach (Car car in cylinders4)
{
    Console.WriteLine(car);
}
Console.WriteLine($"==================================================================================================================");

Console.WriteLine("\nCylinders = 4 - Horsepower + 200.0: ");
List<Car> HP200 = CarsData.Cars.Where
    (x => x.HorsePower >= 200.0)
    .ToList();
foreach (Car car in HP200)
{
    Console.WriteLine(car);
}

//List<Car> HP200Min = CarsData.Cars.Min
//    (x => x.MilesPerGalon).ToList();

//List<Car> HP200Min = CarsData.Cars.Max
//    (x => x.MilesPerGalon).ToList();

//List<Car> averageMiles = CarsData.Cars.Sum
//    (x => x.MilesPerGalon == items / sum).ToList();















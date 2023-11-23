using Wolt.Service.Services.Implementations;

ProductService productService = new();


Console.WriteLine("1.Create");
Console.WriteLine("2.getAll");
Console.WriteLine("3.Delete");
Console.WriteLine("4.GetbyId");
Console.WriteLine("5.GetAllFilter");
Console.WriteLine("6.Update");
Console.WriteLine("0.Close");

Console.WriteLine("0.Close");
string request = Console.ReadLine();

while (request != "0")
{
    switch (request)
    {
        case "1":
            productService.Create();
            break;
        case "2":
            productService.GetAll();
            break;
        case "3":
            productService.Delete();
            break;
        case "4":
            productService.GetbyId();
            break;
            case "5":
                productService.GetAllFilter();
            break;
        case "6":
            productService.Update();
            break;
        default:
            Console.WriteLine("Add valid option");
            break;
    }

    Console.WriteLine("1.Create");
    Console.WriteLine("2.getAll");
    Console.WriteLine("3.Delete");
    Console.WriteLine("4.GetbyId");
    Console.WriteLine("5.GetAllFilter");
    Console.WriteLine("6.Update");
    Console.WriteLine("0.Close");
    

    request = Console.ReadLine();
}

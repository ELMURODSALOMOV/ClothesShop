

using ClothesShop.Models;
using ClothesShop.Service;

IClothesService clothesService = new ClothesService();
bool isContinue = true;
do
{
    Console.WriteLine("1. Get clothes");
    Console.WriteLine("2. Get all clothes");
    Console.WriteLine("3. Add clothes");
    Console.WriteLine("4. Add range clothes");
    Console.WriteLine("5. Update one clothes");
    Console.WriteLine("6. Delete one clothes");
    Console.WriteLine("7. Purchase product");
    Console.WriteLine("8. Sold information product");
    Console.Write("Enter command ");
    string command = Console.ReadLine();
    if(command.Contains("1") is true)
    {
        Console.Write("Enter id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        clothesService.ReadClothes(id);
    }
    if(command.Contains("2") is true)
    {
        clothesService.ReadAllClothes();
    }
    if(command.Contains("3") is true)
    {
        Clothes clothes1 = new Clothes();
        Console.Write("Enter the id: ");
        clothes1.Id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the model: ");
        clothes1.Model = Console.ReadLine();
        Console.Write("Enter the size: ");
        clothes1.Size = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the cost: ");
        clothes1.Cost = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the color: ");
        clothes1.Color = Console.ReadLine();
        Console.Write("Enter the discraption:");
        clothes1.Discraption = Console.ReadLine();
        Console.Write("Enter the amount: ");
        clothes1.Amount = Convert.ToInt32(Console.ReadLine());
        clothesService.InsertClothes(clothes1);
    }
    if(command.Contains("4") is true)
    {
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        List<Clothes> newClothes = new List<Clothes>();
        for(int itiration = 1; itiration <= number; itiration++)
        {
            Clothes clothes = new Clothes();
            Console.Write("Enter the id: ");
            clothes.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the model: ");
            clothes.Model = Console.ReadLine();
            Console.Write("Enter the size: ");
            clothes.Size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the cost: ");
            clothes.Cost = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the color: ");
            clothes.Color = Console.ReadLine();
            Console.Write("Enter the discraption: ");
            clothes.Discraption = Console.ReadLine();
            Console.Write("Enter the amount; ");
            clothes.Amount = Convert.ToInt32(Console.ReadLine());
            newClothes.Add(clothes);
        }
        clothesService.InsertRangeClothes(newClothes);
    }
    if (command.Contains("5") is true)
    {
        Clothes clothes = new Clothes();
        Console.Write("Enter the id: ");
        clothes.Id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the model: ");
        clothes.Model = Console.ReadLine();
        Console.Write("Enter the size: ");
        clothes.Size = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the cost: ");
        clothes.Cost = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the color: ");
        clothes.Color = Console.ReadLine();
        Console.Write("Enter the discraption: ");
        clothes.Discraption = Console.ReadLine();
        Console.Write("Enter the amount: ");
        clothes.Amount = Convert.ToInt32(Console.ReadLine());
        clothesService.Update(1, clothes);
    }
    if (command.Contains("6") is true)
    {
        Console.Write("Enter the id to delete ");
        int id = Convert.ToInt32(Console.ReadLine());
        clothesService.Delete(id);
    }
    if(command.Contains("7") is true)
    {
        Console.Write("Enter product model: ");
        string model = Console.ReadLine();
        clothesService.Purchase(model);
    }
    if (command.Contains("9") is true)
    {
        clothesService.SoldInformation();
    }
    Console.Write("Is Continue ");
    string isCommand = Console.ReadLine();
    if(isCommand.ToLower().Contains("no") is true)
    {
        isContinue = false;
    }
}while(isContinue is true);


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
        clothesService.InsertClothes(InputClothesInformation());
    }
    if(command.Contains("4") is true)
    {
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        List<Clothes> newClothes = new List<Clothes>();
        for(int itiration = 1; itiration <= number; itiration++)
        {
            newClothes.Add(InputClothesInformation());
        }
        clothesService.InsertRangeClothes(newClothes);
    }
    if (command.Contains("5") is true)
    {
        clothesService.Update(1, InputClothesInformation());
    }
    if (command.Contains("6") is true)
    {
        Console.Write("Enter the id to delete ");
        int id = Convert.ToInt32(Console.ReadLine());
        clothesService.Delete(id);
    }
    if(command.Contains("7") is true)
    {
        Console.Write("Enter product type: ");
        string type = Console.ReadLine();
        clothesService.Purchase(type);
    }
    if (command.Contains("8") is true)
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

static Clothes InputClothesInformation()
{
    Clothes clothes = new Clothes();
    Console.Write("Enter the id: ");
    clothes.Id = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the model: ");
    clothes.Model = Console.ReadLine();
    Console.Write("Enter the type: ");
    clothes.Type = Console.ReadLine();
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
    return clothes;
}
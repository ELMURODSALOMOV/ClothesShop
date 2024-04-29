
using ClothesShop.Broker.Storeage;
using ClothesShop.Models;

ListStoreageBroker listStoreageBroker = new ListStoreageBroker();
foreach (var storeage in listStoreageBroker.GetAllClothes())
{
    Console.WriteLine("Id " + storeage.Id);
    Console.WriteLine("Model " + storeage.Model);
    Console.WriteLine("Type " + storeage.Type);
    Console.WriteLine("Amount " + storeage.Amount);
    Console.WriteLine("Discreption " + storeage.Discraption);
    Console.WriteLine("Cost " + storeage.Cost);
}


Console.WriteLine("==============");
Console.Write("Enter type: ");
string clothesType = Console.ReadLine();
listStoreageBroker.PurchaseClothes(clothesType);
Console.WriteLine("==============");

foreach (var storeage in listStoreageBroker.SoldInformationClothes())
{
    Console.WriteLine("Id " + storeage.Id);
    Console.WriteLine("Model " + storeage.Model);
    Console.WriteLine("Amount " + storeage.Amount);
    Console.WriteLine("Balance " + storeage.Balance);
}

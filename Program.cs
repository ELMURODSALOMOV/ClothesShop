
using ClothesShop.Broker.Storeage;
using ClothesShop.Models;

ListStoreageBroker listStoreageBroker = new ListStoreageBroker();
Clothes clothes =  listStoreageBroker.UpdateClothes(1, new Clothes() { Id = 3 , Model = "dsdsds", Type = ClothesType.Jeans, Cost = 12232, Size = 55, Color = "Red", Discraption = "djfkdfiefoiejfdk", Amount = 55});
Console.WriteLine(clothes.Id);
Console.WriteLine(clothes.Model);
Console.WriteLine(clothes.Type);
Console.WriteLine(clothes.Cost);
Console.WriteLine(clothes.Size);
Console.WriteLine(clothes.Color);
Console.WriteLine(clothes.Discraption);
Console.WriteLine(clothes.Amount);
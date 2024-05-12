//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using ClothesShop.Models;

namespace ClothesShop.Broker.Storeage
{
    internal interface IStoreageBroker
    {
        List<Clothes> GetAllClothes();
        Clothes GetClothes(int id);
        bool DeleteClothes(int id);
        Clothes UpdateClothes(int id, Clothes clothes);
        Clothes AddClothes(Clothes clothes);
        List<Clothes> AddRangeClothes(List<Clothes> clothes);
        void PurchaseClothes(string productType);
        List<SoldProducts> SoldInformationClothes();

    }
}

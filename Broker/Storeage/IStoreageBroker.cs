using ClothesShop.Models;

namespace ClothesShop.Broker.Storeage
{
    internal interface IStoreageBroker
    {
        List<Clothes> GetAllClothes();
        Clothes GetClothes(int id);
        bool DeleteClothes(int id);
        Clothes UpdateClothes(int id, Clothes clothes);
        void AddClothes(Clothes clothes);
        void AddRangeClothes(List<Clothes> clothes);
        void PurchaseClothes(string productType);
        List<SoldProducts> SoldInformationClothes();

    }
}

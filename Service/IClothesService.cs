using ClothesShop.Models;

namespace ClothesShop.Service
{
    internal interface IClothesService
    {
        List<Clothes> ReadAllClothes();
        Clothes ReadClothes(int id);
        bool Delete(int id);
        Clothes Update(int id, Clothes clothes);
        void InsertClothes(Clothes clothes);
        void InsertRangeClothes(List<Clothes> clothes);
        void Purchase(string model);
        List<SoldProducts> SoldInformation();
    }
}

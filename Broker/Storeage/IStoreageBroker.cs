using ClothesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        void PurchaseClothes(string model);
        List<Clothes> SoldInformationClothes();

    }
}

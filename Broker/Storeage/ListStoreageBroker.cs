using ClothesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Broker.Storeage
{
    internal class ListStoreageBroker : IStoreageBroker
    {
        List<Clothes> demoClothes = new List<Clothes>();
        private List<Clothes> clothes = new List<Clothes>();
        public ListStoreageBroker()
        {
            clothes[0] = new Clothes()
            {
                Id = 1,
                Model = "GUCCI",
                Type = ClothesType.PoloShirt,
                Cost = 100000,
                Size = 58,
                Color = "Red",
                Discraption = "Cotton, XL",
                Amount = 20
            };
            clothes[1] = new Clothes()
            {
                Id = 2,
                Model = "LACOSTI",
                Type = ClothesType.Jeans,
                Cost = 120000,
                Size = 55,
                Color = "Blue",
                Discraption = "Cotton 50%, synthetics 50%, XXl",
                Amount = 16
            };
            clothes[2] = new Clothes()
            {
                Id = 3,
                Model = "Zara",
                Type = ClothesType.Shoes,
                Cost = 200000,
                Size = 60,
                Color = "Black",
                Discraption = "Skin 100%, 60",
                Amount = 23
            };
        }

        public void AddClothes(Clothes clothes) => this.clothes.Add(clothes);

        public void AddRangeClothes(List<Clothes> clothes) => this.clothes.AddRange(clothes);

        public bool DeleteClothes(int id)
        {
            foreach(Clothes clothesIteim in this.clothes)
            {
                if (clothesIteim.Id == id)
                {
                    this.clothes.Remove(clothesIteim);
                    return true;
                }
            }
            return false;
        }

        public List<Clothes> GetAllClothes() => this.clothes;

        public Clothes GetClothes(int id)
        {
            foreach(Clothes clothesIteim in this.clothes)
            {
                if(clothesIteim.Id == id)
                {
                    return clothesIteim;
                }
            }
            return new Clothes();
        }

        public void PurchaseClothes(string model)
        {
            throw new NotImplementedException();
        }

        public List<Clothes> SoldInformationClothes()
        {
            throw new NotImplementedException();
        }

        public Clothes UpdateClothes(int id, Clothes clothes)
        {
            throw new NotImplementedException();
        }
    }
}

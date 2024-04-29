using ClothesShop.Broker.Logging;
using ClothesShop.Broker.Storeage;
using ClothesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Service
{
    internal class ClothesService : IClothesService
    {
        private readonly ILoggingBroker loggingBroker;
        private readonly IStoreageBroker listStoreageBroker;
        public ClothesService()
        {
            this.listStoreageBroker = new ListStoreageBroker();
            this.loggingBroker = new LoggingBroker();
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertClothes(Clothes clothes)
        {
            throw new NotImplementedException();
        }

        public void InsertRangeClothes(List<Clothes> clothes)
        {
            throw new NotImplementedException();
        }

        public void Purchase(string model)
        {
            throw new NotImplementedException();
        }

        public List<Clothes> ReadAllClothes()
        {
            var clothes = this.listStoreageBroker.GetAllClothes();
            foreach (var clothesItem in clothes )
            {
                if (clothesItem is not null)
                {
                    this.loggingBroker.LogInformation(
                        $"Id  {clothesItem.Id}\n" +
                        $"Model {clothesItem.Model}\n" +
                        $"Type {clothesItem.Type} \n" +
                        $"Cost {clothesItem.Cost} \n" +
                        $"Amount {clothesItem.Amount} \n" +
                        $"Discreption {clothesItem.Discraption} \n");
                }
            }
            return clothes;
        }

        public Clothes ReadClothes(int id)
        {
            throw new NotImplementedException();
        }

        public List<SoldProducts> SoldInformation()
        {
            throw new NotImplementedException();
        }

        public Clothes Update(int id, Clothes clothes)
        {
            throw new NotImplementedException();
        }
    }
}

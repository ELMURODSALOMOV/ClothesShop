using ClothesShop.Broker.Logging;
using ClothesShop.Broker.Storeage;
using ClothesShop.Models;

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
            return id is 0
                ? InvalidDeleteId()
                : ValidationAndDelete(id);
        }
        public Clothes InsertClothes(Clothes clothes)
        {
            return clothes is null
                    ? InvalidInsertClothes()
                    : ValidationAndInsertClothes(clothes);
        }

        public List<Clothes> InsertRangeClothes(List<Clothes> clothes)
        {
            return clothes is null
                ? InvalidInsertRangeClothes()
                : ValidationAndInsertRangeClothes(clothes);
        }

        public void Purchase(string model)
        {
            if (model is null)
            {
                InvalidPurchase();
            }
            else
            {
                ValidationAndPurchase(model);
            }

        }

        public List<Clothes> ReadAllClothes()
        {
            var clothes = this.listStoreageBroker.GetAllClothes();
            foreach (var clothesItem in clothes )
            {
                if (clothesItem is not null)
                {
                    this.loggingBroker.LogInfo(
                        $"Id  {clothesItem.Id}\n" +
                        $"Model {clothesItem.Model}\n" +
                        $"Type {clothesItem.Type} \n" +
                        $"Cost {clothesItem.Cost} \n" +
                        $"Color {clothesItem.Color} \n" +
                        $"Amount {clothesItem.Amount} \n" +
                        $"Discreption {clothesItem.Discraption} \n");
                }
            }
            return clothes;
        }

        public Clothes ReadClothes(int id)
        {
            return id is 0
                ? InvalidReadClothesId()
                : ValidationAndReadClothes(id);
        }

        public List<SoldProducts> SoldInformation()
        {
            var clothes = this.listStoreageBroker.SoldInformationClothes();
            foreach(var clothesItem in clothes )
            {
                if(clothesItem is not null)
                {
                    this.loggingBroker.LogInfo(
                        $"Id {clothesItem.Id}\n" +
                        $"Model {clothesItem.Model}\n" +
                        $"Amount {clothesItem.Amount}\n" +
                        $"Balance {clothesItem.Balance}");
                }
            }
            return clothes;
        }

        public Clothes Update(int id, Clothes clothes)
        {
            return id is 0
                ? InvalidUpdateClothes()
                : ValidationAndUpdateClothes(id, clothes);
        }

        private bool ValidationAndDelete(int id)
        {
            bool isDelete = this.listStoreageBroker.DeleteClothes(id);
            if (isDelete is true)
            {
                this.loggingBroker.LogInformation("The information in the id has been deleted.");
                return isDelete;
            }
            else
            {
                this.loggingBroker.LogError("Id is Not Found.");
                return isDelete;
            }
        }

        private bool InvalidDeleteId()
        {
            this.loggingBroker.LogError("The id information is invalid.");
            return false;
        }

        private Clothes InvalidInsertClothes()
        {
            this.loggingBroker.LogError("Clothes info is null.");
            return new Clothes();
        }

        private Clothes ValidationAndInsertClothes(Clothes clothes)
        {
            if (clothes.Id is 0
                || String.IsNullOrWhiteSpace(clothes.Model)
                || String.IsNullOrWhiteSpace(clothes.Type.ToString()))
            {
                this.loggingBroker.LogError("Invalid clothes information.");
                return new Clothes();
            }
            else
            {
                var clothesInformation = this.listStoreageBroker.AddClothes(clothes);
                if (clothesInformation is null)
                {
                    this.loggingBroker.LogError("Not added clothes info");
                    return new Clothes();
                }
                else
                {
                    this.loggingBroker.LogInformation("Sucssesfull.");
                }
                return clothes;
            }

        }

        private List<Clothes> ValidationAndInsertRangeClothes(List<Clothes> clothes)
        {
            List<Clothes> clothesInfo = this.listStoreageBroker.AddRangeClothes(clothes);
            if (clothesInfo is null)
            {
                this.loggingBroker.LogError("No data available.");
                return new List<Clothes>();
            }
            else
            {
                
                this.loggingBroker.LogInformation("The clothes were washed successfully.");
            }
            return clothesInfo;
        }

        private List<Clothes> InvalidInsertRangeClothes()
        {
            this.loggingBroker.LogError("Clothing information was not provided.");
            return new List<Clothes>();
        }

        private Clothes ValidationAndReadClothes(int id)
        {
            var clothesInformation = this.listStoreageBroker.GetClothes(id);
            if (clothesInformation is null)
            {
                this.loggingBroker.LogError("Clothes information is not found.");
                return new Clothes();
            }
            else
            {
                this.loggingBroker.LogInfo(
                        $"Id  {clothesInformation.Id}\n" +
                        $"Model {clothesInformation.Model}\n" +
                        $"Type {clothesInformation.Type} \n" +
                        $"Cost {clothesInformation.Cost} \n" +
                        $"Color {clothesInformation.Color} \n" +
                        $"Amount {clothesInformation.Discraption} \n" +
                        $"Discreption {clothesInformation.Amount} \n");
                this.loggingBroker.LogInformation("Successfully.");
            }
            return clothesInformation;
        }

        private Clothes InvalidReadClothesId()
        {
            this.loggingBroker.LogError("Id is invalid.");
            return new Clothes();
        }

        private void ValidationAndPurchase(string model)
        {
            if (String.IsNullOrEmpty(model))
            {
                this.loggingBroker.LogError("Invalid clothes model.");
            }
            else
            {
                this.loggingBroker.LogInformation("The product was sold successfully.");
                this.listStoreageBroker.PurchaseClothes(model);
            }
        }

        private void InvalidPurchase()
        {
            this.loggingBroker.LogError("The sale did not go through.");
        }

        private Clothes ValidationAndUpdateClothes(int id, Clothes clothes)
        {
            if (clothes.Id is 0
                || String.IsNullOrWhiteSpace(clothes.Model)
                || String.IsNullOrWhiteSpace(clothes.Type.ToString()))
            {
                this.loggingBroker.LogError("Clothes information is incomplete.");
                return clothes;
            }
            else
            {
                var isUpdate = this.listStoreageBroker.UpdateClothes(id, clothes);
                if (isUpdate is not null)
                {
                    this.loggingBroker.LogInformation("Update.");
                    return isUpdate;
                }
                else
                {
                    this.loggingBroker.LogError("No Update.");
                    return clothes;
                }
            }
        }

        private Clothes InvalidUpdateClothes()
        {
            this.loggingBroker.LogError("Clothes information is incomplete.");
            return new Clothes();
        }
    }
}

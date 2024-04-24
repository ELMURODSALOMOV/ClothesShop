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
        List<Clothes> clothes = new List<Clothes>();
        public ListStoreageBroker()
        {
            clothes[0] = new Clothes();
            {
                
            }
        }
    }
}

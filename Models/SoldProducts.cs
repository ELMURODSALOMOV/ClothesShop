using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Models
{
    internal class SoldProducts
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public decimal Balance { get; set; }
    }
}

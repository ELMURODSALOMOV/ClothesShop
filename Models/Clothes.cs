using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Models
{
    internal class Clothes
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int Size {get; set; }
        public decimal Cost { get; set; }
        public string Color { get; set; }
        public string Discraption { get; set; }
        public int Amount { get; set; }
    }
}

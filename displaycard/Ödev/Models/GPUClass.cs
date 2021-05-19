using System;
namespace Ödev.Models
{
    public class GPUClass
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public GPUClass(int id, String name,double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAppOnLesson
{
    class Drug
    {
        private static int _id = 0;
        public readonly int Id;
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public TypeDrug TypeName { get; set; }

        public Drug()
        {
            Id = _id;
            _id++;
        }
        public Drug(string name, TypeDrug type, double price, int count) : this()
        {
            Name = name;
            TypeName = type;
            Price = price;
            Count = count;
        }
        public override string ToString()
        {
            return $"{Id} - {TypeName} - {Name} Price:{Price} Count:{Count}";
        }
    }
}

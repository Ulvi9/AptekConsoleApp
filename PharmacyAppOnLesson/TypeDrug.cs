using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAppOnLesson
{
    class TypeDrug
    {
        private static int _id = 0;
        public readonly int Id;
        public string Name { get; set; }

        public TypeDrug()
        {
            Id = _id;
            _id++;
        }
        public TypeDrug(string name) : this()
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

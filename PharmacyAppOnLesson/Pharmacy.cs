using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAppOnLesson
{
    partial class Pharmacy
    {
        private static int _id = 0;
        public readonly int Id;
        private Drug[] drugs = new Drug[0];
        public string Name { get; set; }

        public Pharmacy()
        {
            Id = _id;
            _id++;
        }
        public Pharmacy(string name) : this()
        {
            Name = name;
        }

    }
}

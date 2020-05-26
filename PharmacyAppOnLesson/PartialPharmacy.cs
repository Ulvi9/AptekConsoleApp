using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAppOnLesson
{
    partial class Pharmacy
    {
        public override string ToString()
        {
            return Name;
        }
        public void AddDrug(Drug newDrug)
        {
            Array.Resize(ref drugs, drugs.Length + 1);
            drugs[drugs.Length - 1] = newDrug;
            //Console.WriteLine($"{newDrug} - elave olundu!!!");
        }
        public void DrugList()
        {
            Console.WriteLine($"{Name} Aptekinde olan dermanlar:");
            foreach (Drug item in drugs)
            {
                Console.WriteLine(item);
            }
        }
        public void SaleDrug(int id, int count, double price)
        {
            foreach (Drug item in drugs)
            {
                if (item.Id == id)
                {
                    if (item.Count >= count)
                    {
                        double totalPrice = count * item.Price;

                        if (totalPrice <= price)
                        {
                            Console.WriteLine($"{item.Name} dermanindan {count} eded satildi.Pulun qaligi {price - totalPrice} manat");
                            return;
                        }
                        Console.WriteLine($"Zehmet olmasa {totalPrice - price} manat elave odenish edin");
                        return;
                    }
                    Console.WriteLine($"{item.Count} eded derman qalib, {count - item.Count} eded derman chatmir");
                    return;
                }

            }
            Console.WriteLine($" {id} nomreli derman yoxdur");

        }

    }
}

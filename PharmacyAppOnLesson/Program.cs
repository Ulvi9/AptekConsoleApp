using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAppOnLesson
{
    class Program
    {
        static void Main(string[] args)
        {

            //HomeTask DeleteDrug Methodu yazmaliyiq.Id qebul edecek int tipinden.
            //Eger bu Id-li Drug varsa onu silecek, eger yoxdursa ekrana yazilacaq ki, 
            //bu Id -li derman yoxdur onu sile bilmersiniz.


            TypeDrug type1 = new TypeDrug("HeadAche");
            TypeDrug type2 = new TypeDrug("HeartAche");
            Drug drug1 = new Drug("Analgin", type1, 0.80, 100);
            Drug drug2 = new Drug("Valerian", type2, 0.20, 1000);
            //Console.WriteLine(drug1);
            //Console.WriteLine(drug2);

            Pharmacy zeferan = new Pharmacy("Zeferan");

            zeferan.AddDrug(drug1);
            zeferan.AddDrug(drug2);

            //zeferan.DrugList();
            zeferan.SaleDrug(0, 105, 100);

        }
    }
}

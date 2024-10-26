using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            string CustomerName()
            {
                string name = "Hasan";
                string Surname = "Çetin";

                return name + " " + Surname;
            }

            string CountryCard(string countryName , string capital , string flagColor) { 

                string cardInfo = "Ülke : "+ countryName + "Başkent : " + capital + "Bayrak Rengi : "+flagColor;

                return cardInfo;


            }


           Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı"));

            Console.Read();

            #endregion
        }
    }
}

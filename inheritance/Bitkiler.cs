using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
   public class Bitkiler : Canlılar
    {

        public void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar");
        }

    }

    public class TohumluBitkiler : Bitkiler
    {
        public void TohumlaCogalır()
        {
            Console.WriteLine(" Tohumlu Bitkiler Tohumla cagalır");
        } 

    }

    public class TohumsuzBitkiler : Bitkiler
    {
        public void SporlaCogalır()
        {
            Console.WriteLine("Tohumsuz Bitkiler Sporla cagalır");
        }

    }
}

using APIJeuMorpionCsharp.Classes;
using APIJeuMorpionCsharp.Globales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJeuMorpion
{
    class Program
    {
        static void Main(string[] args)
        {
            PartieMorpion unePartie = new PartieMorpion();
            unePartie.DemarrerPartie();
        } 
    }
}

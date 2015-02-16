using APIJeuMorpionCsharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuMorpionWinForms
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PartieMorpion unePartie = new PartieMorpion();
            unePartie.DemarrerPartie();
        }
    }
}

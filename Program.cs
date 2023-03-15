using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLVP_Aflevering1_v2
{
    internal static class Program
    {

        // KAN IKKE TILGÅS I FORMS ALLIGEVEL??
        // Skal erklæres statisk. Da den er en del af program-klassen må den gerne tilgås af alle versioner af denne, da der kun vil være en.
        // public static string[] nameArray = new string[10];

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

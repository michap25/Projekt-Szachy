using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace szachy
{
    static class Program
    {
        // Klasa główna programu

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Szachy());
        }
    }
}

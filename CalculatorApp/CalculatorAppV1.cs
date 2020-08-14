using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Jarett Wiemers
 * Created: 12/3/2019
 * This program is a simple calculator that inputs values, performs equations and outputs results.
 */

namespace CalculatorApp
{
    static class CalculatorAppV1
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculator());
        }
    }
}

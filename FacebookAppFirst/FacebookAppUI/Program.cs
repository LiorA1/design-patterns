using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// $G$ RUL-004 (-20) Wrong zip name format / folder name format


// $G$ THE-001 (-21) your grade on diagrams document - 79. please see comments inside the document. (40% of your grade).

namespace FacebookAppUI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormFacebookApp());
        }
    }
}

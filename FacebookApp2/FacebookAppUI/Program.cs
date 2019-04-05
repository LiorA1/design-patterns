using System;
using System.Windows.Forms;


// $G$ THE-001 (-11) your grade on diagrams document - 89. please see comments inside the document.

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
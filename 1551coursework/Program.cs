using System;
using System.Windows.Forms;

namespace _1551coursework
{
    public class Program // Create a class to hold the Main method
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] // Indicates that the COM threading model for the application is single-threaded apartment (STA).
        static void Main()
        {
            // Enable visual styles for the application to provide a modern look and feel.
            Application.EnableVisualStyles();

            // Set the application-wide default for text rendering to be compatible with the application's visual styles.
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the application by creating and showing the Login_form instance.
            Application.Run(new Login_form());
        }
    }
}
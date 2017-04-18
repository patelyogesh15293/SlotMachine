using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    static class Program
    {
        // Declare public static form
        public static SplashForm mySplashForm;
        // Declare public static form
        public static SlotMachineForm mySlotMachineForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Initialize splashform
            Program.mySplashForm = new SplashForm();
            // Initialize selection form
            Program.mySlotMachineForm = new SlotMachineForm();
            Application.Run(Program.mySplashForm);
        }
    }
}

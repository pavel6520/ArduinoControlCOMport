using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TerminalCOMCs;

namespace ArduinoTerminal
{
    static class Program
    {
        static public ArduinoControl MainForm;
        static public COM ComPort;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ComPort = new COM();
            MainForm = new ArduinoControl();
            Application.Run(MainForm);
        }
    }
}

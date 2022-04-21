using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace CalcDotNet
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCalc());
        }
    }
}

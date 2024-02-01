using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IELauncher
{
    internal class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        static void Main(string[] args)
        {
            SHDocVw.InternetExplorer IE = new SHDocVw.InternetExplorer();
            object URL;
            ShowWindow((IntPtr)IE.HWND, 3);
            if (args.Length >= 1)
            {
                URL = args[0];
                IE.Navigate2(ref URL);
            }
            else
            {
                //URL = "about:blank"; // home page
                IE.GoHome();
            }

            IE.Visible = true;           
        }
    }
}

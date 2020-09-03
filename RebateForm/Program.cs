using System;
using System.Windows.Forms;

namespace RebateForm
{
    static class Program
    {
     
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RebateForm.Form1());
        }
    }
}

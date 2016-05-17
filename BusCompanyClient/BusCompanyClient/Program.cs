using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusCompanyClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Connection myConnection = new Connection();
            Assigner myAssigner = new Assigner(myConnection);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 myForm = new Form1();
            myForm.FillLists(myAssigner);
            Application.Run(myForm);

        }
    }
}

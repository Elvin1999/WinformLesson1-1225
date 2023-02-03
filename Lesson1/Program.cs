using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    internal static class Program
    {

        static DialogResult GetDialogResult()
        {
            DialogResult result;
            string message = "Window displaying a text message";

            string caption = "C# Language";

            //result=MessageBox.Show(message);
            result=MessageBox.Show(message,caption,MessageBoxButtons.YesNoCancel,MessageBoxIcon.Error);

            return result;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //var result=GetDialogResult();
            //if (result == DialogResult.OK)
            //{
            //    MessageBox.Show("You Clicked OK");
            //}
            //else
            //{
            //    MessageBox.Show("You clicked other");
            //}


            //if (result == DialogResult.Yes)
            //{
            //    MessageBox.Show("You clicked to YES");
            //}
            //else if (result == DialogResult.No)
            //{
            //    MessageBox.Show("You clicked to NO");
            //}
            //else
            //{
            //    MessageBox.Show("You Clicked to OTHER");
            //}



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

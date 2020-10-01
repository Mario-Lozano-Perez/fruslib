using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruslib
{
    public static class MostUsed
    {
        public static void OpenFormInPanel(Form Forma, Panel Panel)
        {
            if (Panel.Controls.Count > 0)
            {
                Panel.Controls.RemoveAt(0);
            }

            Form fh = Forma as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            Panel.Controls.Add(fh);
            Panel.Tag = fh;
            fh.Show();
        }

        public static void WriteFile(string filePath, string textToWrite)
        {
            TextWriter Writter = new StreamWriter(filePath);
            Writter.Write(textToWrite);
            Writter.Close();
        }

        public static string ReadFile(string filePath)
        {
            TextReader Reader = new StreamReader(filePath);
            string Content = Reader.ReadToEnd();
            Reader.Close();
            return Content;
        }

        public static void ExecuteShellUrl(string Location)
        {
            ProcessStartInfo Proceso = new ProcessStartInfo
            {
                FileName = Location,
                UseShellExecute = true
            };
            Process.Start(Proceso);
        }

    }
}

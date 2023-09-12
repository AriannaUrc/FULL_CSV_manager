using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSVmanager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            TopMost = true;
        }
        public void ExecuteCommand(string Command, string Arguments = "", string Path = "", bool ShellExecute = true)
        {
            string temp;
            ProcessStartInfo ProcessInfo = new ProcessStartInfo(Command);

            temp = ProcessInfo.WorkingDirectory;
            //temp = temp + Path;

            if (Path != "")
            {
                ProcessInfo.WorkingDirectory = temp;
            }
            if (Arguments != "")
            {
                ProcessInfo.Arguments = Arguments;
            }
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = ShellExecute;

            //Process Process =
            Process.Start(ProcessInfo);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            ExecuteCommand("FunLauncher.exe", "", "\\Debug\\net6.0-windows");//tries to open only theadditional path
            foreach (Form form in Application.OpenForms)
            {
                form.Close();

            }
            //
            
        }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }
    }
}

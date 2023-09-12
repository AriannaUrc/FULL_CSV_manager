using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CSVmanager
{
    public partial class Form1 : Form
    {
        public int recordLength;
        public string separator;

        public CSVDLL.csvFunctions.dati d;
        public string FileName;
        public string BackUp;

        public Form1()
        {
            InitializeComponent();

            //recordLength = 64;
            recordLength = 64;
            FileName = "Lottery_Numbers.csv";
            BackUp = "BackUp.csv";
            separator = ",";

            CSVDLL.csvFunctions.Format(BackUp, FileName, separator);
            //Format();

            LoadFromFile();

            timer1.Start();
        }

        public void LoadFromFile(bool showw = false)
        {
            String line;
            byte[] br;

            var f = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(f);
            BinaryWriter writer = new BinaryWriter(f);



            string[] words = new string[4];

            listView.Items.Clear();

            while (f.Position < f.Length - 2)
            {

                br = reader.ReadBytes(recordLength);
                //converte in stringa
                line = Encoding.ASCII.GetString(br, 0, br.Length);

                //valore x debug per mostrare che linee legge
                if (showw)
                {
                    MessageBox.Show(line);
                }
                //estraggo dalla stringa i valori e gli inserisco il d
                d = CSVDLL.csvFunctions.FromString(line);

                if (d.cancLogic == true)
                {
                    //aggiunge alla lista i dati di d
                    ListViewItem item = new ListViewItem(new[] { d.draw_date, d.winning_numbers, d.multiplier.ToString() });
                    listView.Items.Add(item);
                }

            }

            writer.Close();
            reader.Close();
            f.Close();

        }

        //windows form functions
        private void OpenButton_Click(object sender, EventArgs e)
        {

            CSVDLL.csvFunctions.ExecuteCommand(FileName);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        private void Modify_button_Click(object sender, EventArgs e)
        {
            //ModificaFile();
            if (CSVDLL.csvFunctions.ModificaFile(modify_draw_date_textbox.Text, modify_target.Text, modify_new_value_textbox.Text, FileName, recordLength, d, separator) == 1)
            {
                MessageBox.Show("valori inseriti non validi");
            }

        }

        private void fields_num_button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(findNumberOfFields().ToString());
            MessageBox.Show(CSVDLL.csvFunctions.findNumberOfFields(FileName, recordLength, d, separator).ToString());
        }

        private void max_field_button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(MaxFieldLenght().ToString());
            MessageBox.Show(CSVDLL.csvFunctions.MaxFieldLenght(FileName, recordLength, d, separator).ToString());
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(add_mega_ball_textbox.Text, out int val) && int.TryParse(add_multiplier_textbox.Text, out int val1))
            {
                CSVDLL.csvFunctions.AddFile(add_draw_date_textbox.Text, add_win_numbers_textbox.Text, int.Parse(add_mega_ball_textbox.Text), int.Parse(add_multiplier_textbox.Text), d, separator, FileName);
            }
            else
            {
                MessageBox.Show("i valori aggiunti non sono accettabili");
            }

        }

        private void find_button_Click(object sender, EventArgs e)
        {
            //FindInFile();
            MessageBox.Show(CSVDLL.csvFunctions.FindLineInFile(find_target.Text, find_value_textbox.Text, FileName, recordLength, d, separator));
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            //DeleteFile();
            if (CSVDLL.csvFunctions.DeleteFile(delete_target.Text, delete_value_textbox.Text, FileName, recordLength, d, separator) == 1)
            {
                MessageBox.Show("valori inseriti non validi");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            var form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            if (form == null)
            {
                Form2 myNewForm = new Form2();
               
                Point pt = ActiveForm.Location;
                pt.X = pt.X + 40;
                pt.Y = pt.Y + 320;

                myNewForm.StartPosition = FormStartPosition.Manual;
                myNewForm.ShowInTaskbar = false;

                myNewForm.Location = pt;

                myNewForm.Show();
            }
            
        }
    }
}
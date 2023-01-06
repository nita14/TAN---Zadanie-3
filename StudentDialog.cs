using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinFormsStudent.Modele;

namespace WinFormsStudent
{
    public partial class StudentDialog : Form
    {

        public Student st { get; set; }

        public StudentDialog()
        {
            InitializeComponent();
        }

        private void StudentDialog_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numerIndeksuDialogLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void anulujButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {

            //walidacja nulli

            if (imieTextBox.Text == null || nazwiskoTextBox.Text == null || numerIndeksuTextBox == null) {
                MessageBox.Show("Wszystkie pola muszą być uzupełnione");
                return;
            }

            if (imieTextBox.Text.Trim().Length < 2 || nazwiskoTextBox.Text.Trim().Length < 2 
                || numerIndeksuTextBox.Text.Trim().Length < 2)
            {
                MessageBox.Show("Pole musi mieć więcej niz dwa znaki");
                return;
            }


            //walidacja foramtu numeru indeksu
            string pattern = @"[sS][0-9]{1,9}";
            Regex rg = new Regex(pattern);
            MatchCollection matchedIndexes = rg.Matches(numerIndeksuTextBox.Text);
            if (matchedIndexes.Count == 0)
            {
                MessageBox.Show("Numer indeksu nusi miec postac S(s)<cyfry> np.s1234");
                return;
            }

            st = new Student {
                Imie = imieTextBox.Text,
                Nazwisko = nazwiskoTextBox.Text,
                IndexNumber = numerIndeksuTextBox.Text
            };


            Close();


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsStudent.Modele;

namespace WinFormsStudent
{
    public partial class OknoGlowneForm : Form
    {

        public List<Student> Studenci { get; set; } = new List<Student>();
        public OknoGlowneForm()
        {
            InitializeComponent();
            var s1 = new Student
            {
                Imie = "Jan",
                Nazwisko = "Kowal",
                IndexNumber = "S1234"
            };

            var s2 = new Student
            {
                Imie = "Darek",
                Nazwisko = "Nowak",
                IndexNumber = "S4321"
            };

            Studenci.Add(s1);
            Studenci.Add(s2);

            studenciGridView.DataSource = Studenci;
        }

        private void studenciGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (studenciGridView.SelectedRows.Count == 0) { return; }

            var st = studenciGridView.SelectedRows[0].DataBoundItem as Student;
            ImieTextBox.Text = st.Imie;
            NazwiskoTextBox.Text = st.Nazwisko;



        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            var dialog = new StudentDialog();
            dialog.ShowDialog();


            if (dialog.st != null) {
                Studenci.Add(dialog.st);
            }

            studenciGridView.DataSource = null;
            studenciGridView.DataSource = Studenci;

        }

        private void usunButton_Click(object sender, EventArgs e)
        {

            if (studenciGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Najpierw wybierz wierz");
                return; }

            var st_current = studenciGridView.SelectedRows[0].DataBoundItem as Student;
            Studenci.Remove(st_current);

            studenciGridView.DataSource = null;
            studenciGridView.DataSource = Studenci;

        }

    }
}

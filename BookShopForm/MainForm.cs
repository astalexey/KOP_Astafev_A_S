using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookShopForm
{
    public partial class MainForm : Form
    {
        Random rnd = new Random();
        public MainForm()
        {
            InitializeComponent();
            AutoFillUserForm();
        }

        public void AutoFillUserForm()
        {
            selectedControl1.FillComboBox("Квадратная");
            selectedControl1.FillComboBox("Треугольная");
            selectedControl1.FillComboBox("Круглая");

            outputControl1.SetOrder(new List<string> { "Form", "Date", "NameBook"});

            AutoFillTree(10);
        }

        public void AutoFillTree(int count)
        {
            while (count != 0)
            {
                string[] names = { "про любовь", "для учебы", "с чертежами", "о программировании", "фантастика" };
                string[] forms = { "Квадратная", "Круглая", "Треугольная" };

                DateTime dateNow = DateTime.Today.AddDays(rnd.Next(0, 10));
                outputControl1.Add(new Book(forms[rnd.Next(0, 3)], dateNow, "Книга "+names[rnd.Next(0, 5)]));
                count--;
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(inputControl1.Value + "\n" + selectedControl1.value);
            
        }
    }
}

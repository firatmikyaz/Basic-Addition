using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3_Odev_Masked
{
    public partial class Form1 : Form
    {
        //constructor
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Istanbul");
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("İzmir");
            comboBox1.Items.Add("Eskişehir");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Parameters

            string name = textBox1.Text;
            string surname = textBox2.Text;
            string identificationNumber = maskedTextBox1.Text;
            string phoneNumber = maskedTextBox2.Text;
            string birthDate = dateTimePicker1.Text;
            string city = textBox3.Text; 
            #endregion

            listBox1.Items.Add(name + " " + surname + " " + identificationNumber + " " + phoneNumber + " " + birthDate + " " + city);

            comboBox1.Items.Add(city);
        }
    }
}

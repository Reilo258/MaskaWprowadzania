using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Regex data = new Regex(@"^[0-9]{2}\.[0-9]{2}\.[0-9]{4}$");
        Regex tel = new Regex(@"^[\(\+][0-9]{2}[\)]([0-9]{3}\-){2}[0-9]$");
        Regex mail = new Regex(@"^[a-z][a-z0-9]+@[a-z0-9]+\.[a-z]{2,3}$");
        public Form1()
        {
            InitializeComponent();
        }
        private void wyslijbtn_Click(object sender, EventArgs e)
        {
            if ((imieBox.Text == "") || (nazwiskoBox.Text == "") || (dataBox.Text == "") || (peselBox.Text == "") || (telBox.Text == "") || (mailBox.Text == ""))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione");
            }

            // IMIE
            if (imieBox.Text == string.Empty)
            {
                imieerrorlbl.Visible = true;
                errorlbl.Visible = true;
            }
            else
            {
                imieerrorlbl.Visible = false;
                errorlbl.Visible = false;
            }

            // NAZWISKO
            if (nazwiskoBox.Text == string.Empty)
            {
                nazwiskoerrorlbl.Visible = true;
                errorlbl.Visible = true;
            }
            else
            {
                nazwiskoerrorlbl.Visible = false;
                errorlbl.Visible = false;
            }

            // DATA URODZENIA
            if (data.IsMatch(dataBox.Text) == false)
            {
                dataerrorlbl.Visible = true;
                errorlbl.Visible = true;
            }
            else
            {
                dataerrorlbl.Visible = false;
                errorlbl.Visible = false;
            }

            // PESEL
            if (peselBox.Text.Length != 11)
            {
                peselerrorlbl.Visible = true;
                errorlbl.Visible = true;
            }
            else
            {
                peselerrorlbl.Visible = false;
                errorlbl.Visible = false;
            }

            // TELEFON
            if (tel.IsMatch(telBox.Text) == false)
            {
                telerrorlbl.Visible = true;
                errorlbl.Visible = true;
            }
            else
            {
                telerrorlbl.Visible = false;
                errorlbl.Visible = false;
            }

            // E-MAIL
            if (mail.IsMatch(mailBox.Text) == false)
            {
                mailerrorlbl.Visible = true;
                errorlbl.Visible = true;
            }
            else
            {
                mailerrorlbl.Visible = false;
                errorlbl.Visible = false;
            }
        }
    }
}
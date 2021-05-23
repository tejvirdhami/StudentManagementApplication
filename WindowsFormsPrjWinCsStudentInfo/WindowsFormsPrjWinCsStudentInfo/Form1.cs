using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPrjWinCsStudentInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        clsListStudent studlist = new clsListStudent();
        ClsStudent stud = new ClsStudent();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string number = txtNumber.Text;
            string name = txtName.Text;
          
            var date = DateTime.Parse(txtBirthdate.Text);
            Single grade = Convert.ToSingle(txtGrade.Text);

            stud.Register(number, name, date, grade);

            btnAdd.Enabled = false;
            txtNumber.ReadOnly = true;
            txtName.ReadOnly = true;
            txtBirthdate.Enabled = false;
            txtGrade.ReadOnly = true;
            studlist.Add(cl);
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            txtNumber.ReadOnly = false;
            txtName.ReadOnly = false;
            txtBirthdate.Enabled = true;
            txtGrade.ReadOnly = false;
        }
    }
}

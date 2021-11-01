using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private string Form6_value;
        public string Passvalue
        {
            get { return this.Form6_value; }
            set { this.Form6_value = value; }               // 폼 5에서 전달받은 값
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            txtID.Text = Passvalue;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 showForm5 = new Form5();
            showForm5.Passvalue = Passvalue;
            showForm5.ShowDialog();
        }
    }
}

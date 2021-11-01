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
    public partial class Form5 : Form
    {
        private string Form5_value;
        public string Passvalue
        {
            get { return this.Form5_value; }
            set { this.Form5_value = value; }               // 폼 3에서 전달받은 값
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtID.Text = Passvalue + " 님 반갑습니다.";                  // 폼 3에서 전달받은 값을 변수에 저장
        }
        private void start_Click(object sender, EventArgs e)            // 시작
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.Passvalue = Passvalue;
            showForm1.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)           // 로그아웃
        {
            this.Visible = false;
            Form3 showForm3 = new Form3();
            showForm3.ShowDialog();
        }

        private void rank_Click(object sender, EventArgs e)             // 순위표
        {
            this.Visible = false;
            Form6 showForm6 = new Form6();
            showForm6.Passvalue = Passvalue;
            showForm6.ShowDialog();
        }
    }
}

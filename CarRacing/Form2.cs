using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace CarRacing
{ 
    public partial class Form2 : Form               // 회원가입
    {
        public bool test = false;
        TextBox[] txtList;
        const string IdPlaceholder = " 아이디를 입력하세요";
        const string PwPlaceholder = " 8~16자 영문 대 소문자, 숫자를 사용하세요.";
        const string NamePlaceholder = " 이름을 입력하세요";

        public Form2()
        {
            InitializeComponent();

            txtList = new TextBox[] { txtID, txtPW, txtName };              // ID, Password TextBox Placeholder 설정
            foreach (var txt in txtList)
            {
                txt.ForeColor = Color.DarkGray;                             // 처음 공백 Placeholder 지정
                if (txt == txtID) txt.Text = IdPlaceholder;
                else if (txt == txtPW) txt.Text = PwPlaceholder;
                else if (txt == txtName) txt.Text = NamePlaceholder;


                txt.GotFocus += RemovePlaceholder;                          // 텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.LostFocus += SetPlaceholder;
            }
        }
        FirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "6wgbpdm3RpQHrrugQe9URIjMN2Bdt3zcKoQnAJDE", BasePath = "https://register-28fbf-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if ( txt.Text == IdPlaceholder | txt.Text == PwPlaceholder | txt.Text == NamePlaceholder )     // 텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
            {
                txt.ForeColor = Color.Black;                               // 사용자 입력 진한 글씨
                txt.Text = string.Empty;
                if (txt == txtPW) txtPW.PasswordChar = '●';
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))                       // 사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
            {
                txt.ForeColor = Color.DarkGray;                            // Placeholder 흐린 글씨
                if (txt == txtID) txt.Text = IdPlaceholder;
                else if (txt == txtPW) { txt.Text = PwPlaceholder; txtPW.PasswordChar = default; }
                else if (txt == txtName) txt.Text = NamePlaceholder;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fbc);
            }
            catch
            {
                MessageBox.Show("문제 발생");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = client.Get("가입자 명단/" + txtID.Text);
            Upload upd = result.ResultAs<Upload>();

            Upload upd2 = new Upload()
            {
                name = txtName.Text, id = txtID.Text, pw = txtPW.Text
            };
            var send = client.Set("가입자 명단/" + txtID.Text, upd2);
            MessageBox.Show("회원가입을 완료했습니다.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 showForm3 = new Form3();
            showForm3.ShowDialog();
        }

    }
}

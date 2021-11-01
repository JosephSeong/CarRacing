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
    public partial class Form3 : Form                     // 로그인
    {
        public bool test = false;
        TextBox[] txtList;
        const string IdPlaceholder = " 아이디";
        const string PwPlaceholder = " 비밀번호";
        public Form3()
        {
            InitializeComponent();
       
            txtList = new TextBox[] { txtID, txtPW };                       // ID, Password TextBox Placeholder 설정
            foreach (var txt in txtList)
            {
                txt.ForeColor = Color.DarkGray;                             // 처음 공백 Placeholder 지정
                if (txt == txtID) txt.Text = IdPlaceholder;
                else if (txt == txtPW) txt.Text = PwPlaceholder;

                txt.GotFocus += RemovePlaceholder;                          // 텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.LostFocus += SetPlaceholder;
            }
        }
        FirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "6wgbpdm3RpQHrrugQe9URIjMN2Bdt3zcKoQnAJDE",
            BasePath = "https://register-28fbf-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == IdPlaceholder | txt.Text == PwPlaceholder)     // 텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
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
            }
        }

        private void Form3_Load(object sender, EventArgs e)
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
       
        private void button1_Click(object sender, EventArgs e)             // 로그인 버튼(게임시작 화면으로 이동)
        {
            var result = client.Get("가입자 명단/" + txtID.Text);
            Upload upd = result.ResultAs<Upload>();

            if(upd == null || txtPW.Text != upd.pw)      // DB에 id정보가 없거나 pw가 같지 않으면
            {
                MessageBox.Show("아이디와 비밀번호를 확인해주세요.");
            }
            else
            {
                MessageBox.Show(" "+txtID.Text + " 님 반갑습니다.");

                this.Visible = false;
                Form5 showForm5 = new Form5();                     // 로그인 성공 후 게임시작화면 이동
                showForm5.Passvalue = txtID.Text;
                showForm5.ShowDialog();
            }
        } 
            
        private void button2_Click(object sender, EventArgs e)             // 회원가입 폼으로 이동
        {
            this.Visible = false;
            Form2 showForm2 = new Form2();
            showForm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)             // 비밀번호 찾기 폼으로 이동
        {
            this.Visible = false;
            Form4 showForm4 = new Form4();
            showForm4.ShowDialog();
        }
    }
}

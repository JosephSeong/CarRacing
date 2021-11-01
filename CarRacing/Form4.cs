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
    public partial class Form4 : Form
    {
        public bool test = false;
        TextBox[] txtList;
        const string IdPlaceholder = " 아이디를 입력하세요";
        const string PwPlaceholder = " 비밀번호 불러오는 중...";

        public Form4()
        {
            InitializeComponent();

            txtList = new TextBox[] { txtID, txtPW };                              // ID, Password TextBox Placeholder 설정
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
            if (txt.Text == IdPlaceholder | txt.Text == PwPlaceholder)                                // 텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
            {
                txt.ForeColor = Color.Black;                               // 사용자 입력 진한 글씨
                txt.Text = string.Empty;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))                       // 사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
            {
                txt.ForeColor = Color.Black;                           
                if (txt == txtID) txt.Text = IdPlaceholder;
                else if (txt == txtPW) { txt.Text = PwPlaceholder; txtPW.PasswordChar = default; }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
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
            if(txtID.Text == "")
            {
                MessageBox.Show("정보를 기입해 주세요.");
            }
            else if(upd == null)
            {
                MessageBox.Show("입력한 정보를 보유하고 있지 않습니다.");
            }
            else
            {
                txtPW.Text = upd.pw;
                MessageBox.Show("회원님의 비밀번호는 " + txtPW.Text + "입니다.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 showForm3 = new Form3();
            showForm3.ShowDialog();
        }
    }
}

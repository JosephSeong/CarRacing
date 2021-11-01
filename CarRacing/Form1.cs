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
    public partial class Form1 : Form
    {
        private string Form1_value;
        public string Passvalue
        {
            get { return this.Form1_value; }
            set { this.Form1_value = value; }               // 폼 5에서 전달받은 값
        }

        int roadSpeed = 15;                                           // 속도 설정
        int trafficSpeed = 15;
        int playerSpeed = 12;
        int coinSpeed = 10;
        int score, collectedcoin;
        int carImage, coinImage;
        int result;

        Random rand = new Random();
        Random carPosition = new Random();
        Random coinPosition = new Random();
        bool goleft, goright;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)                 // 폼 5에서 전달받은 값을 변수에 저장
        {
            txtID.Text = "Player : " + Passvalue;                                
        }       

        private void restartGame(object sender, EventArgs e)                // 재시작
        {
            ResetGame();
        }

        private void ResetGame()                                            // 리셋
        {
            btnStart.Enabled = false;
            explosion.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            collectedcoin = 0;
            textCoin.Text = "Coin : " + collectedcoin;
            textResult.Enabled = false;
            textResult.SendToBack();
            roadSpeed = 12;
            trafficSpeed = 15;
            coinSpeed = 12;

            A1.Top = carPosition.Next(200, 500) * -1;
            A1.Left = carPosition.Next(5, 200);
            A2.Top = carPosition.Next(200, 500) * -1;
            A2.Left = carPosition.Next(245, 422);

            money1.Top = coinPosition.Next(200, 500) * -1;
            money1.Left = coinPosition.Next(5, 125);
            money2.Top = coinPosition.Next(200, 500) * -1;
            money2.Left = coinPosition.Next(300, 422);
            money3.Top = coinPosition.Next(200, 500) * -1;
            money3.Left = coinPosition.Next(175, 250);
            gameTimer.Start();
        }

        private void gameTimerEvent(object sender, EventArgs e)             // Timer / 점수
        {
            result = score + collectedcoin * 10;              // 총 점수 계산                 
            textScore.Text = "Score : " + score;
            score++;

            if (goleft == true && player.Left > 10)         // 플레이어
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Left < 415)
            {
                player.Left += playerSpeed;
            }

            roadtrack1.Top += roadSpeed;                    // 도로
            roadtrack2.Top += roadSpeed;

            if (roadtrack2.Top > 519)
            {
                roadtrack2.Top = -519;
            }
            if (roadtrack1.Top > 519)
            {
                roadtrack1.Top = -519;
            }

            A1.Top += trafficSpeed;                         // 차
            A2.Top += trafficSpeed;
            A1.BringToFront();
            A2.BringToFront();

            if (A1.Top > 530)
            {
                ChangeACars(A1);
            }
            if (A2.Top > 530)
            {
                ChangeACars(A2);
            }
            if (player.Bounds.IntersectsWith(A1.Bounds) ||                   // 충돌
                player.Bounds.IntersectsWith(A2.Bounds))
            {
                gameOver();
            }
            if (score > 0 && score < 300)                                  
            { }
            if (score > 300 && score < 500)                                // 300점 이후 속도 증가
            {
                roadSpeed = 15;
                trafficSpeed = 17;
            }
            if (score > 500 && score < 800)                                // 500점 이후 속도 증가
            {
                roadSpeed = 20;
                trafficSpeed = 22;
            }
            if (score > 800 && score < 1000)                                // 800점 이후 속도 증가
            {
                roadSpeed = 25;
                trafficSpeed = 27;
            }
            if (score > 1000)                                               // 1000점 이후 속도 증가
            {
                roadSpeed = 27;
                trafficSpeed = 27;
            }

            money1.Top += trafficSpeed;                                     // 코인
            money2.Top += trafficSpeed;
            money3.Top += trafficSpeed;

            if (money1.Top > 530)
            {
                coinsCollection(money1);
            }
            if (money2.Top > 530)
            {
                coinsCollection(money2);
            }
            if (money3.Top > 530)
            {
                coinsCollection(money3);
            }

            if (player.Bounds.IntersectsWith(money1.Bounds))
            {
                collectedcoin++;
                textCoin.Text = "Coin : " + collectedcoin;
                money1.Location = new Point(coinImage, 0);                      // 코인 획득
                coinImage = rand.Next(5, 125);                                  // 획득 후 랜덤생성
            }
            if (player.Bounds.IntersectsWith(money2.Bounds))
            {
                collectedcoin++;
                textCoin.Text = "Coin : " + collectedcoin;
                money2.Location = new Point(coinImage, 0);
                coinImage = rand.Next(300, 422);
            }
            if (player.Bounds.IntersectsWith(money3.Bounds))
            {
                collectedcoin++;
                textCoin.Text = "Coin : " + collectedcoin;                
                money3.Location = new Point(coinImage, 0);
                coinImage = rand.Next(175, 250);
            }
            
        }

        private void ChangeACars(PictureBox tempCar)                        // 차 변경
        {
            carImage = rand.Next(1, 8);
            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.blackcar;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.redcar;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.taxi;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.whitecar;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.graycar;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.poicecar11;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.sportcar2;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.neocar;
                    break;
            }
            tempCar.Top = carPosition.Next(100, 400) * -1;                   // 다음 차
            if ((string)tempCar.Tag == "carLeft")                            // Tag 사용
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }
        }

        private void coinsCollection(PictureBox tempCoin)                   // 코인
        {
            coinImage = rand.Next(1, 3);
            switch (coinImage)
            {
                case 1:
                    tempCoin.Image = Properties.Resources.doge;
                    break;
                case 2:
                    tempCoin.Image = Properties.Resources.doge;
                    break;
                case 3:
                    tempCoin.Image = Properties.Resources.doge;
                    break;
            }
            tempCoin.Top = coinPosition.Next(100, 400) * -1;                // 다음 코인
            if ((string)tempCoin.Tag == "coinLeft")                         // Tag 사용
            {
                tempCoin.Left = coinPosition.Next(5, 125);
            }
            if ((string)tempCoin.Tag == "coinRight")
            {
                tempCoin.Left = coinPosition.Next(300, 422);
            }
            if ((string)tempCoin.Tag == "coinCenter")
            {
                tempCoin.Left = coinPosition.Next(175, 250);
            }
        }

        private void gameOver()                                             // 게임종료
        {
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-40, 0);
            explosion.BackColor = Color.Transparent;
            textResult.BringToFront();
            textResult.Enabled = true;
            textResult.Text = "Game Over\n     " + result + "점";          // 총 점수
            btnStart.Enabled = true;
        }

        private void keyisdown(object sender, KeyEventArgs e)               // 키를 처음 누를 때
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)                 // 키를 놓을 때
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void menu_Click(object sender, EventArgs e)                 // 메뉴 버튼
        {
            this.Visible = false;
            Form5 showForm5 = new Form5();
            showForm5.Passvalue = Passvalue;
            showForm5.ShowDialog();
        }
    }
}

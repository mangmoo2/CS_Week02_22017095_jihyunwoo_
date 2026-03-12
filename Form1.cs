using System.Media;
using static System.Net.Mime.MediaTypeNames;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 0; //점수 변수
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play(); // 2_1. 소리 재생
            MessageBox.Show("축하합니다~!");

            score += 100;     // 잡으면 점수 증가
            button1.Width = (int)(button1.Width * 0.9); // 잡으면 넓이 10% 줄어들기
            button1.Height = (int)(button1.Height * 0.9); // 잡으면 높이 10% 줄어들기
            Update_(); // 점수 업데이트
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // 1. 난수생성기
            Random rd= new Random();
            // 2. 가용영역계산_버튼이폼테두리에걸리지않게보호    
            int maxX= this.ClientSize.Width;int maxY= this.ClientSize.Height;
            // 3. 랜덤좌표추출
            int nextX= rd.Next(0, maxX);int nextY= rd.Next(0, maxY);
            // 4. 위치할당
            button1.Location= new Point(nextX, nextY);
            // 5. 시각적피드백
            this.Text= $"버튼위치: ({nextX}, {nextY})";

            // 2_1. 도망갈 때의 효과음 재생
            SystemSounds.Asterisk.Play();
            Update_();// 점수 업데이트

            score -= 10; //놓차면 10점 감점
        }

        private void Update_() // 업데이트   
        { 
            this.Text = $"점수: {score}";
        }
    }
}

using System.Media;
using static System.Net.Mime.MediaTypeNames;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 0; //점수 변수
        int miss_Count = 0; //놓친 점수
        Size Size1; // 원래 버튼 사이즈

        public Form1()
        {
            InitializeComponent();
            Size1 = button1.Size; // 사이즈 저장
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
            Random rd = new Random();
            // 2. 가용영역계산_버튼이폼테두리에걸리지않게보호    
            int maxX = this.ClientSize.Width; int maxY = this.ClientSize.Height;
            // 3. 랜덤좌표추출
            int nextX = rd.Next(0, maxX); int nextY = rd.Next(0, maxY);
            // 4. 위치할당
            button1.Location = new Point(nextX, nextY);
            // 5. 시각적피드백
            this.Text = $"버튼위치: ({nextX}, {nextY})";

            // 2_1. 도망갈 때의 효과음 재생
            SystemSounds.Asterisk.Play();


            score -= 10; //놓차면 10점 감점
            miss_Count++; // 놓친 횟수 카운트

            Update_();// 점수 업데이트 

            if (miss_Count >= 20)
            {
                button1.Enabled = false; // 버튼 비활성화 
                MessageBox.Show("Game Over");  //게임 오버 메세지 출력
            }

        }

        private void Update_() // 업데이트   
        {
            this.Text = $"점수: {score}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            score = 0;          // 점수 초기화
            miss_Count = 0;       // 횟수 초기화
            button1.Size = Size1; // 크기 복구
            button1.Enabled = true; // 버튼 재활성화
            button1.Location = new Point(10, 10); // 적당한 위치로 복귀

            Update_();
            MessageBox.Show("게임 재시작");
        }
    }
}

# 버튼잡기게임(C# 코딩)
## 개요-
C# 프로그래밍학습
## -핵심기능: 
1. 폼 안에서만 버튼 위치 랜덤 변경, 
2. 잡을 때와 도망갈때 각각 다른 소리 발생, 
3. 잡으면 +100점 및 버튼 크기 감소, 도망가면 -10점 , 
4. 제목 표시줄 업데이트

-화면구성: "나를 잡아봐라"버튼, 재도전 버튼, 폼 창

## 실행화면 ##
-1단계코드의실행스크린샷 (ui 구성, 버튼 이동 기능 구현, 버튼 이동범위 제한, 버튼 위치 정보 표시)

<img width="793" height="466" alt="image" src="https://github.com/user-attachments/assets/c1372461-eda8-401e-9bf8-ad448ea95551" />


-2단계코드의실행스크린샷 (버튼을 잡았을때와 놓쳤을때 적절한 피드백을주기)

<img width="793" height="469" alt="image" src="https://github.com/user-attachments/assets/b7d85ecf-ba49-4ec7-a0f3-1952dfaea97a" />


-3단계코드의실행스크린샷 (점수를 계산하여 표시하기, 게임이 점점 어려워지도록 만들기)

<img width="796" height="473" alt="image" src="https://github.com/user-attachments/assets/6b6f04d1-5f56-4808-809d-57fb40923f9d" />

-4단계코드의실행스크린샷 (게임오버 표시하기, 재도전 버튼 만들기)

<img width="786" height="472" alt="image" src="https://github.com/user-attachments/assets/c9a047d6-9126-4126-abfd-998f38f11ca5" />



## 구현시어려웠던점
1. 코드에서 함수 이름을 수정하거나 오타를 내서 오류를 발생시킴 (ex botton1, button1)
2. 버튼의 폼 화면 밖 생성에 생성 되는 현상을 수정하기 위해 int maxX = this.ClientSize.Width; int maxY = this.ClientSize.Height;으로
   고침.

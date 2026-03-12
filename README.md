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
-1단계코드의실행스크린샷 

<img width="804" height="478" alt="image" src="https://github.com/user-attachments/assets/9cb546ee-1b15-4535-9082-dd38c2e0c5e9" />

-2단계코드의실행스크린샷 

<img width="798" height="478" alt="image" src="https://github.com/user-attachments/assets/a31ea899-f0ab-4358-84ae-df4fbec0bf52" />

-3단계코드의실행스크린샷 

<img width="798" height="474" alt="image" src="https://github.com/user-attachments/assets/8cad1095-a1ec-4198-b253-1a8dc5693b1e" />

-4단계코드의실행스크린샷 

<img width="797" height="478" alt="image" src="https://github.com/user-attachments/assets/13cf5af1-6658-480b-a736-30eaaa2324e4" />

## 구현시어려웠던점
1. 코드에서 함수 이름을 수정하거나 오타를 내서 오류를 발생시킴 (ex botton1, button1)
2. 버튼의 폼 화면 밖 생성에 생성 되는 현상을 수정하기 위해 int maxX = this.ClientSize.Width; int maxY = this.ClientSize.Height;으로
   고침.

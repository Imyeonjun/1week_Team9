
<div align="center">
  
# 🎮 1week_Team9

내일배움캠프 Unity 9기 - **1주차 미니 프로젝트** (9조)  
이 저장소는 9조의 미니 프로젝트 개발을 위한 GitHub 저장소입니다.

---

## 👥 조원
| 이름       | 담당 역할  | Github주소 |
|------------|------------|-----------|
| 조성득 |  	README 작성 및 기본 구조 구현  | https://github.com/Duek1/Duek2 |
| 김가람 |   스타트 씬 및 사운드 구현 | https://github.com/garamzui |
| 이종민B |   카드가 뒤집어지는 애니메이션 연출 | https://github.com/dlwhdalsd |
| 임연준 |  이미지 파일 관련 코드 및 리소스 관리 | https://github.com/Imyeonjun/1week_Team9.git |
| 김상훈  |  스테이지 선택 및 해금 시스템 개발 | https://github.com/skyrunner8797 |

---
# 🎮 프로젝트 이름 (구조 요청 Mayday)
- 카드 뒤집기 게임
---
# 🎲 게임 소개

## 🃏 카드 뒤집기 게임 (Memory Flip Game)

+ 제한 시간 안에 모든 짝을 맞춰라!  
+ 기억력과 순발력을 겨루는 심플하지만 중독성 있는 카드 매칭 게임 🎮
+ 같은 그림 카드를 찾아서 모든 카드를 뒤집어보세요!
---
## 🧩 와이어프레임

![와이어프레임](https://github.com/Imyeonjun/1week_Team9/blob/main/frame.png?raw=true)


---
## 📸 게임 화면 예시

![게임화면예시](https://github.com/Imyeonjun/1week_Team9/blob/main/CardGame.gif?raw=true)

---

| 초기화면 | 카드 일부 공개 | 정답 매칭 성공 |
|-----------|----------------|----------------|
| [![1](https://github.com/Imyeonjun/1week_Team9/blob/Duekk/카드뒤집기1.png?raw=true)](https://github.com/Imyeonjun/1week_Team9/blob/Duekk/카드뒤집기1.png) | [![2](https://github.com/Imyeonjun/1week_Team9/blob/Duekk/카드뒤집기2.png?raw=true)](https://github.com/Imyeonjun/1week_Team9/blob/Duekk/카드뒤집기2.png) | [![3](https://github.com/Imyeonjun/1week_Team9/blob/Duekk/카드뒤집기3.png?raw=true)](https://github.com/Imyeonjun/1week_Team9/blob/Duekk/카드뒤집기3.png) |

---

## 📽️ 게임 시연 예시

![게임 시작 GIF](https://github.com/Imyeonjun/1week_Team9/blob/Duekk/CardGif/CardGame2.gif?raw=true)

- 제한 시간 내에 같은 이미지를 맞추는 카드 뒤집기 게임입니다.
- 같은 그림을 찾으면 카드가 뒤집어지면서 사라집니다.

---
## 🟢 게임 시작 화면 (GIF)
![시작화면](https://github.com/Imyeonjun/1week_Team9/blob/Duekk/CardGif/StartScene2.gif?raw=true)

게임을 켜면 StartScene에서 시작됩니다. StartScene에 있는 구조하기! 버튼을 누르면 MainScene으로 이동합니다. MainScene으로 이동하게 만든 로직은 RetryBtn스크립트(SceneManager.LoadScene("MainScene");
)를 활용하여 구조하기! 버튼에 RetryBtn스크립트를 이용하여 MainScene으로 이동하게 했습니다.

### 🎉 게임 성공 화면
![성공 화면](https://github.com/Imyeonjun/1week_Team9/blob/Duekk/CardImages/Finish.png?raw=true)

게임을 클리어 하면 구조성공! 텍스트가 나오고 팀원들의 카드가 나옵니다. 구조성공! 버튼을 누르면 RetryBtn스크립트가 작동해서 MainScene으로 이동합니다. 

### 💡 보너스 스테이지

![보너스](https://github.com/Imyeonjun/1week_Team9/blob/main/%EB%B3%B4%EB%84%88%EC%8A%A4%EB%8B%A8%EA%B3%84.png?raw=true)

![보너스](https://github.com/Imyeonjun/1week_Team9/blob/main/%EB%B3%B4%EB%84%88%EC%8A%A4%EB%8B%A8%EA%B3%842.png?raw=true)

메인 스테이지를 클리어 시, 클리어 화면 우측 상단에 보너스 단계를 플레이할 수 있는 버튼이 생성됩니다. 해당 버튼을 누르면 즉시 보너스 스테이지로 이동합니다
보너스 스테이지는 메인 스테이지와 구별할 수 있도록 밝은 노란색으로 배경을 입혔습니다.

---
# 🔧 구현 기능

### ⏳ 제한 시간 시스템
- 게임 상단에 남은 시간 표시
- 시간이 0이 되면 자동으로 게임 종료

![제한시간](https://github.com/Imyeonjun/1week_Team9/blob/Duekk/CardImages/제한시간시스템.png?raw=true)

### 📦 카드 생성 및 배치
- 원하는 갯수만큼 카드 자동 생성
- 사전에 등록된 이미지 중 무작위로 카드에 2장씩 배치

![카드생성](https://github.com/Imyeonjun/1week_Team9/blob/Duekk/CardImages/카드생성및배치.png?raw=true)

### 🌀 카드 뒤집기 애니메이션
-  클릭 시 카드가 회전하며 이미지 표시
-  Unity에서 Animator을 사용하여 카드가 뒤집히는 애니메이션 적용

![애니메이션](https://github.com/Imyeonjun/1week_Team9/blob/main/animation.png?raw=true)

### ✅ 매칭 판정 로직
- 두 장의 카드가 동일 이미지일 경우 고정
- 다를 경우 일정 시간 후 다시 뒤집힘
- 
![매칭판정](https://github.com/Imyeonjun/1week_Team9/blob/Duekk/CardImages/매칭판정로직.png?raw=true)

### 🏁 게임 클리어 조건
- 제한 시간 내 모든 카드 짝 맞추면 클리어
- 클리어 시 메시지/애니메이션 출력

  ![게임클리어](https://github.com/Imyeonjun/1week_Team9/blob/Duekk/CardImages/게임클리어조건.png?raw=true)

### 🔊 사운드 효과
- 게임 시작 시 효과음 재생
- 카드 클릭, 정답/오답 시 각각 다른 효과음 구현

### 🗂️ 이미지 관리 코드
- 이미지 리스트를 스크립트에서 관리 및 랜덤 셔플
- 리소스 최적화를 위한 분리 로딩 구조

![이미지관리](https://github.com/Imyeonjun/1week_Team9/blob/Duekk/CardImages/이미지관리코드.png?raw=true)

### 🌟 스테이지 선택 / 해금 시스템
- 기본 스테이지 외 추가 난이도 구현
- 이전 스테이지 클리어 시 다음 스테이지 해금
- 스테이지별 카드 수/시간 차등 적용

![스테이지](https://github.com/Imyeonjun/1week_Team9/blob/main/%EB%B3%B4%EB%84%88%EC%8A%A4%EB%8B%A8%EA%B3%84%EC%BD%94%EB%93%9C.png?raw=true)

---
## 🧪 향후 개선 계획 (TODO)
- 멀티플레이 모드 추가

- 힌트 아이템 기능 추가 , 멀티플레이 모드 추가 시 공격 아이템 기능 추가

- 모바일 환경 최적화

- 카드맞추기 성공 시 재밌는 사운드 추가

## 🛠️ 사용된 툴

- Unity (버전 2022.3.17f1)
- C#

---
</div>

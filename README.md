# BurgerKiosk
# (C# 코딩) 키오스크 주문 화면
## 개요
- C# 프로그래밍 학습
- 1줄 소개: 메뉴와 추가옵션을 선택하는 키오스크 주문 화면 제작을 만들기
- 핵심기능: 선택을 위한 체크박스와 라디오버튼 컨트롤 활용 
- 화면구성: Label(프로그램 제목), Textbox, Button, CheckBox, RadioButton
- 사용한 플랫폼: 
	- C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
	- Label, TextBox, Button, CheckBox, RadioButton
- 사용한 기술과 구현한 기능:
	- Visual Studio를 이용하여 UI 디자인
	- 가격 계산 로직 구현
	- 선택값 읽기 및 처리

## 실행 화면 (과제1)
- 과제1 코드의 실행 스크린샷
<img width="944" height="496" alt="과제1" src="https://github.com/user-attachments/assets/d732c5c2-3ba1-463a-99e8-0d2f74ed3a2f" />
<img width="943" height="497" alt="과제1_2" src="https://github.com/user-attachments/assets/87a0943d-cb63-4f2b-98cd-9b324c31bb9b" />

- 과제 내용
	- RadioButton과 CheckBox 등을 적절히 배치합니다
	- GroupBox로 적절하게 그룹으로 묶습니다.
	- 주문 내역과 총 금액을 표시합니다. 
	- 다시 주문할 수 있도록 초기화 합니다. 
- 구현 내용과 기능 설명
	- UI 구성을 텍스트 박스와 버튼으로 구성합니다.
	- totalcost에 Tostring 메서드를 추가하여 금액에 천원단위로 ","가 찍히게 합니다.
	- 주문하기 버튼과 초기화 버튼의 기능 구현합니다
- 사용한 기술과 구현한 기능:
	- RadioButton과 CheckBo 툴들을 이용하여 UI 디자인합니다.
	- 이벤트 메소드들을 툴들과 연결하여 기능 구현
	- Listbox를 이용해 주문 내역과 총 금액을 표시합니다. 

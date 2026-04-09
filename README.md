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

## 실행 화면 (과제2)
- 과제2 코드의 실행 스크린샷
<img width="940" height="488" alt="과제2" src="https://github.com/user-attachments/assets/a40e7683-b96c-4390-bcb6-25ddd64a6c5b" />

- 구현한 내용
	- Label 컨트롤을 추가하여 주문 불가 안내 문구를 추가합니다.
	- Visible 속성을 이용해서 Label 보이기와 숨기기 기능 구현합니다.
	- 주문 불가 안내 문구 색을 변경하는 메소드 추가합니다.


## 실행 화면 (과제3)
- 과제3 코드의 실행 스크린샷
<img width="939" height="490" alt="과제 3" src="https://github.com/user-attachments/assets/23ddd186-670b-457f-b65d-84a02323b41f" />

- 구현한 내용
	- 체크박스에 키 다운 이벤트를 추가하여 Enter키 치면 선택하기 기능을 구현합니다.
	- 키 다운 메소드를 추가하여 탭키를 통해 포커스가 이동하도록 합니다.
	- 폼 생성자에 구현하고자 하는 기능에 필요한 코드를 추가하여 키보드를 이용한 주문이 가능하도록 합니다.


## 실행 화면 (과제4)
- 과제4 코드의 실행 스크린샷
<img width="944" height="487" alt="과제 4" src="https://github.com/user-attachments/assets/2f8e8f3d-e619-49b3-a36d-c6d2c2b20b99" />

- 구현한 내용
	- 공통 함수를 만들어 체크 박스를 선택할 때마다 바로 리스트 박스에 반영되게 합니다.
	- 선택하는 순간 Label에 전체 가격 정보가 표시되도록 합니다.
	- 작성한 함수와 툴들을 연결하여 이벤트가 적절하게 발생하도록 합니다.

미니게임 일지
6/6
미니게임 맵 정리

-목표
--점프하는공--피격시 이펙트
--기본적인 캐릭움직임
--적 - 근처오면 따라감
--날아오는 로켓


골드메탈 영상 공부 ~B5
!유니티에서 객체조절
q-뷰이동
w-객체이동
e-객체회전
r-객체크기변경
t-객체사각툴

카메라
우클릭-카메라회전
alt+우클릭- 카메라 축 이동
키보드 방향키- 카메라 자유 이동

!유니티 오브젝트 생명주기

6/7
B5까지 복습겸 시점이동과 객체 생성, 위치 크기 변경 연습

B6
!키입력
!Input Manager
!객체 이동하기 

6/9 B7~
Vector3를 이용한 목표 지점으로 객체 이동

//미니게임 헬모드- 로켓 고리로 회전

6_12
B8 Time.deltaTime
Time.deltaTime  - 프레임에 따른 시간차 해소

B9 실제와 같은 물체 만들기-Mesh, Material, Collider, RigidBody
//점프볼구현
Component 
-RigidBody :  물리효과 적용
--Mass : 무게
--Is kinematic : 충돌하더라도 움직임 변화x - 함정에 유용

-Collider : 충돌 기준

물리 재질
-Physics Material : 탄성과 마찰을 다루는 물리적인 재질
--Bounce Combine : average -> 1튀김 절반높이 ->2튀김 절반의절반 높이
-Friction : 마찰력,낮을수록 많이 미끄러짐
//컴포넌트는 어떻게 합쳐서 다른객체에 적용할 수 없을까?
//부모 오브젝트 관련 확인필요
//빈오브젝트에 컴포넌트작성후 하위로 객체를 넣어줌


B10 힘을 이용하여 물체 움직여보기
start 블록
{
Rigidbody.velocity = Vector3.right; //오른쪽으로 속력
Rigidbody.velocity = new Vector3(x=2,y=3.z=1); //벡터방향 최초 힘작용
//힘으로밀기
rigid.AddForce(Vector3.up*5,ForceMode.Impulse); //캐릭 점프 구현//ForceMode-힘의형식(가속,무게 등)
}
//뒤에서 쫒아오는 공(함정) 구현

update블록
{
Rigidbody.velocity = new Vector3(x=2,y=3.z=1); //벡터방향 힘 지속적으로 작용
}

//회전력
rigid.AddTorque(Vec) : Vec방향을 축으로 회전력이 생김

6_13
B11 물리충돌
MeshRenderer-재질접근
OnCollisionEnter-물리충돌시작 //피해시 빨강
OnCollisionStay-물리충돌중
OnCollisionExit-물리충돌끝 //원래색

트리거 - OnTriggerStay 


using UnityEngine;
public class Lec01 : MonoBehaviour
{
  // 1. 스크립트 클래스 구성 : 접근제어자 class  클래스명
  //   - 접근지정자 : public, private, protected
  //   - 클래스(class) : 클래스명이라고 하는 이름을 객체로 지정
  //   - 클래스명 : 파일명과 동일, 클래스명은 영문 숫자 기호 사용할 수 있음

  // 2. 주석
  //   - 정의 : 코드와 별개로 코드의 설명이나 기능등을 나열할 때 사용
  //   - 종류 
  //     - // : 한 줄을 주석 처리 사용
  //     - /* 한 줄 이상 주석 처리 사용 */
  //     - /// 설명
  //       /// 이 코드는 테스트 파일입니다.      

  // 1. 변수와 함수의 이해
  //     - 변수 : 값(VALUE)이 할당되는 이름
  //             메모리에 일정 공간을 할애 받는 것
  //     - 형식 : 자료타입(int, float double char String bool)  변수명  =  값;

  // 정수
  int gold = 1000;

  // 실수
  float intermWeight = 1.3f;
  double Weight = 1.5;

  // 조건 : true(맞다) : 1,  false(틀리다) : 0
  // 문법상 짝 : if, :;(삼항연산자)

  // 문자열 : char (문자 한 자), 문법상 많이 쓰는곳 : Switch case 문
  //          string (여러문자를 사용할 때)
  char itemName1 = 'P';
  string itemName2 = "Potion";

  // 2. 변수에 할당된 데이터는 런타임(Run Time)(게임 도중)에
  //     얼마든지 접근하여 수정 가능
  //    ex) type name;
  //         type name = value;

  // 숫자형 변수
  int age = 23;
  int money = -1000;
  void Start()
  {
    // 콘솔 출력
    Debug.Log("Hello World");

    // 숫자형 변수
    int age = 23;
    int money = -1000;

    Debug.Log(age);
    Debug.Log(money);

    // floating point(부동소수점) - float : 소수점을 가지는 실수 : 32비트
    // 소수점 아래 7자리까지만 정확
    // 8자리 이상일 경우 근사값으로 처리
    float height = 160.1234567f; // 3자리 정확

    Debug.Log(height); // 결과 : 160.1235

    // double <- float의 두배의 메모리를 사용 : 64비트
    // 소수점 아래 15자리 까지만 정확
    // 16자리 이상일 경우 근사값을 처리
    double pi = 3.14159265359;

    Debug.Log(pi); // 결과 : 3.14159265359

    double pi2 = 3.1415926535946589;  // 13자리 정확

    Debug.Log(pi2); // 결과 : 3.14159265359466

    // bool은 참 true(1) 거짓 false(0)
    bool isBoy = true;
    bool isGirl = false;

    Debug.Log("isBoy : " + isBoy);
    Debug.Log("isGirl : " + isGirl);
  }
}
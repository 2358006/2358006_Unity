using UnityEngine;
public class Lec01 : MonoBehaviour
{
  void Start()
  {
    // 정수
    int gold = 1000;
    gold = gold - 200;

    // 실수
    float intermWeight = 1.3f;
    double Weight = 1.5;

    // 조건 : true(맞다) : 1,  false(틀리다) : 0
    // 문법상 짝 : if, :; (삼항연산자)

    // 문자열 : char (문자 한 자), 문법상 많이 쓰는곳 : Switch case 문
    //          string (여러문자를 사용할 때)
    char itemName1 = 'P';
    string itemName2 = "Potion";


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

using UnityEngine;
public class IfExample2 : MonoBehaviour
{
    bool isBoy = true;
    int playerLove = 60;
    int playerAge = 17;

    void Start() // 모든 코드가 시작하는 부분
    {
        TypeChange();

        ConditionalStatement1(isBoy);
        ConditionalStatement2(isBoy);
        ConditionalStatement3(isBoy);

        ConditionalStatement4(isBoy);
        ConditionalStatement5(playerLove);
        ConditionalStatement6(playerAge);

        ConditionalStatement7(playerAge);
        ConditionalStatement8(playerAge);
        ConditionalStatement9(playerAge);
    }

    void TypeChange()
    {
        /*형변환 && 조건문*/

        // 형변환 캐스팅
        int height = 170;
        float heightDetail = 170.5f;

        // 자동 형변환(읽어버리는 정보가 없음)
        height = (int)heightDetail;

        heightDetail = height;
        Debug.Log("Height: " + height);
        Debug.Log("Height Detail : " + heightDetail);
    }

    void ConditionalStatement1(bool condition)
    {
        /* 조건문 if문 */

        if (condition == true)
        {
            Debug.Log("참 입니다.");
        }

    }

    void ConditionalStatement2(bool condition)
    {
        // if ~ else

        if (condition)
        {
            Debug.Log("참 이라고");
        }
        else
        {
            Debug.Log("거짓 이라고");
        }
    }

    void ConditionalStatement3(bool condition)
    {
        // 관계 연산자
        if (condition != true)
        {
            Debug.Log("거짓 이라고");
        }

        if (condition != false)
        {
            Debug.Log("참 이라고");
        }
    }

    void ConditionalStatement4(bool condition)
    {
        if (condition)
        {
            Debug.Log("이건 참이에요");
        }

        if (!condition)
        {
            Debug.Log("이건 구라에요");
        }
    }

    void ConditionalStatement5(int love)
    {
        if (love < 50)
        {
            Debug.Log("사랑은 이뤄지지 못했습니다.");
        }
        else
        {
            Debug.Log("사랑이 이루어졌어요");
        }
    }

    void ConditionalStatement6(int age)
    {
        if (age >= 61)
        {
            Debug.Log("노동을 할 수 없습니다.");
        }

        if (age < 17)
        {
            Debug.Log("일을 할 수 없을 거에요");
        }
    }

    void ConditionalStatement7(int age)
    {
        // or || 혹은
        //  a || b, a 혹은 b, a or b 둘중 하나라도 참이면 > 참

        if (age >= 60 || age < 17)
        {
            Debug.Log("일을 할 수 없습니다.");
        }
    }

    void ConditionalStatement8(int age)
    {
        // AND && 그리고
        // a && b, a and b, a 그리고 b 2개가 모두 참 > 참
        if (age >= 17 && age < 60)
        {
            Debug.Log("일을 할 수 있습니다.");
        }
    }

    void ConditionalStatement9(int age)
    {
        if (age <= 7)
        {
            Debug.Log("유치원에 가야죠");
        }

        else if (age <= 13) // age > 7 && age <= 13
        {
            Debug.Log("초등학교에 가야죠");
        }

        else if (age <= 16) // age > 13 && age <= 16
        {
            Debug.Log("중학교에 가야죠");
        }

        else if (age <= 19) // age > 16 && age <= 19
        {
            Debug.Log("고등학교에 가야죠");
        }

        else // age > 19
        {
            Debug.Log("대학교에 가요");
        }
    }
}
using UnityEngine;
public class IfExample : MonoBehaviour
{
    public int hp = 0;
    void Start()
    {
        // Ending1(hp);
        // Ending2(hp);
        // Ending3(hp);
    }

    void Ending1(int hp)
    {
        // 1. if문으로 엔딩 나누기

        if (hp > 0)
        {
            Debug.Log("행복하게 살았답니다.");
        }

        if (hp <= 70)
        {
            Debug.Log("경상을 입고 말았답니다.");
        }
    }

    void Ending2(int hp)
    {
        // 2. if ~ else ~

        if (hp > 70)
        {
            Debug.Log("행복하게 살았답니다.");
        }

        else
        {
            Debug.Log("경상을 입고 말았답니다.");
        }
    }

    void Ending3(int hp)
    {
        // 3. if ~ else if ~ else


        if (hp >= 90) // hp가 90보다 큰 경우
        {
            Debug.Log("행복하게 살았답니다.");
        }

        else if (hp > 70)  // hp가 90보다 작지만 70 보다 큰 경우
        {
            Debug.Log("경상을 입고 말았답니다.");
        }

        else // hp가 70보다 작거나 같은 경우
        {
            Debug.Log("중상을 입고 말았어요");
        }
    }


    void RelationalOperator()
    {
        // a < b            a가 b 보다 작다.             a 값이 b값값 보다 작으면 true
        // a <= b           a가 b 보다 작거나 같다.       a 값이 b값 이하면 true
        // a > b            a가 b 보다 크다.              a 값이 b 보다 크면 true
        // a >= b           a가 b 보다 크거나 같다.        a 값이 b 이상이면 true
        // a == b           a가 b와 같다                  a 값이 b값과 같으면 true
        // a != b           a가 b와 같지 않다.            a 값이  b값과 같지 않으면 true
    }
}


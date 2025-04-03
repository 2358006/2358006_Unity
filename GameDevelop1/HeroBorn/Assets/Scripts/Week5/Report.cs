using UnityEngine;
public class Report : MonoBehaviour
{
    bool isShot = false;
    public int luckNumber = 4;
    int index = 0;
    void Start()
    {
        UseFor();
        UseWhile();
        UseDoWhile();
    }

    void UseFor()
    {
        Debug.Log("for 문 사용");
        for (int i = 0; i < luckNumber; i++)
        {
            if (i + 1 == luckNumber)
            {
                Debug.Log("총알에 맞았습니다.");
            }
            else
            {
                Debug.Log("총알에 맞지않았습니다.");
            }
            isShot = true;
        }
    }

    void UseWhile()
    {
        Debug.Log("while 문 사용");
        while (!isShot)
        {
            index += 1;

            if (index == luckNumber)
            {
                Debug.Log("총알에 맞았습니다.");
                isShot = true;
            }
            else
            {
                Debug.Log("총알에 맞지 않았습니다.");
            }
        }
    }

    void UseDoWhile()
    {
        Debug.Log("do while 문 사용");
        do
        {
            index += 1;

            if (index == luckNumber)
            {
                Debug.Log("총알에 맞았습니다.");
                isShot = true;
            }
            else
            {
                Debug.Log("총알에 맞지 않았습니다.");
            }
        } while (!isShot);
    }
}
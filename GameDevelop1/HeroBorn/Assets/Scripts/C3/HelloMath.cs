using UnityEngine;
public class HelloMath : MonoBehaviour
{
  int a = 5;
  int b = 7;
  int sum = 0;

  int i = 1;

  int j = 10;

  void Start() // Start Code
  {
    Addition();
    Subtraction();
    Multiplication();
    DivisionA();
    DivisionB();

    PlusMinusI();

    AddI();
    SubI();


    ElementaryArithmetic();
  }

  void Addition()
  {
    sum = a + b;
    Debug.Log($"{a} + {b} = {sum}"); // 5 + 7 = 12
  }
  void Subtraction()
  {
    sum = a - b;
    Debug.Log($"{a} - {b} = {sum}"); // 5 - 7 = -2
  }
  void Multiplication()
  {
    sum = a * b;
    Debug.Log($"{a} * {b} = {sum}"); // 5 * 7 = 35
  }
  void DivisionA()
  {
    sum = a / b;
    Debug.Log($"{a} / {b} = {sum}"); // 5 / 7 = 0
  }
  void DivisionB()
  {
    sum = b / a;
    Debug.Log($"{b} / {a} = {sum}"); // 7 / 5 = 1 
  }

  void PlusMinusI()
  {
    i = i + 1;
    Debug.Log($"i = {i}"); // i = 2

    i = i - 1;
    Debug.Log($"i = {i}"); // i = 1

    i++;
    Debug.Log($"i = {i}"); // i = 2

    i--;
    Debug.Log($"i = {i}"); // i = 1
  }

  void AddI()
  {
    i = 0;

    Debug.Log($"i = {i++}"); // i = 0
    Debug.Log($"i = {i}"); // i = 1
    Debug.Log($"i = {++i}"); // i = 2
  }
  void SubI()
  {
    i = 10;

    Debug.Log($"i = {i--}"); // i = 10
    Debug.Log($"i = {i}"); // i = 9
    Debug.Log($"i = {--i}"); // i = 8
  }

  void ElementaryArithmetic()
  {

    j += 5;
    Debug.Log($"j = {j}"); // j = 15

    j -= 5;
    Debug.Log($"j = {j}"); // j = 10;

    j *= 5;
    Debug.Log($"j = {j}"); // j =50;

    j /= 5;
    Debug.Log($"j = {j}"); // j = 10;

    j %= 5;
    Debug.Log($"j = {j}"); // j = 0;
  }
}
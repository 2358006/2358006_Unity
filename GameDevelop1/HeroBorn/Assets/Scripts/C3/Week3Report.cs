using UnityEngine;
public class Week3Report : MonoBehaviour
{
  public float a = 0f;
  public float b = 0f;

  void Start()
  {
    Addition(a, b);
    Subtraction(a, b);
    Multiplication(a, b);
    Division(a, b);
    Remainder(a, b);
  }

  void Addition(float input1, float input2)
  {
    Debug.Log($"{input1} + {input2} = {input1 + input2}");
  }
  void Subtraction(float input1, float input2)
  {
    Debug.Log($"{input1} - {input2} = {input1 - input2}");
  }
  void Multiplication(float input1, float input2)
  {
    Debug.Log($"{input1} * {input2} = {input1 * input2}");
  }
  void Division(float input1, float input2)
  {
    Debug.Log($"{input1} / {input2} = {input1 / input2}");
  }
  void Remainder(float input1, float input2)
  {
    Debug.Log($"{(int)input1} % {(int)input2} = {input1 % input2}");
  }
}


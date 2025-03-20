using UnityEngine;
public class HelloFunction : MonoBehaviour
{
  float radius;
  public float sizeOfCicle = 314f;
  void Start()
  {
    // area of ​​a circle =  radius * radius * pi;
    Debug.Log($"s = {sizeOfCicle}");
    Debug.Log($"r = {GetRadius(sizeOfCicle)}");
  }

  float GetRadius(float size)
  {
    float pi = 3.14f;
    float tmp = size / pi;
    float radius = Mathf.Sqrt(size / pi);
    return radius;
  }
}

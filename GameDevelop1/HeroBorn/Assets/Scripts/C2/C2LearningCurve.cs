using UnityEngine;
public class C2LearningCurve : MonoBehaviour
{
  public int currentAge = 30;
  public int addAge = 1;
  void Start()
  {
    /*2-1*/
    Debug.Log(30 + 1);
    Debug.Log(currentAge + 1);

    /*2-2*/
    ComputAge();
  }

  void ComputAge()
  {
    Debug.Log(currentAge + addAge);
  }
}

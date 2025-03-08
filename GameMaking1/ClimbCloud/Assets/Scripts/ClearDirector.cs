using UnityEngine;
using UnityEngine.SceneManagement;
public class ClearDirector : MonoBehaviour
{
  void Update()
  {
    ReStart();
  }
  void ReStart()
  {
    if (Input.GetMouseButtonDown(0))
    {
      SceneManager.LoadScene("GameScene");
    }
  }
}

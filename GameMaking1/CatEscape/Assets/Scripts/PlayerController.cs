using UnityEngine;
public class PlayerController : MonoBehaviour
{
  GameObject gameDirector = null;
  public float move = 0f;

  void Awake()
  {
    gameDirector = GameObject.Find("GameDirector");
  }

  void Update()
  {
    if (gameDirector.GetComponent<GameDirector>().CheckPlay())
    {
      if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x + (-move) > -8)
      {
        Debug.Log("왼쪽으로 움직인다");
        transform.Translate(-move, 0, 0);
      }

      if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x + move < 8)
      {
        Debug.Log("오른쪽으로 움직인다");
        transform.Translate(move, 0, 0);
      }
    }
  }
  public void LButton()
  {
    if (gameDirector.GetComponent<GameDirector>().CheckPlay())
    {
      if (transform.position.x + (-move) > -8)
      {
        Debug.Log("왼쪽으로 움직인다");
        transform.Translate(-move, 0, 0);
      }
    }
  }

  public void RButton()
  {
    if (gameDirector.GetComponent<GameDirector>().CheckPlay())
    {
      if (transform.position.x + move < 8)
      {
        Debug.Log("오른쪽으로 움직인다");
        transform.Translate(move, 0, 0);
      }
    }
  }
}
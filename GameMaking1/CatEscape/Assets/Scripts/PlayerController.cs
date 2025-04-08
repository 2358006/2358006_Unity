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
    Moving();
  }

  void Moving()
  {
    if (gameDirector.GetComponent<GameDirector>().IsPlaying())
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

  #region  Button
  public void LButton()
  {
    if (gameDirector.GetComponent<GameDirector>().IsPlaying())
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
    if (gameDirector.GetComponent<GameDirector>().IsPlaying())
    {
      if (transform.position.x + move < 8)
      {
        Debug.Log("오른쪽으로 움직인다");
        transform.Translate(move, 0, 0);
      }
    }
  }
  #endregion
}
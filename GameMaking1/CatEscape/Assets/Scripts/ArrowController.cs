using UnityEngine;
public class ArrowController : MonoBehaviour
{
  GameObject player = null;
  GameObject gameDirector = null;

  Vector2 arrowVector = Vector2.zero;
  Vector2 playerVector = Vector2.zero;
  Vector2 arrowPlayerDir = Vector2.zero;

  float arrowRadius = 0.5f;
  float playerRadius = 1.0f;
  float arrowPlayerDistance = 0f;

  void Awake()
  {
    this.player = GameObject.Find("Player");
    gameDirector = GameObject.Find("GameDirector");
  }

  void FixedUpdate()
  {
    if (gameDirector.GetComponent<GameDirector>().GameOver())
    {
      gameObject.SetActive(false);
    }
    else
    {
      transform.Translate(0, -0.1f, 0);
      if (transform.position.y < -5f)
      {
        Debug.Log("화살의 내구도가 0이 되었습니다.");
        Destroy(gameObject);
      }

      arrowVector = transform.position;
      playerVector = this.player.transform.position;
      arrowPlayerDir = arrowVector - playerVector;

      arrowPlayerDistance = arrowPlayerDir.magnitude;

      if ((arrowRadius + playerRadius) > arrowPlayerDistance)
      {
        Debug.Log("화살에 맞았어요");
        gameDirector.GetComponent<GameDirector>().DecreaseHp();
        Destroy(gameObject);
      }
    }
  }
}

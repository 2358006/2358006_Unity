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
    if (gameDirector.GetComponent<GameDirector>().CheckPlay())
    {

      MoveArrow();
    }
    else
    {
      gameObject.SetActive(false);
    }
  }

  void MoveArrow()
  {
    transform.Translate(0, -0.1f, 0);
    if (transform.position.y < -5f)
    {
      Debug.Log("아이템이 땅에 떨어졌습니다.");
      Destroy(gameObject);
    }

    arrowVector = transform.position;
    playerVector = this.player.transform.position;
    arrowPlayerDir = arrowVector - playerVector;

    arrowPlayerDistance = arrowPlayerDir.magnitude;

    if ((arrowRadius + playerRadius) > arrowPlayerDistance)
    {
      Debug.Log("플레이어와 충돌하였습니다.");
      gameDirector.GetComponent<GameDirector>().DecreaseHp();
      Destroy(gameObject);
    }
  }
}
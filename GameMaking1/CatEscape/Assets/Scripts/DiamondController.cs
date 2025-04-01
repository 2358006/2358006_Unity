using UnityEngine;
public class DiamondController : MonoBehaviour
{
  GameObject player = null;
  GameObject gameDirector = null;

  Vector2 diamondVector = Vector2.zero;
  Vector2 playerVector = Vector2.zero;
  Vector2 diamondPlayerDir = Vector2.zero;

  float diamondRadius = 0.5f;
  float playerRadius = 1.0f;
  float diamondPlayerDistance = 0f;

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
      MoveDIA();
    }
  }

  void MoveDIA()
  {
    transform.Translate(0, -0.1f, 0);
    if (transform.position.y < -5f)
    {
      Debug.Log("다이아몬드가 작살났습니다.");
      Destroy(gameObject);
    }

    diamondVector = transform.position;
    playerVector = this.player.transform.position;
    diamondPlayerDir = diamondVector - playerVector;

    diamondPlayerDistance = diamondPlayerDir.magnitude;

    if ((diamondRadius + playerRadius) > diamondPlayerDistance)
    {
      Debug.Log("다이아몬드 득");
      gameDirector.GetComponent<GameDirector>().IncreaseScoreDIA();
      Destroy(gameObject);
    }
  }
}
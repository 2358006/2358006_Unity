using UnityEngine;
public class ItemController : MonoBehaviour
{
  GameObject player = null;
  GameObject gameDirector = null;

  Vector2 itemVector = Vector2.zero;
  Vector2 playerVector = Vector2.zero;
  Vector2 itemPlayerDir = Vector2.zero;

  float itemRadius = 0.5f;
  float playerRadius = 1.0f;
  float itemPlayerDistance = 0f;

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
        Debug.Log("다이아몬드가 작살났습니다.");
        Destroy(gameObject);
      }

      itemVector = transform.position;
      playerVector = this.player.transform.position;
      itemPlayerDir = itemVector - playerVector;

      itemPlayerDistance = itemPlayerDir.magnitude;

      if ((itemRadius + playerRadius) > itemPlayerDistance)
      {
        Debug.Log("다이아몬드 득");
        gameDirector.GetComponent<GameDirector>().IncreaseFever();
        Destroy(gameObject);
      }
    }
  }
}

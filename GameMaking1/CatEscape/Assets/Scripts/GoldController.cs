using UnityEngine;
public class GoldController : MonoBehaviour
{
  GameObject player = null;
  GameObject gameDirector = null;

  Vector2 goldVector = Vector2.zero;
  Vector2 playerVector = Vector2.zero;
  Vector2 goldPlayerDir = Vector2.zero;

  float goldRadius = 0.5f;
  float playerRadius = 1.0f;
  float goldPlayerDistance = 0f;

  void Awake()
  {
    this.player = GameObject.Find("Player");
    gameDirector = GameObject.Find("GameDirector");
  }

  void FixedUpdate()
  {
    MoveGold();
  }
  void MoveGold()
  {
    if (gameDirector.GetComponent<GameDirector>().IsPlaying())
    {
      transform.Translate(0, -0.1f, 0);
      if (transform.position.y < -5f)
      {
        Debug.Log("금괴가 작살났습니다.");
        Destroy(gameObject);
      }

      goldVector = transform.position;
      playerVector = this.player.transform.position;
      goldPlayerDir = goldVector - playerVector;

      goldPlayerDistance = goldPlayerDir.magnitude;

      if ((goldRadius + playerRadius) > goldPlayerDistance)
      {
        Debug.Log("금괴 득");
        gameDirector.GetComponent<GameDirector>().IncreaseScoreGOLD();
        Destroy(gameObject);
      }
    }
    else
    {
      gameObject.SetActive(false);
    }
  }
}
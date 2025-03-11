using UnityEngine;
public class ArrowGenerator : MonoBehaviour
{
  GameObject gameDirector = null;
  public GameObject arrowPrefab = null;

  GameObject arrowInstance = null;
  int arrowPositionRange = 0;

  float arrowSpawn = 1.0f;
  float deltaTime = 0.0f;

  void Awake()
  {
    gameDirector = GameObject.Find("GameDirector");
  }

  void Update()
  {
    if (gameDirector.GetComponent<GameDirector>().GameOver())
    {
      gameObject.SetActive(false);
    }
    else
    {
      this.deltaTime += Time.deltaTime;

      if (deltaTime > arrowSpawn)
      {
        deltaTime = 0f;
        arrowInstance = Instantiate(arrowPrefab);
        arrowPositionRange = Random.Range(-6, 7);

        arrowInstance.transform.position = new(arrowPositionRange, 7, 0);
      }
    }
  }
}

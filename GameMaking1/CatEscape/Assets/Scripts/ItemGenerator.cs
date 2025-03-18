using UnityEngine;
public class ItemGenerator : MonoBehaviour
{
  GameObject gameDirector = null;
  public GameObject[] itemPrefab = { null, };

  GameObject itemInstance = null;
  float itemPositionRange = 0;

  float itemSpawn = 1f;
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

      if (deltaTime > itemSpawn)
      {
        deltaTime = 0f;
        itemInstance = Instantiate(itemPrefab[Random.Range(0, itemPrefab.Length)]);
        itemPositionRange = Random.Range(-6f, 7f);
        itemInstance.transform.position = new(itemPositionRange, 7, 0);
      }
    }
  }
}

using UnityEngine;
public class ItemGenerator : MonoBehaviour
{
  GameObject gameDirector = null;
  public GameObject[] itemPrefab = { null, };

  GameObject itemInstance = null;
  float itemPositionRange = 0;

  float itemSpawn = 1f;
  public float spawnMin = 0f;
  float deltaTime = 0.0f;

  int nowScore = 0;
  int scorePer100 = 0;

  void Awake()
  {
    gameDirector = GameObject.Find("GameDirector");
  }

  void Update()
  {
    ItemSpawn();
  }

  void ItemSpawn()
  {
    if (gameDirector.GetComponent<GameDirector>().CheckPlay())
    {
      Debug.Log("게임 시작");
      ItemGenerate(Timing());
    }
    else
    {
      Debug.Log("게임 끝");
    }
  }

  void ItemGenerate(float spawnTime)
  {
    this.deltaTime += Time.deltaTime;

    if (deltaTime > spawnTime)
    {
      deltaTime = 0f;
      itemInstance = Instantiate(itemPrefab[Random.Range(0, itemPrefab.Length)]);
      itemPositionRange = Random.Range(-6f, 7f);
      itemInstance.transform.position = new(itemPositionRange, 7, 0);
    }
  }

  float Timing()
  {
    this.nowScore = gameDirector.GetComponent<GameDirector>().score;

    if ((this.nowScore - scorePer100 * 100) == 100 && itemSpawn > spawnMin)
    {
      itemSpawn *= 0.8f;
      scorePer100++;
    }

    Debug.Log($"속도 : {itemSpawn}");
    return itemSpawn;
  }
}
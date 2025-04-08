using UnityEngine;
public class ItemGenerator : MonoBehaviour
{
  GameObject gameDirector = null;
  public GameObject[] itemPrefab = { null, };

  GameObject itemInstance = null;
  float itemPositionRange = 0;

  public float itemSpawn = 1f;
  public float spawnMin = 0f;
  float deltaTime = 0.0f;

  int goldPer100 = 0;
  float score = 0;
  void Awake()
  {
    gameDirector = GameObject.Find("GameDirector");
  }

  void Start()
  {
    score = gameDirector.GetComponent<GameDirector>().score;
  }

  void Update()
  {
    //게임 시작 후 10초 마다 화살 생성 쿨타임을 줄임
    if (gameDirector.GetComponent<GameDirector>().score - scorePer100 >= 100 && itemSpawn >= spawnMin)
    {
      itemSpawn *= 0.8f;
      scorePer100 += 100;
      Debug.Log($"속도 : {itemSpawn}");
    }
    if (gameDirector.GetComponent<GameDirector>().IsPlaying())
    {
      ItemGenerate();
    }
  }

  void ItemGenerate()
  {
    Debug.Log("게임 시작");
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
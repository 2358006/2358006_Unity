using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class GameDirector : MonoBehaviour
{
  [Header("Money")]
  public TMP_Text moneyText = null;
  public int goldPoint = 0;
  public int diaPoint = 0;
  public int money = 0;

  [Header("Score")]
  public TMP_Text scoreText = null;
  public float score = 0f;

  GameObject hpGauge = null;

  GameObject gameOver = null;
  GameObject reStart = null;

  GameObject gameStart = null;
  GameObject start = null;

  GameObject itemGenerator = null;

  void Awake()
  {
    this.moneyText.text = $"Money : {money}";

    this.scoreText.text = $"Score : {score}";

    this.hpGauge = GameObject.Find("HpGauge");

    gameOver = GameObject.Find("GameOver");
    reStart = GameObject.Find("ReStart");

    gameStart = GameObject.Find("GameStart");
    start = GameObject.Find("Start");

    itemGenerator = GameObject.Find("ItemGenerator");
  }

  void Start()
  {
    gameOver.SetActive(false);
    reStart.SetActive(false);
    itemGenerator.SetActive(false);
  }

  void Update()
  {
    GetScore();
#if UNITY_EDITOR
    GameOverTest();
    ScoreTest();
    MoneyTest();
#endif
  }

  #region GameDirector
  void GetScore()
  {
    if (IsPlaying())
    {
      score += Time.deltaTime;
    }
    this.scoreText.text = $"Score : {score}";
  }

  public void DecreaseHp()
  {
    this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    Debug.Log("현재 체력 : " + hpGauge.GetComponent<Image>().fillAmount);
    IsPlaying();
  }

  public void IncreaseMoneyDIA()
  {
    money += diaPoint;
    this.moneyText.text = $"Money : {money}";
    Debug.Log($"Money : {money}");
  }

  public void IncreaseMoneyGOLD()
  {
    money += goldPoint;
    this.moneyText.text = $"Money : {money}";
    Debug.Log($"Money : {money}");
  }

  public bool IsPlaying()
  {
    if (this.hpGauge.GetComponent<Image>().fillAmount == 0f)
    {
      GameOver();
      return false;
    }
    else if (!itemGenerator.activeSelf)
    {
      return false;
    }
    else
    {
      return true;
    }
  }

  void GameOver()
  {
    gameOver.SetActive(true);
    reStart.SetActive(true);
    itemGenerator.SetActive(false);
  }
  #endregion

  #region Button
  public void GameStart()
  {
    gameStart.SetActive(false);
    start.SetActive(false);
    itemGenerator.SetActive(true);
  }

  public void ReStart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    Time.timeScale = 1f;
  }
  #endregion

  #region TestCode
  void GameOverTest()
  {
    if (Input.GetKeyDown(KeyCode.Q))
    {
      this.hpGauge.GetComponent<Image>().fillAmount = 0;
    }
  }

  void ScoreTest()
  {
    if (Input.GetKeyDown(KeyCode.W))
    {
      score += 100f;
    }
  }

  void MoneyTest()
  {
    if (Input.GetKeyDown(KeyCode.E))
    {
      money += 100;
      this.moneyText.text = $"Money : {money}";
    }
  }
  #endregion
}
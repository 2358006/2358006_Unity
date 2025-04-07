using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class GameDirector : MonoBehaviour
{
  public TMP_Text scoreText = null;
  public int goldPoint = 0;
  public int diaPoint = 0;
  public int score = 0;

  GameObject hpGauge = null;

  GameObject gameOver = null;
  GameObject reStart = null;

  GameObject gameStart = null;
  GameObject start = null;
  GameObject itemGenerator = null;

  void Awake()
  {
    this.hpGauge = GameObject.Find("HpGauge");

    this.scoreText.text = "Score : " + score;

    reStart = GameObject.Find("ReStart");
    gameOver = GameObject.Find("GameOver");

    start = GameObject.Find("Start");
    gameStart = GameObject.Find("GameStart");
    itemGenerator = GameObject.Find("ItemGenerator");
  }

  void Start()
  {
    reStart.SetActive(false);
    gameOver.SetActive(false);
    itemGenerator.SetActive(false);
  }

  void Update()
  {
    GameOverTest();
    ScoreTest();
  }

  #region GameDirector
  public void DecreaseHp()
  {
    this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    Debug.Log("현재 체력 : " + hpGauge.GetComponent<Image>().fillAmount);
    CheckPlay();
  }

  public void IncreaseScoreDIA()
  {
    score += diaPoint;
    this.scoreText.text = "Score : " + score;
    Debug.Log("점수 : " + score);
  }

  public void IncreaseScoreGOLD()
  {
    score += goldPoint;
    this.scoreText.text = "Score : " + score;
    Debug.Log("점수 : " + score);
  }
  public bool CheckPlay()
  {
    if (this.hpGauge.GetComponent<Image>().fillAmount == 0f)
    {
      GameOver();
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
      score += 100;
      this.scoreText.text = "Score : " + score;
    }
  }
  #endregion
}
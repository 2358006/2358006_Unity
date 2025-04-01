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

  void Awake()
  {
    this.hpGauge = GameObject.Find("HpGauge");

    this.scoreText.text = "Score : " + score;

    reStart = GameObject.Find("ReStart");
    gameOver = GameObject.Find("GameOver");

    start = GameObject.Find("Start");
    gameStart = GameObject.Find("GameStart");
  }

  void Start()
  {
    reStart.SetActive(false);
    gameOver.SetActive(false);
  }

  void Update()
  {
    ScoreTest();
  }

  public void DecreaseHp()
  {
    this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;

    if (this.hpGauge.GetComponent<Image>().fillAmount == 0)
    {
      GameOver();
    }

    Debug.Log("현재 체력 : " + hpGauge.GetComponent<Image>().fillAmount);
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

  void ScoreTest()
  {
    if (Input.GetKeyDown(KeyCode.W))
    {
      score += 100;
      this.scoreText.text = "Score : " + score;
    }
  }

  public void StartButton()
  {
    gameStart.SetActive(false);
    start.SetActive(false);
  }

  public bool GameOver()
  {
    if (this.hpGauge.GetComponent<Image>().fillAmount == 0f || Input.GetKeyDown(KeyCode.Space))
    {
      gameOver.SetActive(true);
      reStart.SetActive(true);
      return true;
    }
    return false;
  }

  public bool GameStart()
  {
    if (gameStart.activeSelf && start.activeSelf)
    {
      return true;
    }
    return false;
  }

  public void ReStart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    Time.timeScale = 1f;
  }
}
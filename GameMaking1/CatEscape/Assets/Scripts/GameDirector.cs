using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class GameDirector : MonoBehaviour
{
  public TMP_Text scoreText = null;
  public int score = 0;

  GameObject gameOver = null;
  GameObject hpGauge = null;
  GameObject reStart = null;

  void Awake()
  {
    this.hpGauge = GameObject.Find("HpGauge");

    this.scoreText.text = "Score : " + score;

    reStart = GameObject.Find("ReStart");
    gameOver = GameObject.Find("GameOver");
  }
  void Start()
  {
    reStart.SetActive(false);
    gameOver.SetActive(false);
  }

  void Update()
  {
    GameOver();
  }

  public void DecreaseHp()
  {
    this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    Debug.Log("현재 체력 : " + hpGauge.GetComponent<Image>().fillAmount);
  }

  public void IncreaseScore()
  {
    score += 10;
    this.scoreText.text = "Score : " + score;
    Debug.Log("점수 : " + score);
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

  public void ReStart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    Time.timeScale = 1f;
  }
}
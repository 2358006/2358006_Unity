using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{
  GameObject hpGauge = null;
  GameObject gameOver = null;
  GameObject reStart = null;
  void Awake()
  {
    this.hpGauge = GameObject.Find("HpGauge");
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
  }

  public bool GameOver()
  {
    if (this.hpGauge.GetComponent<Image>().fillAmount == 0f)
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
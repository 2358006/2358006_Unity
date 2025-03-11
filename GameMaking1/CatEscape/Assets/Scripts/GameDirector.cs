using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{
  GameObject hpGauge = null;
  GameObject feverGauge = null;
  GameObject gameOver = null;
  GameObject reStart = null;

  void Awake()
  {
    this.hpGauge = GameObject.Find("HpGauge");
    this.feverGauge = GameObject.Find("FeverGauge");
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
    if (!FeverCheck())
    {
      this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
      Debug.Log("현재 체력 : " + hpGauge.GetComponent<Image>().fillAmount);
    }
    else
    {
      Debug.Log("피버 작동중, 현재 체력 : " + hpGauge.GetComponent<Image>().fillAmount);
    }
  }

  public void IncreaseFever()
  {
    this.feverGauge.GetComponent<Image>().fillAmount += 0.2f;
  }

  // 피버 차면 피버 작동
  bool FeverCheck()
  {
    if (this.feverGauge.GetComponent<Image>().fillAmount == 1f)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  void Fever()
  {
    if (FeverCheck())
    {
      Invoke("FeverOff", 3f);
    }
  }

  void FeverOff()
  {
    this.feverGauge.GetComponent<Image>().fillAmount = 0f;
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
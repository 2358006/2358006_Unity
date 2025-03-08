using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
  Rigidbody2D rigid2D = null;
  Animator animator = null;
  float jumpForce = 680.0f;

  [Header("Max Speed")]
  public float maxWalkSpeed = 2f;
  float walkForce = 30f;
  float walkSpeed = 0f;
  void Awake()
  {
    this.rigid2D = GetComponent<Rigidbody2D>();
    this.animator = GetComponent<Animator>();
  }

  void Update()
  {
    Walk();
    Jump();
    ReSpawn();

  }

  void Walk()
  {
    walkSpeed = Mathf.Abs(this.rigid2D.linearVelocity.x);

    if (walkSpeed < maxWalkSpeed)
    {
      Debug.Log("현재 속도 : " + walkSpeed);
      this.rigid2D.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * this.walkForce);
    }

    if (Input.GetAxisRaw("Horizontal") != 0)
    {
      transform.localScale = new Vector3(Input.GetAxisRaw("Horizontal"), 1, 1);
    }
  }

  void Jump()
  {
    if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.linearVelocity.y == 0)
    {
      Debug.Log("번저점프");
      this.animator.SetTrigger("JumpTrigger");
      this.rigid2D.AddForce(transform.up * this.jumpForce);
    }
  }

  void Animator()
  {
    if (this.rigid2D.linearVelocity.y == 0)
    {
      this.animator.speed = walkSpeed / 2f;
    }
    else
    {
      this.animator.speed = 1f;
    }
  }


  void ReSpawn()
  {
    if (transform.position.y < -10)
    {
      SceneManager.LoadScene("GameScene");
    }
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    Debug.Log("골");
    SceneManager.LoadScene("ClearScene");
  }
}
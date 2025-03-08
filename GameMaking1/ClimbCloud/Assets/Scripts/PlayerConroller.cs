using UnityEngine;
public class PlayerConroller : MonoBehaviour
{
  Rigidbody2D rigid2D = null;

  [Header("Walk & Jump")]
  public float jumpForce = 680.0f;
  public float walkForce = 30f;
  public float maxWalkSpeed = 2f;

  float walkSpeed = 0f;

  void Awake()
  {
    this.rigid2D = GetComponent<Rigidbody2D>();
  }


  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      Debug.Log("번저점프");
      this.rigid2D.AddForce(transform.up * this.jumpForce);
    }
    if (walkSpeed < this.maxWalkSpeed)
    {
      this.rigid2D.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * this.walkForce);
    }

    if (Input.GetAxisRaw("Horizontal") != 0f)
    {
      transform.localScale = new Vector3(Input.GetAxisRaw("Horizontal"), 1, 1);
    }
  }
}
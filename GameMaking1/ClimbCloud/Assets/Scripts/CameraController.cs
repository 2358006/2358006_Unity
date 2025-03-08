using UnityEngine;
public class CameraController : MonoBehaviour
{
  GameObject player = null;
  Vector3 playerPos = Vector3.zero;
  void Awake()
  {
    this.player = GameObject.Find("Cat");
  }

  void Update()
  {
    playerPos = this.player.transform.position;
    transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
  }
}

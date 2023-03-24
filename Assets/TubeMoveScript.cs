using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeMoveScript : MonoBehaviour
{
  public float frameSpeed = 5;
  public float deadPixels = -40;

  // Start is called before the first frame update
  void Start()
  {
      
  }

  // Update is called once per frame
  void Update()
  {
    transform.position = transform.position + (Vector3.left * frameSpeed) * Time.deltaTime;

    if (transform.position.x < deadPixels) {
      Debug.Log("Tube Deleted!");
      Destroy(gameObject);
    }
  }
}

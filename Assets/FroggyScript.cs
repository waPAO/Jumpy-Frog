using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FroggyScript : MonoBehaviour
{
  public Rigidbody2D myRigidbody;
  public float hopPower;
  public GameLogic logic;
  public bool froggyAlive = true;

  // Start is called before the first frame update
  void Start()
  {
    logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
    logic.updateHighScore();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space) && froggyAlive) {
      myRigidbody.velocity = Vector2.up * hopPower;
    }
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    logic.gameOver();
    froggyAlive = false;
  }
}

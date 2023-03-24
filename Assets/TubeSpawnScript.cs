using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeSpawnScript : MonoBehaviour
{
  public GameObject tube;
  public float rateOfSpawns = 3;
  public float  heightConstant = 10;
  private float timer = 0;
  

  // Start is called before the first frame update
  void Start()
  {
    spawnTube();
  }

  // Update is called once per frame
  void Update()
  {
    if (timer < rateOfSpawns) {
      timer += Time.deltaTime;
    } 
    else {
      spawnTube();
      timer = 0;
    }
  }

  void spawnTube()
  {
    float floor = transform.position.y - heightConstant;
    float ceiling = transform.position.y + heightConstant;
    Instantiate(tube, new Vector3(transform.position.x, Random.Range(floor, ceiling), 0), transform.rotation);
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectorscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        /*  transform.Translate(-0.05F, 0F, 0F);
          var X = transform.position;
          if (X.x < -20)
          {
              transform.Translate(40, Random.Range(-5.0f, 5.0f), 0F);
          }
          if (X.y < -5)
          {
              transform.Translate(0F,0.1F, 0F);
          }
          if (X.y > 5)
          {
              transform.Translate(0F, -0.1F, 0F);
          }
          // var player = GameObject.Find("Player");
          // if (X == player.transform.position)
          //  {
          //    Destroy(this);
          //  }
      */
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            floorscript.speed++;
            Destroy(gameObject);
        }
    }
}



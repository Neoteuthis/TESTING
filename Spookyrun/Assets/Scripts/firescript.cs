using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firescript : MonoBehaviour {
public SpriteRenderer firesprite;
	// Use this for initialization
	void Start () {
     firesprite = gameObject.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
      //  firesprite.flipX = true;
       // Invoke("DoSomething", 2);
        //firesprite.flipX = false;
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            floorscript.speed--;
        }
        if (collision.gameObject.tag == "Water")
        {
            Destroy(gameObject);
        }
    }
}

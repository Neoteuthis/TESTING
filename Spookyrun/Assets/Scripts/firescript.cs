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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            
            Debug.Log("HIT!");
        }
        if (collision.gameObject.tag == "Water")
        {
            Destroy(gameObject);
        }
    }
}

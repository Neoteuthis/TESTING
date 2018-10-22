using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class firescript : MonoBehaviour {
public SpriteRenderer firesprite;
   // public GameObject plays;
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
            floorscript.speed = 1;
            if (playerscript.score > playerscript.highscore)
            {
                playerscript.highscore = playerscript.score;
            }
            playerscript.score = 0;
            SceneManager.LoadScene("SampleScene");
        }
        if (collision.gameObject.tag == "Water")
        {
            Destroy(gameObject);
        }
    }
}

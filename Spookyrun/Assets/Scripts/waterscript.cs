using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterscript : MonoBehaviour {
  //  private GameObject playerObj = null;

    // Use this for initialization
    void Start () {
      //  playerObj = FindObjectOfType<playerscript>().gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.S))
        {
            //  gameObject.transform = playerObj.transform;
           
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fire")
        {
            Destroy(gameObject);
        }
    }
}

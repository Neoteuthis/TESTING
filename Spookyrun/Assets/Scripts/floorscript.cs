using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorscript : MonoBehaviour
{
    public bool isRoom = false;
    public static float speed = 0;
    public Vector2 Dir = new Vector2(00.1F, 0f);
    // Use this for initialization
    public bool isBackground = false;
    //isActive can be used for an object pool
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        var X = transform.position;
       // var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        transform.Translate(Dir*speed);
        //respawn
         if(isRoom == true) {
            if (X.x < -100)
            {
                Destroy(gameObject);
              ///  transform.Translate(80F, 0F, 0F);
            }
        }
        else if (X.x < -20)
        {
            {
                transform.Translate(Random.Range(40f,40f), 0F, 0F);
                //set y value to 1 of 3 levels to randomize platform or place this code into larger levels
            }
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        // If a missile hits this object
        if (coll.transform.tag == "Player")
        {
           // Debug.Log("HIT!");
        }
    }
}

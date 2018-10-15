using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorscript : MonoBehaviour
{
    public static float speed = 1;
    public Vector2 Dir = new Vector2(00.1F, 0f);
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        var X = transform.position;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        transform.Translate(Dir*speed);
        if (X.x < -20)
        {
            transform.Translate(40F, 0F, 0F);
            //destroy later after spawner works
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        // If a missile hits this object
        if (coll.transform.tag == "Player")
        {
            Debug.Log("HIT!");
        }
    }
}

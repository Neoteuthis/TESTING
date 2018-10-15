using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour {
    public float speed = 0;
    public SpriteRenderer playersprite;
       private Rigidbody2D pbody;
	// Use this for initialization
	void Start () {
       pbody = GetComponent<Rigidbody2D>();
        playersprite = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        var jumptime = 5;
         float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

    pbody.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (jumptime > 0)
            {
                transform.Translate(0F, 1F, 0F);
                jumptime--;
            }
            else
            {
                jumptime = 5;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
           // transform.Rotate(0F, 0F, -15F);
         
        transform.Translate(1F, 0F, 0F);
            playersprite.flipX = false;
        }
       if (Input.GetKeyDown(KeyCode.A))
        {
            //  transform.Rotate(0F, 0F, 15F);
              transform.Translate(-1F, 0F, 0F);
            playersprite.flipX = true;
        }
        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
         }
    }
}
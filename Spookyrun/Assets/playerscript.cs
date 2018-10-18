using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour {
    public float speed = 0;
    public Vector2 Dir = new Vector2(00.1F, 0f);
    public Vector2 FinalDir = new Vector2(00.1F, 0f);
    private float Timer1 = 0;
    public SpriteRenderer playersprite;
    private Rigidbody2D pbody;
    public float jumptime = 5;
	// Use this for initialization
	void Start () {
       pbody = GetComponent<Rigidbody2D>();
       playersprite = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
      
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        FinalDir = Dir * floorscript.speed;
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        pbody.AddForce(movement * speed);

        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(Vector2.up * 60 * Time.deltaTime, Space.World);
           /* if (jumptime > 0)
            {
                transform.Translate(0F, 2F, 0F);
                jumptime--;
            }
            else
            {
                jumptime = 5;
            }*/
        }
        if (Input.GetKey(KeyCode.D))
        {
           // transform.Rotate(0F, 0F, -15F);
         
            transform.Translate(0.15F*FinalDir);
            //playersprite.flipX = false;
        }
       if (Input.GetKey(KeyCode.A))
        {
            //  transform.Rotate(0F, 0F, 15F);
            transform.Translate(0.15F*FinalDir);
            //playersprite.flipX = true;
        }
        if (Input.GetKey("space"))
        {
            transform.Translate(Vector2.up * 20* Time.deltaTime, Space.World);
         }
    }
    int timer1 = 0;
}


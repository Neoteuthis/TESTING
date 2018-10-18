﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playerscript : MonoBehaviour {
    public float speed = floorscript.speed;
    public Vector2 Dir = new Vector2(00.1F, 0f);
    public Vector2 FinalDir = new Vector2(00.1F, 0f);
    public SpriteRenderer playersprite;
    private Rigidbody2D pbody;
    public float jumptime = 5;
    //collectables
    public static int waterlevel = 0;
    public static int shrooms = 0;
    //functionvars
    public int Timer1 = 0;
    public bool highjump = true;
    // Use this for initialization
    void Start() {
        // int Timer = 0;
        pbody = GetComponent<Rigidbody2D>();
        playersprite = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {
        var X = transform.position;
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        FinalDir = Dir * floorscript.speed;
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //testing
        // pbody.AddForce(movement * speed);
        if(X.y < -7)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (shrooms > 0 && highjump == true)
            {
                shrooms--;
                Timer1 = 100;
                highjump = false;
            }
            if (Timer1 > 0)
            {
                transform.Translate(Vector2.up * 60 * Time.deltaTime, Space.World);
            } else
            {
                highjump = true;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
           // transform.Rotate(0F, 0F, -15F);
         
            transform.Translate(0.15F*FinalDir);
            playersprite.flipX = false;
        }
       if (Input.GetKey(KeyCode.A))
        {
            //  transform.Rotate(0F, 0F, 15F);
            transform.Translate(-0.15F*FinalDir);
            playersprite.flipX = true;
        }
        if (Input.GetKey("space"))
        {
            transform.Translate(Vector2.up * 20* Time.deltaTime, Space.World);
        }
        Timer1--;
    }
}
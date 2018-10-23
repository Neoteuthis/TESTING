using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerscript : MonoBehaviour {

    public Vector2 Dir = new Vector2(00.1F, 0f);
    public Vector2 FinalDir = new Vector2(00.1F, 0f);
    //spriteactions
    public SpriteRenderer playersprite;
    public Sprite mySprite;
    public Sprite mynormalsprite;
    //collectables
    public static int waterlevel = 0;
    public static int shrooms = 0;
    public static int score = 0;
    public static int highscore;
    public static int HP = 10;
    private GameObject waterObj = null;
    //sounds
    public AudioClip shootSound;
    public AudioClip jumpSound;
    public AudioClip superjumpsound;
    private AudioSource source;
    //functionvars
    public int Timer1 = 0;
    public int Timer2 = 0;
    public bool highjump = true;
    public bool jumping = true;
    public bool spitting = true;
    public float jumptime = 5;

    // Use this for initialization
    void Start() {
     playersprite = gameObject.GetComponent<SpriteRenderer>();
        waterObj = FindObjectOfType<waterscript>().gameObject;
        //mySprite = "spookyrunplayerpew";
}

    // Update is called once per frame
    void Update() {
        var X = transform.position;
        float moveHorizontal = Input.GetAxis("Horizontal");
       // return;
        float moveVertical = Input.GetAxis("Vertical");
        FinalDir = Dir * floorscript.speed;
       
        //characterDeath
        if(X.y < -7 || X.x < -20)
        {
            floorscript.speed = 1;
            if(score > highscore)
            {
                highscore = score;
            }
            score = 0;
            waterlevel = 0;
            shrooms = 0;
            summonscript.spawnnow = true;
            summonscript.countdown = 3;
            SceneManager.LoadScene("SampleScene");
        }
        //CONTROLS
        if (Input.GetKey(KeyCode.W))
        {
            if (shrooms > 0 && highjump == true)
            {
                shrooms--;
                Timer1 = 100;
                highjump = false;
                source.PlayOneShot(superjumpsound);
            }
            if (Timer1 > 0 && X.y> -10)
            {
                transform.Translate(Vector2.up * 60 * Time.deltaTime, Space.World);
            } else
            {
                highjump = true;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.15F*FinalDir);
            playersprite.flipX = false;

        }
       if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.15F*FinalDir);
            playersprite.flipX = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<SpriteRenderer>().sprite = mynormalsprite;
            if (waterlevel > 0 && spitting == true)
            {
                waterlevel--;
                Timer2 = 10;
                spitting = false;
                source.PlayOneShot(shootSound);
            }
            if (Timer2 > 0)
            {
                waterObj.transform.position = gameObject.transform.position;
              
                //change sprite
                this.GetComponent<SpriteRenderer>().sprite = mySprite;
                // playersprite;
            }
            else
            {
                //change sprite back
                this.GetComponent<SpriteRenderer>().sprite = mynormalsprite;
                spitting = true;
            }
        }
        if (Input.GetKey("space"))
        {
            transform.Translate(Vector2.up * 20* Time.deltaTime, Space.World);
            this.GetComponent<SpriteRenderer>().sprite = mynormalsprite;
        }
        if (Input.GetKeyDown("space"))
        {
            //source.PlayOneShot(jumpSound);
        }
        if (jumping)
            Timer1--;
        Timer2--;
        score+= Mathf.RoundToInt(floorscript.speed);
    }
    void Awake()
    {

        source = GetComponent<AudioSource>();
    }
}
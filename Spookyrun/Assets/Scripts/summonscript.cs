using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonscript : MonoBehaviour {
    public levelmanager mything;
    public static bool spawnnow = true;
    public static int countdown = 3;
	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnnow == true)
        {
            mything.spawnNewRoom();
            spawnnow = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonscript : MonoBehaviour {
    public levelmanager mything;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
       mything.spawnNewRoom();
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}

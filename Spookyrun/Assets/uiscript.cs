using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiscript : MonoBehaviour {
    public bool iswater;
    public bool isspring;
    int water = playerscript.waterlevel;
    int springs = playerscript.shrooms;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Change(float f)
    {
        //GetComponent<Text>().text = f.ToString();
    }
}

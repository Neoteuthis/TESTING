using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilecontroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-0.05F, 0F, 0F);
        var X = transform.position;
        if (X.x < -20)
        {
            transform.Translate(40, 0F, 0F);
        }
    }
}

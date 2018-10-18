using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var X = transform.position;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * -6.0f;
        //use the line below for bonus marks! true:false condition
      //  string mygame = (x > z) ? "noot" : "moot";
      //  transform.Rotate(0, x, 0);
        transform.Translate(z, 0, 0);
        if (X.y < -5)
        {
            transform.Translate(-0.1F, 0F, 0F);
        }
        if (X.y > 5)
        {
            transform.Translate(0.1F, 0F, 0F);
        }

    }
void OnCollisionEnter(Collision col)
{
    if (col.gameObject.name == "Floor")
    {
        Destroy(col.gameObject);
    }
}
}
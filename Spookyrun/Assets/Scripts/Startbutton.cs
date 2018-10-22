using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startbutton : MonoBehaviour {

    public GameObject ToDestroy;

	public void Clicked()
    {
        floorscript.speed = 1;
        Destroy(ToDestroy);
        Destroy(gameObject);
    }
}

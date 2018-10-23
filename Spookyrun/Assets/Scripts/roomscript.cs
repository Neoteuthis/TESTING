using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomscript : MonoBehaviour
{
    bool causespawn = true;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var X = transform.position;
       // var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        if (X.x < -10 && causespawn == true)
        {
            summonscript.countdown--;
            if (summonscript.countdown <= 0)
            {
                summonscript.spawnnow = true;
                summonscript.countdown = levelmanager.maxspawns;
            }
            causespawn = false;
        }
            if (X.x < -30)
        {
            gameObject.SetActive(false);
        }
    }
}

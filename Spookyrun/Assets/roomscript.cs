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
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        if (X.x < -30 && causespawn == true)
        {
        summonscript.spawnnow = true;
            causespawn = false;
        }
            if (X.x < -30)
        {
            gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomrandomizescript : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        var X = transform.position;
      //  var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        if (X.x < -80)
        {
            transform.Translate(80F, 0F, 0F);
        }
    }
}

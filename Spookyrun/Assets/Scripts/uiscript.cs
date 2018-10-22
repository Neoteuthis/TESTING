using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiscript : MonoBehaviour
{
    public bool iswater;
    public bool isspring;
    public bool isscore;
    public bool ishighscore;
    int water = playerscript.waterlevel;
    int springs = playerscript.shrooms;
    int score = playerscript.score;
    int highscore = playerscript.highscore;
    
    public Text SCOREText;
    public Text HIGHSCOREText;
    public Text WATERText;
    public Text SPRINGText;
    void Start()
    {
        //Text sets your text to say this message
        SCOREText.text = score.ToString();
        HIGHSCOREText.text = highscore.ToString();
        WATERText.text = water.ToString();
        SPRINGText.text = springs.ToString();
    }

    void Update()
    {
        water = playerscript.waterlevel;
        springs = playerscript.shrooms;
        score = playerscript.score;
        highscore = playerscript.highscore;
        SCOREText.text = score.ToString();
        HIGHSCOREText.text = highscore.ToString();
        WATERText.text = water.ToString();
        SPRINGText.text = springs.ToString();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour
{
    public float scorecount;
    public float hiscorecount;

    public float pointspersecond;

    public Text scoretext;
    public Text hiscoretext;

    public bool isincreasing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frameasdfas
    void Update()
    {
        if (isincreasing)
        { 
            scorecount += pointspersecond * Time.deltaTime;
        }

        if(scorecount > hiscorecount)
        {
            hiscorecount = scorecount;
        }

        scoretext.text = "Score: " + Mathf.Round(scorecount);
        hiscoretext.text = "High Score: " + Mathf.Round(hiscorecount);
    }
}

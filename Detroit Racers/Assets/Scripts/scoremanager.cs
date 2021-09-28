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
    public Image flames;

    public bool isincreasing = true;


    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetFloat("highscore") != null)
            {
            hiscorecount = PlayerPrefs.GetFloat("highscore");
            }
    }

    // Update is called once per frameasdfas
    void Update()
    {
        if (isincreasing)
        { 
            scorecount += pointspersecond * Time.deltaTime;
        }

        if(scorecount >= hiscorecount)
        {
            hiscorecount = scorecount;
            PlayerPrefs.SetFloat("highscore", hiscorecount);
            flames.enabled = true;

        }

        scoretext.text = "Score: " + Mathf.Round(scorecount);
        hiscoretext.text = "High Score: " + Mathf.Round(hiscorecount);
    }

    public void resetthehighscore()
    {
        PlayerPrefs.SetFloat("highscore", 0f);
        hiscorecount = 0;
    }
}

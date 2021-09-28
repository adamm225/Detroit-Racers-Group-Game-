using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cones_Script : MonoBehaviour
{ 
    Vector3 pos;
    Vector3 scale;
    
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
       // transform.position = new Vector3(0, 0, 0);
        scale = transform.localScale;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 1f){
            Debug.Log(transform.position.y);
            if (transform.position.y >= -4 )
            {
                transform.localScale = transform.localScale + new Vector3(.011f, .011f, 0);
                transform.position = transform.position + new Vector3(-.01f, -.011f, 0);
                //transform.position = transform.position + new Vector3(0, -.011f, 0);
            }
            else
            {
                transform.position = transform.position + new Vector3(0, -.30f, 0);
            }
            if (transform.position.y <= -10)
            {   
                transform.position = pos;
                transform.localScale = scale;
                
            } 
        }
    }

}
 
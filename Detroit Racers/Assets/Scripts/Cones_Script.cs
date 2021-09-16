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
        Debug.Log(transform.position.y);
        transform.position = transform.position + new Vector3(0, -.015f, 0);
        transform.localScale = transform.localScale + new Vector3(.0002f, .0002f, 0);
        if (transform.position.y <= -4)
        {   
            transform.position = pos;
            transform.localScale = scale;
            
        } 
        
    }

}

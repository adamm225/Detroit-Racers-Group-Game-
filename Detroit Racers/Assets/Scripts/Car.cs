using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public UISystems Screencontroller; // this is so the car can use the script to restart the game


    public float movementSpeed = 2;
    private void Start()
    {
        Screencontroller = FindObjectOfType<UISystems>(); // this needs to be here so that the car can find the script that will restart the game
    }

 
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;
    }

    public void OnCollisionEnter2D(Collision2D collision) // needs a box collider on the banana and car so that when they hit this will be called
    {
        Screencontroller.restartgame(); //this has to be called when the car collides with a banana to restart the game
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables
    public float hoizontalInput;
    public float speed = 20.0f;
    public float xRange = 20.0f;
    
    public GameObject projectilePrefab; //reference to the projectile prefab sandwhich

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Left boundary
        if (transform.position.x < -xRange) //if the position on the x value goes past -20 then reset the position to -10 so they cant go past this 
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //Right Boundary
        if (transform.position.x > xRange) //if the position on the x value goes past 20 then reset the position to 10 so they cant go past this 
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Move left and right
        hoizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * hoizontalInput * Time.deltaTime * speed);


        //Shoot the projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);


        }
    }
}

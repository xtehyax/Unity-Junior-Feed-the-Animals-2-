using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    //Variables
    public float topBound = 30.0f;
    public float lowerBound = -10.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Top Boundary destroy sandwhich
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        //Lower Boundary destroy sandwhich
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}

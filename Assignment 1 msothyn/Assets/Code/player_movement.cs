using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public Rigidbody var1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            var1.AddForce(5, 0, 0 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            var1.AddForce(-5, 0, 0 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            var1.AddForce(0, 0, 1000 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            var1.AddForce(0, 0, -1000 * Time.deltaTime);
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPre : MonoBehaviour
{
    private GameObject cube;
    private GameObject cube1;
    private GameObject cube2;
    private GameObject cube3;
    public GameObject cubePreFab;
   

    void Start()
    {
        Vector3 offset = new Vector3(2, 0, -1);
        Vector3 offset1 = new Vector3(-4, 0, -7);
        Vector3 offset2 = new Vector3(-3, 0, -10);
       
        cube = Instantiate(cubePreFab);
        cube1 = Instantiate(cubePreFab);
        cube2 = Instantiate(cubePreFab);
        
        cube.transform.position = cube.transform.position + offset;
        cube1.transform.position = cube.transform.position + offset1;
        cube2.transform.position = cube.transform.position + offset2;
     

    }
    }

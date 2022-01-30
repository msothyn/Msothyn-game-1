using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myColli : MonoBehaviour
{

    private void OnCollisionEnter(Collision c1)
    {

        if (c1.gameObject.tag == "purple")
        {
            Destroy(c1.gameObject);
            ScoreManager.instance.AddPurplePoint();
            ScoreManager.instance.sumOfPoints();
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();



        }

        if (c1.gameObject.tag == "green")
        {
            Destroy(c1.gameObject);
            ScoreManager.instance.AddGreenPoint();
            ScoreManager.instance.sumOfPoints();
            AudioSource audio = GetComponent<AudioSource>();


            audio.Play();



        }

        if (c1.gameObject.tag == "blue")
        {
            Destroy(c1.gameObject);
            ScoreManager.instance.AddBluePoint();
            ScoreManager.instance.sumOfPoints();
            AudioSource audio = GetComponent<AudioSource>();


            audio.Play();



        }



    }
}
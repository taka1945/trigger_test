﻿using System.Collections;
using UnityEngine;


public class HitFeel : MonoBehaviour
{
    bool stopping;
    public float stopTime;
    public float slowTime;

    public Transform cam;
    Vector3 camPosition_original;
    public float shake;



    void TimeStop()
    {
        if (!stopping)
        {
            stopping = true;
            Time.timeScale = 0;

            StartCoroutine("Stop");
            StartCoroutine("CamAction");
        }
    }

    IEnumerator Stop()
    {
        yield return new WaitForSecondsRealtime(stopTime);
        Time.timeScale = 0.01f;

        yield return new WaitForSecondsRealtime(slowTime);
        Time.timeScale = 1;
        stopping = false;
    }

    IEnumerator CamAction()
    {
        camPosition_original = cam.position;

        cam.position =
            new Vector3(cam.position.x + Random.Range(-shake, shake),
                         cam.position.y + Random.Range(-shake, shake),
                         cam.position.z + Random.Range(-shake, shake) );

        cam.position =
            new Vector3(cam.position.x + Random.Range(-shake, shake),
                         cam.position.y + Random.Range(-shake, shake),
                         cam.position.z + Random.Range(-shake, shake));

        yield return new WaitForSecondsRealtime(0.05f);
        cam.position = camPosition_original;


    }



    private void OnTriggerEnter(Collider other)
    {
        TimeStop();
    }

}

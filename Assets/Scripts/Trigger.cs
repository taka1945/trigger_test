using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour
{
    IEnumerator OnTriggerEnter (Collider other)
    {

        Debug.Log("Triggered." + Time.frameCount);
        yield return new WaitForSeconds(3);
        Debug.Log("Waited (5 sec)." + Time.frameCount);

   
        if ( other.GetComponent<Bomb>() )
        {
            other.GetComponent<Bomb>().Flyme();
            Debug.Log("name: " + other.name);
        }


    }
}
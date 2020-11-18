using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public void Flyme()
    {

        transform.position = new Vector3(0, 3, 0);
        Debug.Log(" Flyme done.");
    }



}

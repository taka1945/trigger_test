using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public void Flyme()
    {        
        transform.position = new Vector3(this.transform.position.x, 3, this.transform.position.z);
        Debug.Log(" Flyme done.");
    }
}

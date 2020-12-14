using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeshManager : MonoBehaviour
{
    public void RemoveMesh ()
    {
        Destroy(gameObject.GetComponent<MeshCollider>());        
    }

    public void AddMesh()
    {
        if (GetComponent<MeshCollider>() == null)
            gameObject.AddComponent<MeshCollider>();
               
    }

    public void DisableMesh()
    {
        if (GetComponent<MeshCollider>())
            GetComponent<MeshCollider>().enabled = false;
    }

    public void EnableMesh()
    {
        if (GetComponent<MeshCollider>())
            GetComponent<MeshCollider>().enabled = true;
    }

}



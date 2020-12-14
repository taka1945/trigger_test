//make sure to add a CharacterController to the thing that you want to move
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    private void Start()
    {
        moveSpeed = 10f;
    }


    void Update()
    {
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 
                        0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }





}
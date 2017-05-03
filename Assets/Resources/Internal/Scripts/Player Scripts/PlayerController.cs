using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rigid;
    private bool canJump = true;
    public float playerWalkSpeed = 0.2f;
    private RaycastHit ray;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;                  //locks the cursor at center of screen at the start of the game
        rigid = GetComponent<Rigidbody> ();
    }

    private void FixedUpdate()
    {
        Physics.Raycast(transform.position, Vector3.down, out ray);

        if (Vector3.Distance(transform.position, ray.point) < 0.76){
            canJump = true;
        }

        if (Input.GetKey(KeyCode.W))                               //adds a key listener on key 'W' to move forward
        {
            transform.Translate(Vector3.forward * playerWalkSpeed);
        }
        if (Input.GetKey(KeyCode.A))                               //adds a key listener on key 'A' to move left
        {
            transform.Translate(Vector3.left * playerWalkSpeed);
        }
        if (Input.GetKey(KeyCode.S))                               //adds a key listener on key 'S' to move backwards
        {
            transform.Translate(Vector3.back * playerWalkSpeed);
        }
        if (Input.GetKey(KeyCode.D))                               //adds a key listener on key 'D' to move right
        {
            transform.Translate(Vector3.right * playerWalkSpeed);
        }
        if (Input.GetKey(KeyCode.Space))                               //adds a key listener on key 'Space' to jump
        {
            if (canJump == true)
            {
                rigid.velocity = Vector3.up * 6.0f;
                canJump = false;
            }
        }
    }
}
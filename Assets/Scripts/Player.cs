using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerController))]
//[RequireComponent(typeof(GunController))]

public class Player : MonoBehaviour
{
    public float moveSpeed = 5;

    Camera viewCamera;
    PlayerController controller;
    private Transform myTransform;
    // GunController gunController;

    void Start()
    {

        controller = GetComponent<PlayerController>();
        // gunController = GetComponent<GunController>();
        viewCamera = Camera.main;
        myTransform = transform;
    }

    void Update()
    {
        // Movement input
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 moveVelocity = moveInput.normalized * moveSpeed;
        controller.Move(moveVelocity);

        // Look input
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed;
        float vertical = Input.GetAxis("Vertical") * moveSpeed;
        Vector3 moveDirection = new Vector3(horizontal, 0, vertical);

        // If statement to check player is moving
        if (moveDirection != (new Vector3(0, 0, 0)))
        {
            // Quaternion to rotate the player
            Quaternion newRotation = Quaternion.LookRotation(moveDirection);
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, newRotation, moveSpeed * Time.deltaTime);


            // Object input
            if (Input.GetMouseButton(0))
            {
                //pickUp();
            }
        }
    }
}
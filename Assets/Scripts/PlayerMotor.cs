using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 playerVelocity;
    public float speed=5f;
    private bool isGrounded;
    public float gravity = -9.8f;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded=characterController.isGrounded;
    }
    public void ProcessMove(Vector2 move)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = move.x;
        moveDirection.z = move.y;
        characterController.Move(transform.TransformDirection(moveDirection)*speed*Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;
        if (isGrounded &&playerVelocity.y<0)
        {
            playerVelocity.y = -2f;
        }
        characterController.Move(playerVelocity*Time.deltaTime);
        Debug.Log(playerVelocity.y);
    }
}

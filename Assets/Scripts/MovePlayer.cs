using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{

    [SerializeField] private Transform playerTransform;

    [Header("Player Rigidbody")]
    [SerializeField] private Rigidbody2D rb;

    private Vector2 moveDirection = Vector2.zero;

    [Header("Player Move Speed")]
    //controls how fast player moves
    [SerializeField] private float speed = 3f;

    [Header("SO Variables")]

    [SerializeField] private BoolVariable gameIsPaused;

    [SerializeField] private BoolVariable playerFacingRight;




    private void Awake()
    {
        gameIsPaused.Value = false;
        playerFacingRight.Value = true;
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        if (gameIsPaused.Value == false)
        {

            if (context.performed)
            {

                moveDirection = context.ReadValue<Vector2>();
                rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);

                switch (moveDirection.x)
                {
                    case > 0:
                        playerTransform.rotation = new Quaternion(0f, 0f, 0f, 0f);
                        playerFacingRight.Value = true;
                        break;

                    case < 0:
                        playerTransform.rotation = new Quaternion(0f, 180f, 0f, 0f);
                        playerFacingRight.Value = false;
                        break;
                }

            }
            else
            {
                rb.velocity = Vector2.zero;
            }
        }
    }





}
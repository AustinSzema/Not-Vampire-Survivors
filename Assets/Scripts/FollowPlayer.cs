using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{


    [SerializeField] private float moveSpeed = 2f;


    [SerializeField] private Vector3Variable _playerPosition;

    [SerializeField] private BoolVariable gameIsPaused;

    // Update is called once per frame
    void Update()
    {
        if(gameIsPaused.Value == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, _playerPosition.Value, moveSpeed * Time.deltaTime);
            if (_playerPosition.Value.x > transform.position.x)
            {
                transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
            }
            else
            {
                transform.rotation = new Quaternion(0f, 180f, 0f, 0f);
            }

        }
    }
}



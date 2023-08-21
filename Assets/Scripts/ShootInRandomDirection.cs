using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootInRandomDirection : MonoBehaviour
{
    [SerializeField] private Rigidbody2D projectileRB;
    
    [SerializeField] private float speed = 10f;

    [SerializeField] private Vector3Variable _playerPosition;

    [SerializeField] private BoolVariable gameIsPaused;

    // Start is called before the first frame update
    void Start()
    {        
        transform.rotation = Quaternion.Euler(0f, 0f, Random.Range(0f, 360f));

        
    }

    private void FixedUpdate()
    {
        if(gameIsPaused.Value == false)
        {
            projectileRB.velocity = transform.up * speed;
        }
    }



}

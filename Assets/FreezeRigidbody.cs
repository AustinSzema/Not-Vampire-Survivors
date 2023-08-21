using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeRigidbody : MonoBehaviour
{

    [SerializeField] private BoolVariable gameIsPaused;

    [SerializeField] private Rigidbody2D attackRB;

    // Update is called once per frame
    void Update()
    {
        if(gameIsPaused.Value == true)
        {
            attackRB.constraints = RigidbodyConstraints2D.FreezePosition;

        }
    }
}

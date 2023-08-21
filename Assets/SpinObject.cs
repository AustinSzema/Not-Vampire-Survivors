using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 500f;

    [SerializeField] private BoolVariable gameIsPaused;

    // Update is called once per frame
    void Update()
    {
        if(gameIsPaused.Value == false)
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
        }
    }
}

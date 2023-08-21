using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingAttack : MonoBehaviour
{

    [SerializeField] private float attackInterval = 3f;  // Time interval between attacks

    [SerializeField] private BoolVariable gameIsPaused;



    [SerializeField] private GameObject rotatingAttackPrefab;

    [SerializeField] private Transform playerTransform;

    private GameObject rotatingAttack;

    [SerializeField] private float rotationSpeed = 50f;



    private bool active = false;

    private void Start()
    {
        rotatingAttack = Instantiate(rotatingAttackPrefab, playerTransform.position, Quaternion.identity);
        rotatingAttack.SetActive(false);

        InvokeRepeating("DoAttack", attackInterval, attackInterval);

    }


    // Update is called once per frame
    void Update()
    {

        rotatingAttack.transform.position = playerTransform.position;
        if(gameIsPaused.Value == false)
        {
            rotatingAttack.transform.RotateAround(playerTransform.position, Vector3.forward, rotationSpeed * Time.deltaTime);

            if (active == true)
            {
                rotatingAttack.SetActive(true);
            }
            else
            {
                rotatingAttack.SetActive(false);
            }

        }

    }

    private void DoAttack()
    {
        active = !active;
    }

}




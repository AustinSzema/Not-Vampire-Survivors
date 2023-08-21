using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileAttack : MonoBehaviour
{
    [SerializeField] private float attackInterval = 1.5f;  // Time interval between attacks
    private float timeSinceLastAttack = 0f;  // Time elapsed since last attack

    [SerializeField] private GameObject attackPrefab;


    [SerializeField] private BoolVariable gameIsPaused;

    [SerializeField] private BoolVariable playerFacingRight;

    private float directionToAttack = 1f;

    void Update()
    {
        // Increase time elapsed since last attack
        timeSinceLastAttack += Time.deltaTime;


        // Check if enough time has passed since last attack
        if (timeSinceLastAttack >= attackInterval)
        {
            if (gameIsPaused.Value == false)
            // Attack!
            DoAttack();

            // Reset time since last attack
            timeSinceLastAttack = 0f;
        }


    }

    void DoAttack()
    {
        if (playerFacingRight.Value == true)
        {
            directionToAttack = 1f;
        }
        else
        {
            directionToAttack = -1f;
        }

        Instantiate(attackPrefab, transform.position + new Vector3(attackPrefab.transform.localScale.x / 2f * directionToAttack, 0f, 0f), Quaternion.identity);
    }

}

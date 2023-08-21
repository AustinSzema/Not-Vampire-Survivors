using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionAttack : MonoBehaviour
{
    
    [SerializeField] private float attackInterval = 1.5f;  // Time interval between attacks
    private float timeSinceLastAttack = 0f;  // Time elapsed since last attack

    [SerializeField] private GameObject attackPrefab;

    [SerializeField] private BoolVariable gameIsPaused;

    [SerializeField] private BoolVariable playerFacingRight;


    [SerializeField] private Vector3 attackOffset = new Vector3(0f, 1.5f, 0f);

    [SerializeField] private Vector2 attackForce = new Vector2(1f, 1.5f);



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


        GameObject potion = Instantiate(attackPrefab, transform.position + attackOffset, Quaternion.identity);
        
        if (playerFacingRight.Value == true)
        {
            attackForce = new Vector2(Mathf.Abs(attackForce.x), attackForce.y);
        }
        else
        {
            attackForce = new Vector2(-1f * Mathf.Abs(attackForce.x), attackForce.y);
        }


        potion.GetComponent<Rigidbody2D>().AddForce(attackForce);
    }

}

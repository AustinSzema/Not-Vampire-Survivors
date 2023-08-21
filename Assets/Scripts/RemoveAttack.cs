using UnityEngine;

public class RemoveAttack : MonoBehaviour
{

    private float elapsedTime = 0f;  // Time elapsed since last attack

    [SerializeField] private float attackLifespan = 0.5f;

    [SerializeField] private BoolVariable gameIsPaused;


    void Update()
    {
        // Increase time elapsed since last attack
        elapsedTime += Time.deltaTime;


        if (elapsedTime >= attackLifespan && gameIsPaused.Value == false)
        {
            Destroy(gameObject);
        }
    }

}
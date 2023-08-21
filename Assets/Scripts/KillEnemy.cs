using UnityEngine;

public class KillEnemy : MonoBehaviour
{


    [SerializeField] private GameObject coinPrefab;

    [SerializeField] private GameObject enemyDeathParticles;


    [SerializeField] private IntVariable enemyCount;

    //private float coinChance = 0.7f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if(collision.gameObject.tag == "Enemy")
        {
            Instantiate(coinPrefab, collision.gameObject.transform.position, Quaternion.identity);
            Instantiate(enemyDeathParticles, collision.gameObject.transform.position, Quaternion.identity);

            Destroy(collision.gameObject);
            if(enemyCount.Value >= 1)
            {
                enemyCount.Value--;
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(coinPrefab, transform.position, Quaternion.identity);

            Instantiate(enemyDeathParticles, collision.gameObject.transform.position, Quaternion.identity);

            Destroy(collision.gameObject);

            if (enemyCount.Value >= 1)
            {
                enemyCount.Value--;
            }
        }
    }
}



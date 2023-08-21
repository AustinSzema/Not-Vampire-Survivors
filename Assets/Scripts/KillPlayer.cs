using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{

    [SerializeField] private Rigidbody2D playerRB;

    [SerializeField] private BoolVariable gameIsPaused;

    [SerializeField] private GameObject playerDeathParticles;

    [SerializeField] private GameObject rToRestartCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "EnemyHitbox")
        {
            gameIsPaused.Value = true;

            playerRB.velocity = Vector2.zero;

            Instantiate(playerDeathParticles, transform.position, Quaternion.identity);

            Instantiate(rToRestartCanvas, transform.position, Quaternion.identity);


        }
    }
}

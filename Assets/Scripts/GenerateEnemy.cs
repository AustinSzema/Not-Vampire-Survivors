using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;



    [Header("Enemy Stuff")]

    [SerializeField] private GameObject enemyPrefab;

    [SerializeField] private Sprite[] EnemySprites;

    [SerializeField] private int numberOfEnemies = 100;

    private float elapsedTime = 0f;  // Time elapsed since last attack


    [SerializeField] private BoolVariable gameIsPaused;


    [SerializeField] private IntVariable enemyCount;


    private void Awake()
    {
        enemyCount.Value = 0;
    }


    private void Start()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            CreateEnemy(10f, 20f);


        }

    }

    void Update()
    {
        // Increase time elapsed since last attack
        elapsedTime += Time.deltaTime;


        if (elapsedTime >= 0.5f)
        {

            if (gameIsPaused.Value == false)
            {
                while(enemyCount.Value < numberOfEnemies + 50)
                {
                    CreateEnemy(25f, 30f);
                    
                }
            }
            elapsedTime = 0f;
        }
    }


    void CreateEnemy(float min, float max)
    {

        float maxDistanceFromPlayer = min;
        float minDistanceFromPlayer = max;

        float xOffset = Random.Range(maxDistanceFromPlayer, minDistanceFromPlayer) * Mathf.Sign(Random.Range(-1f, 1f));
        float yOffset = Random.Range(maxDistanceFromPlayer, minDistanceFromPlayer) * Mathf.Sign(Random.Range(-1f, 1f));

        GameObject enemy = Instantiate(enemyPrefab, playerTransform.position + new Vector3(playerTransform.position.x + xOffset, playerTransform.position.y + yOffset, 0f), Quaternion.identity);


        enemy.GetComponent<SpriteRenderer>().sprite = EnemySprites[Random.Range(0, EnemySprites.Length - 1)];
        enemyCount.Value++;
    }

}
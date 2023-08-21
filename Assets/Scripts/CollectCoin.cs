using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectCoin : MonoBehaviour
{


    private int coinCount = 0;

    [SerializeField] private TextMeshProUGUI CoinCountText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            coinCount++;
            CoinCountText.text = "Score: " + coinCount;
        }
    }
}

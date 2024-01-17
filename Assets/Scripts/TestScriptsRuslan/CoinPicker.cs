using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    private int coins = 0;
    public TMP_Text coinsText;

    private HashSet<GameObject> collectedCoins = new HashSet<GameObject>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin") && !collectedCoins.Contains(collision.gameObject))
        {
            coins++;
            coinsText.text = coins.ToString();

            collectedCoins.Add(collision.gameObject);

            Destroy(collision.gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectables : MonoBehaviour
{
   public TextMeshProUGUI CoinCount;
   public int CoinsCollected;
   public int TotalCoins;

    void Start()
    {
        TotalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
        CoinCount.text = CoinsCollected + "/" + TotalCoins;

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            CoinsCollected++;
            CoinCount.text = CoinsCollected + "/" + TotalCoins;
            Destroy(other.gameObject);
        }


    }
}

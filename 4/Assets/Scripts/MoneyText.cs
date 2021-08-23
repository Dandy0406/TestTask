using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyText : MonoBehaviour
{
    public  int Coin;

    Text text;
    void Start()
    {
 
        text = GetComponent<Text>();
      
        Coin = PlayerPrefs.GetInt("coins", Coin);

        Coin = 1500;
    }

    void Update()
    {
        
        text.text = Coin.ToString();
        
    }
    private void FixedUpdate()
    {
        PlayerPrefs.SetInt("coins", Coin);
    }

}

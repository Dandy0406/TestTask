using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventorySystem : MonoBehaviour
{
    private static InventorySystem _instance;
    public static InventorySystem Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }


    public MoneyText mt;
    public Slider slider;
    private int sim;
    private int index;

    public List<GameObject> inventoryItems;
    public GameObject[] sellButtons;
    
    
    void Start()
    {
      // PlayerPrefs.DeleteAll();
      
        sim = PlayerPrefs.GetInt("Similarity");
    }

    void Update()
    {
        slider.value = sim;
    }

   public void DecreaseSimilarity(int num)
    {
        sim -= num;
        PlayerPrefs.SetInt("Similarity", sim);
    }
    public void IncreaseSimilarity(int num)
    {
        sim += num;
        PlayerPrefs.SetInt("Similarity", sim);
    }
    public void Sell(int num)
    {
        OutfitChanger.Instance.Default();
        Destroy(inventoryItems[num]);
        mt.Coin += 100;
    }
}

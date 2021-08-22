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


    public Slider slider;

    private int sim;

    // Start is called before the first frame update
    void Start()
    {
     //   PlayerPrefs.DeleteAll();
      
        sim = PlayerPrefs.GetInt("Similarity");
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = sim;
    }

    void DecreaseSimilarity(int num)
    {
        sim -= num;
        PlayerPrefs.SetInt("Similarity", sim);
    }
}

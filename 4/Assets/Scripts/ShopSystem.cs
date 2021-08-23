using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    private static ShopSystem _instance;
    public static ShopSystem Instance
    {
        get
        {
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }

    public GameObject shopCanvas;
    public GameObject[] shops;

    public void CloseShop()
    {
        shopCanvas.SetActive(false);
        for (int i = 0; i < shops.Length; i++)
        {
            shops[i].SetActive(false);

        }
    }

    public void SetShops(int index)
    {

        switch (index)
        {
            case 0:
                shopCanvas.SetActive(true);
                shops[index].SetActive(true);
                break;
            case 1:
                shopCanvas.SetActive(true);
                shops[index].SetActive(true);
                break;
            case 2:
                shopCanvas.SetActive(true);
                shops[index].SetActive(true);
                break;
            case 3:
                shopCanvas.SetActive(true);
                shops[index].SetActive(true);
                break;
            default:
                shopCanvas.SetActive(false);
                break;
        }
    }
}

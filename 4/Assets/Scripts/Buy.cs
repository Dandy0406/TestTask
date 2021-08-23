using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Buy : MonoBehaviour
{
    public MoneyText moneyText;

    private Inventory inventory;
    public GameObject item;

    public int price;
    public Button btn;


    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); 
    }

    public void Add()
    {
        for (int i = 0; i < inventory.slots.Length; i++ )
        {
            if (inventory.isFull[i] == false && moneyText.Coin >= price)
            {
                inventory.isFull[i] = true;
                
                GameObject itemInventory =  Instantiate(item, inventory.slots[i].transform, false);
                itemInventory.GetComponent<Button>().interactable = true;
                InventorySystem.Instance.inventoryItems.Add(itemInventory);
                InventorySystem.Instance.sellButtons[i].SetActive(true);
                item.SetActive(false);
                btn.interactable = false;
                moneyText.Coin -= price;
                
                
                break;
            }
        }
    }



    
}

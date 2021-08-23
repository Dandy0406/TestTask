using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    private static OutfitChanger _instance;
    public static OutfitChanger Instance
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

    public bool changed;
    public bool picked;
    [Header("Default Sprite")]
    public Sprite defaultSprite;
    [Header("Sprite to Change")]
    public SpriteRenderer bodyPart;
    [Header("Sprites to swap")]
    public List<Sprite> options = new List<Sprite>();
    public void SetOption(int i)
    {
        if(changed == false)
        {
            InventorySystem.Instance.DecreaseSimilarity(1);
            changed = true;
        }

        bodyPart.sprite = options[i];
    }
    
    public void Default()
    {
        bodyPart.sprite = defaultSprite;
    }
}

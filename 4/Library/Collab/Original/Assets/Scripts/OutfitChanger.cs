using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    [Header("Sprite to Change")]
    public SpriteRenderer bodyPart;
    [Header("Sprites to swap")]
    public List<Sprite> options = new List<Sprite>();


    public Slot slot;

    public void SetOption(int i)
    {
        bodyPart.sprite = options[i];
    }

    public void Sell()
    {
      //  Destroy(gameObject);
    }
}

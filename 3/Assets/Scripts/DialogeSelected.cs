using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DialogeSelected : MonoBehaviour
{
    public TMP_Text text;
    public string[] dialogues;
    public int sim;

    void Update()
    {
        sim = PlayerPrefs.GetInt("Similarity");
        switch (sim)
        {
            case 1:
                {
                    text.text = dialogues[0];
                }
                break;
            case 2:
                {
                    text.text = dialogues[1];
                }
                break;
            case 3:
                {
                    text.text = dialogues[2];
                }
                break;
            case 4:
                {
                    text.text = dialogues[3];
                }
                break;
            case 5:
                {
                    text.text = dialogues[4];
                }
                break;
        }
    }
}

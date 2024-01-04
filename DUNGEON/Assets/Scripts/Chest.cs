using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emtyChest;
    public int pesosAmount = 5;
    
   protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emtyChest;
            GameManager.instance.pesos += pesosAmount;
            GameManager.instance.ShowText("+" + pesosAmount + " pesos!", 25,Color.yellow, transform.position, Vector3.up * 25, 1.0f);
        }
    }
}

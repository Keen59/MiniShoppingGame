using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour,IBuyedItems
{
    //holding items taken on
    public List<Items> CurrentBuyedItems;
    public void AddBuyedItems(Items item)
    {
        CurrentBuyedItems.Add(item);
    }
    //removing items from list
    public void RemoveBuyedItems(Items item)
    {
       
        CurrentBuyedItems.Remove(item);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Items : MonoBehaviour
{
    //defined item's price
    [SerializeField] private float price;
    //defined item's name

    [SerializeField]private string name;
    
    //defined item's type

    [SerializeField] private ItemType type;
    public bool MovementCheck;
    public IBuyedItems _buyedItemsInterface;

    private void Awake()
    {
        _buyedItemsInterface = GameObject.FindGameObjectWithTag("GameController").GetComponent<IBuyedItems>();
    }

    //defined abstract buy methot. each item have to go different position
    public abstract void Buy(Transform playerPosition);

    private void OnTriggerEnter(Collider other)
    {
        //player
        if (other.tag == "Player" && MovementCheck)
        {
            Buy(other.transform);
            MovementCheck = false;
            transform.parent = other.transform;
        
            _buyedItemsInterface.AddBuyedItems(this);
        }
        else if (other.tag == "Cart")
        {
            ShoppingCart.AddShoppingItem(other.transform, this);
            _buyedItemsInterface.RemoveBuyedItems(this);
        }
    }
    public string GetName()
    {
        return name;
    }
    public float GetPrice()
    {
        return price;
    }
    private void OnMouseDrag()
    {
        if (MovementCheck)
        {
            Vector3 mouse_pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 9.980691f);
            Vector3 object_pos = Camera.main.ScreenToWorldPoint(mouse_pos);
            transform.position = object_pos;
        }

    }

}
//defined Items types

public enum ItemType
{
    CD,MAGAZINE,FOOD,BOOK
}

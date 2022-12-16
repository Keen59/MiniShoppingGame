using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class ShoppingCart : MonoBehaviour
{
       static int order=-2;
    //adding item to cart 
    public static void AddShoppingItem(Transform trnsfrm,Items item)
    {
     
            order++;
            item.transform.position = new Vector2(trnsfrm.position.x + order,trnsfrm.position.y);
            item.transform.parent = null;
            UIManager.instance.SetShop(item.GetPrice(),item.GetName());
        
    }
    
}

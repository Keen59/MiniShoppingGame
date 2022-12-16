using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : Items
{
    //buying item and set position

    public override void Buy(Transform playerTransform)
    {
        transform.position = playerTransform.position + Vector3.left;
        
    }

 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]private float CharacterSpeed;
    private float HorizontalAxis;
    private float VerticalAxis;
  
   //character movement
    void Update()
    {
        HorizontalAxis = Input.GetAxis("Horizontal");
        VerticalAxis = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(HorizontalAxis,VerticalAxis)* CharacterSpeed,Space.World);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -3, 3), Mathf.Clamp(transform.position.y, -5, 3));
    }
}

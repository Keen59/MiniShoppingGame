using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public float Cost;
    public string Ingredients;
    public TMP_Text CostText;
    public TMP_Text IngredientsText;
    private void Awake()
    {
        instance = this;
    }
    //Check out button creating new txt file and write Ingredients.
    public void CheckOut()
    {
        IngredientsText.text = "Ingredients:";
        CostText.text = "Cost:";
        string combined = Ingredients + " " + Cost.ToString();
        StreamWriter writer = new StreamWriter("Assets/Output/MyPath.txt");

        writer.WriteLine(combined);
        writer.Close();
        Ingredients = "";
        Cost = 0;
    }
    //set shop prices
    public void SetShop(float price,string name)
    {
        Cost += price;
        Ingredients += "Name :"+name +" Price:"+ price;
        IngredientsText.text = Ingredients;
        CostText.text = Cost.ToString();
    }
}

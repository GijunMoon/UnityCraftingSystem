using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Recipe", menuName = "CraftingRecipe", order = 2)]
public class CraftingRecipes : ScriptableObject
{
    [SerializeField]
    string ItemName;

    [SerializeField]
    string description;

    [SerializeField]
    string [] recipes = new string[6];


    public string sName => ItemName;

    public string sDesc => description;

    public string [] nRes => recipes;
}


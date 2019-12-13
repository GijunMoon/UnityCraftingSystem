using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingSystem : MonoBehaviour
{
    public Text result;
    public Text resultdec;
    public string[] items = new string [6];
    public CraftingRecipes recipes;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void OnClickCraft()
    {
        int i = 0;
        while (i > -1)
        {
            i++;

            if (items[i - 1] == recipes.nRes[i - 1])
            {
                if (i == recipes.nRes.Length - 1)
                {
                    result.text = recipes.sName;
                    resultdec.text = recipes.sDesc;
                    break;
                }
            }
            else
            {
                result.text = "Nothing";
                resultdec.text = "Sorry..";
                break;
            }
        }
    }
}

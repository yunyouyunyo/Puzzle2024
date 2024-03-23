using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class ItemInstance
{
    public ItemData itemData;
    public int condition;
    // not sure
    // public ItemData newItemType;
    // public List<ItemInstance> items = new();
    // void Start()
    // {
    //     items.Add(new ItemInstance(newItemType));
    // }
    // not sure
    
    public ItemInstance(ItemData itemdata)
    {
        itemData = itemdata;
        condition = itemdata.startingCondition;

    }
}

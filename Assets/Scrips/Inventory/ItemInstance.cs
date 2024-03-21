using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemInstance
{
    public ItemData itemType;
    public int condition;

    
// not sure
    public ItemData newItemType;
    public List<ItemInstance> items = new();

    void Start()
    {
        items.Add(new ItemInstance(newItemType));
    }
    // not sure
    
    public ItemInstance(ItemData itemData)
    {
        itemType = itemData;
        condition = itemData.startingCondition;
    }
}

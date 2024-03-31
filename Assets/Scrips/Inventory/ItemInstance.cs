using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class ItemInstance
{
    public FixedInventoryItem itemType;
    // not sure
    // public ItemData newItemType;
    // public List<ItemInstance> items = new();
    void Start()
    {
        
    }
    // not sure
    
    public ItemInstance(FixedInventoryItem fixedInventoryItem)
    {
        itemType = fixedInventoryItem;
    }
}

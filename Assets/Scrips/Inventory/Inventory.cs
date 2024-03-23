using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemInstance> items = new();
    public InventoryDisplay inventoryDisplay;

    public void AddItem(ItemInstance itemToAdd)
    {
        items.Add(itemToAdd);
        Debug.Log("add");
        inventoryDisplay.UpdateInventory();
    }

    public void RemoveItem(ItemInstance itemToRemove)
    {
        items.Remove(itemToRemove);
    }
    public void Print()
    {
        Debug.Log("Got");
    }
}

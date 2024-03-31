using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public List<FixedInventoryItem> items = new();
    public InventoryDisplay inventoryDisplay;
    public void AddItem(FixedInventoryItem itemToAdd)
    {
        items.Add(itemToAdd);
        Debug.Log("add");
        inventoryDisplay.UpdateInventory();

    }

    public void RemoveItem(FixedInventoryItem itemToRemove)
    {
        items.Remove(itemToRemove);
    }
    public void Print()
    {
        Debug.Log("Got");
    }
}

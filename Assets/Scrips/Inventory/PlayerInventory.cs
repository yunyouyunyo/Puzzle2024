using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public DynamicInventory dynamicInventory;
    

    private void Start()
    {
        // inventoryDisplay = FindObjectOfType<InventoryDisplay>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out InstanceItemContainer foundItem))
        {

            FixedInventoryItem item = foundItem.TakeItem();
            dynamicInventory.AddItem(item);
            // inventoryDisplay.UpdateInventory();
            InventoryDisplay.Instance.UpdateInventory();
        }
    }
}
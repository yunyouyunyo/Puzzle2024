using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{
    public Inventory inventory;
    public ItemDisplay[] slots=new ItemDisplay[4];

    private void Start()
    {
        
    }

    public void UpdateInventory()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            Debug.Log(slots.Length);
            if (i < inventory.items.Count)
            {
                slots[i].gameObject.SetActive(true);
                slots[i].UpdateItemDisplay(inventory.items[i].itemData.icon, i);
                Debug.Log("get inventory");
            }
            else
            {
                slots[i].gameObject.SetActive(false);
                 Debug.Log("Not get inventory");
            
            }
        }
        Debug.Log("Not do anything");
    }
    public void DropItem(int itemIndex)
    {
        // Creates a new object and gives it the item data
        GameObject droppedItem = new GameObject();
        droppedItem.AddComponent<Rigidbody2D>();
        droppedItem.AddComponent<InstanceItemContainer>().item = inventory.items[itemIndex];
        GameObject itemModel = Instantiate(inventory.items[itemIndex].itemData.model, droppedItem.transform);

        // Removes the item from the inventory
        inventory.items.RemoveAt(itemIndex);

        // Updates the inventory again
        UpdateInventory();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventoryDisplay : MonoBehaviour
{
    public DynamicInventory dynamicInventory;
    public ItemDisplay[] slots = new ItemDisplay[4];

    private void Start()
    {
        dynamicInventory.items.Clear();
        // UpdateInventory();
    }

   public void UpdateInventory()
    {
        for (int i = 0; i < 4 ; i++)
        {
            Debug.Log("Enter loop");
            if (i < dynamicInventory.items.Count)
            {
                Debug.Log("get inventory");
                slots[i].gameObject.SetActive(true);
                slots[i].UpdateItemDisplay(dynamicInventory.items[i].icon, i);
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
        droppedItem.AddComponent<InstanceItemContainer>().item = dynamicInventory.items[itemIndex];
        GameObject itemModel = Instantiate(dynamicInventory.items[itemIndex].model, droppedItem.transform);

        // Removes the item from the inventory
        dynamicInventory.items.RemoveAt(itemIndex);

        // Updates the inventory again
        UpdateInventory();
    }
}

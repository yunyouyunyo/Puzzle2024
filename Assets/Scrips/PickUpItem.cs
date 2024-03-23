using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public Inventory inventory;
    public ItemInstance itemInstance;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 將物品添加到 inventory 中
            inventory.AddItem(itemInstance);

            // 從場景中移除物品
            Destroy(gameObject);
        }
    }
}

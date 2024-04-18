using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public DynamicInventory dynamicInventory; // 這個變量可以在 Unity 界面中設置

    private void Start()
    {
        // 在需要時訪問 DynamicInventory 的實例
        if (dynamicInventory == null)
        {
            dynamicInventory = FindObjectOfType<DynamicInventory>();
        }

    }
}

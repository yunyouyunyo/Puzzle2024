using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Recorder;
using UnityEngine;
using UnityEngine.UI;
public class ItemDisplay : MonoBehaviour
{
    public int itemIndex;
    public Image image;

    public void UpdateItemDisplay(Sprite newImage, int newItemIndex)
    {
        
            Debug.Log("UpdateItem");
            image.sprite = newImage;
            itemIndex = newItemIndex;
    }

    public void DropFromInventory(InventoryDisplay inventoryDisplay)
    {
        inventoryDisplay.DropItem(itemIndex);
    }
    
}

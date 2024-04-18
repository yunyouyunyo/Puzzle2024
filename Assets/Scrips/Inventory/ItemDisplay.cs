using UnityEngine;
using UnityEngine.UI;
public class ItemDisplay : MonoBehaviour
{
    public int itemIndex;
    DropItem dropItem;
    public Image image;

    public void UpdateItemDisplay(Sprite newImage, int newItemIndex)
    {
        
            Debug.Log("UpdateItem");
            image.sprite = newImage;
            itemIndex = newItemIndex;
            dropItem.itemIndex = newItemIndex;
    }

    public void DropFromInventory(Sprite block)
    {
        
        image.sprite = block;
        Debug.Log("Drop finish");
        // inventoryDisplay.DropItem(itemIndex);
    }
    
}

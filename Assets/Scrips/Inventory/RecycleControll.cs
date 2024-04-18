using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class RecycleControll : MonoBehaviour
{
    public DynamicInventory dynamicInventory;
    public FixedInventoryItem fixedInventoryItem;
    // GameObject gameObject;
    private void OnTriggerEnter2D(Collider2D coll){
        if(coll.gameObject.tag == "Player"){
            for(int i=0;i<4;i++){
                if(dynamicInventory.items[i].index==1){
                    InventoryDisplay.Instance.DropItem(dynamicInventory.items[i].index);
                    dynamicInventory.RemoveItem(fixedInventoryItem);
                    Destroy(gameObject);
                }
            }
        }
    }

    
}

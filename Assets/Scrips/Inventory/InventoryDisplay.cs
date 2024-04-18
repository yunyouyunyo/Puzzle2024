using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class InventoryDisplay : MonoBehaviour
{

    public DynamicInventory dynamicInventory;
    public ItemDisplay[] slots = new ItemDisplay[4];
    public DropItem dropItem;
    private bool isSelected = false;
    public Sprite nullBlock;

    //temp
    public static InventoryDisplay Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //temp
    private void Start()
    {
        dynamicInventory.items.Clear();
        // UpdateInventory();
    }

    public void UpdateInventory()
    {
        for (int i = 0; i < 4; i++)
        {
            Debug.Log("Enter loop");
            if (i < dynamicInventory.items.Count)
            {
                Debug.Log("get inventory");
                slots[i].gameObject.SetActive(true);
                slots[i].UpdateItemDisplay(dynamicInventory.items[i].icon,dynamicInventory.items[i].index);
            }
            else
            {
                // slots[i].gameObject.SetActive(false);
                Debug.Log("Not get inventory");

            }
        }
        Debug.Log("Not do anything");
    }
    
    public void DropItem(int dropItemIndex)
    {
        for (int i = 0; i < 4; i++)
        {
            if (slots[i].itemIndex == dropItemIndex)
            {
                Debug.Log("CheckDropItem");
                slots[i].DropFromInventory(nullBlock);
            }
        }
        // UpdateInventory();
    }


}

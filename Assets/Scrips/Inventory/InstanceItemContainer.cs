using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class InstanceItemContainer : MonoBehaviour
    {
        public FixedInventoryItem item;

        public FixedInventoryItem TakeItem()
        {
            Destroy(gameObject);
            return item;
        }
    }
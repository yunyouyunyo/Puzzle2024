using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class FixedInventoryItem : ScriptableObject
{

    public bool hasItem;
    public string itemName;
    public GameObject model;
    public Sprite icon;
    [TextArea]
    public string description;
}

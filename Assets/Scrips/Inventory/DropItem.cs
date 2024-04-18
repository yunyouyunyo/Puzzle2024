using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropItem : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public static DropItem selectedItem;
    
    public int itemIndex;

    public Color normalColor;
    public Color highlightedColor = Color.blue;
    public Color pressColor = Color.red;
    public Image image;
    private bool isSelected = false;


    void Start()
    {


    }
    public void SetAlpha()
    {
        normalColor = image.color;
        normalColor.a = 1.0f;
        image.color = normalColor;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (selectedItem != null && selectedItem != this)
        {
            selectedItem.Deselect();
            selectedItem = null;
        }

        if (!isSelected)
        {
            Select();
            
        }
        else
        {
            Deselect();
        }
    }
    public void Select()
    {
        isSelected = true;
        selectedItem = this;
        image.color = pressColor;
    }
    public void Deselect()
    {
        isSelected = false;
        selectedItem = null;
        image.color = normalColor;

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!isSelected)
        {
            image.color = highlightedColor;
        }

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!isSelected)
        {
            image.color = normalColor;
        }

    }



}

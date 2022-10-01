using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.Events;

[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour, IPointerEnterHandler,IPointerClickHandler,IPointerExitHandler
{
    public TabGroup tabGroup;
    private TextMeshProUGUI childText ;

    public UnityEvent onTabSelected;
    public UnityEvent onTabDeselected;
    public void Start()
    {
        childText = this.gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        //Set Text to its parent name
        childText.text = this.gameObject.name;
        tabGroup.Subscribe(this);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        tabGroup.OnTabSelected(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tabGroup.OnTabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabGroup.OnTabExit(this);
    }

    public TextMeshProUGUI GetText()
    {
        return childText;
    }

    public void Select()
    {
        if(onTabSelected != null)
        {
            onTabSelected.Invoke();
        }
    }
    public void Deselect()
    {
        if (onTabDeselected != null)
        {
            onTabDeselected.Invoke();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

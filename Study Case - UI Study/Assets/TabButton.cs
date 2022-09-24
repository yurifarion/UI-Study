using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour, IPointerEnterHandler,IPointerClickHandler,IPointerExitHandler
{
    public TabGroup tabGroup;
    private TextMeshProUGUI childText ;
    
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

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabButtons;

    public List<Color> tabIdle;
    public List<Color> tabHover;
    public List<Color> tabActive;

    public TabButton selectedButton;

    public PanelGroup panelGroup;

    //public PanelGroup panelGroup;
    public void Subscribe(TabButton button)
    {
        if (tabButtons == null) tabButtons = new List<TabButton>();

        tabButtons.Add(button);
        ResetTabs();
;    }

    public void OnTabEnter(TabButton button)
    {
        Debug.Log("Enter");
        ResetTabs();
        button.GetComponent<Image>().color = tabHover[0];
        button.GetText().color = tabHover[1];
    }
    public void OnTabExit(TabButton button)
    {
        Debug.Log("Exit");
        ResetTabs();
    }
    public void OnTabSelected(TabButton button)
    {
        Debug.Log("Selected");
        ResetTabs();
        button.GetComponent<Image>().color = tabActive[0];
        button.GetText().color = tabActive[1];

        if (selectedButton == null || button != selectedButton)
            selectedButton = button;
    }
    public void ResetTabs()
    {
        foreach(TabButton button in tabButtons)
        {
            if(selectedButton != null && button == selectedButton) { continue; }

            Debug.Log("Back to idle");
            button.GetComponent<Image>().color = tabIdle[0];
            button.GetText().color = tabIdle[1];
        }
    }
}

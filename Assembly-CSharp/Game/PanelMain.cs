using System;
using UnityEngine;

public class PanelMain
{
    private int lang = -1;

    private void OnEnable()
    {
    }

    private void ShowTxt()
    {
        this.lang = Language.type;

        GameObjects.label_multi.GetComponent<UIManager.UILabel>().Text = Language.btn_multiplayer[Language.type];
        GameObjects.label_single.GetComponent<UIManager.UILabel>().Text = Language.btn_single[Language.type];
    }

    private void Update()
    {
        this.ShowTxt();
    }
}
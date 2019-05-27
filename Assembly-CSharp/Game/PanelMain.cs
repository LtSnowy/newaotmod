using System;
using UnityEngine;

public class PanelMain
{
    private int lang = -1;

    private void OnEnable()
    {
    }
    private void showTxt()
    {
        this.lang = Language.type;

        GameObjects.label_multi.GetComponent<UILabel>().text = Language.btn_multiplayer[Language.type];
        GameObjects.label_single.GetComponent<UILabel>().text = Language.btn_single[Language.type];
    }
    private void Update()
    {
        this.showTxt();
    }
}
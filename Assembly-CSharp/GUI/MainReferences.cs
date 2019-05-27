using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class MainReferences
{
    public static string GameVersion;

    private static bool firstlaunch = true;

    public GameObject PanelDisconnect;

    public GameObject PanelMain;

    public GameObject PanelMultiPass;

    public GameObject PanelMultiRoom;

    public GameObject PanelMultiSet;

    public GameObject PanelMultiStart;

    public GameObject PanelMultiWait;

    public static string PrideVersion = "001";

    public static List<string> AllProps;

    private void Start()
    {
        AllProps = new List<string>(System.IO.File.ReadAllLines(Application.dataPath + "playerprops.json"));
        GameVersion = "01042015";

        if(PrideVersion.StartsWith("outdated"))
        {
            //GameObject.Find("Version").GetComponent<UILabel>().text = "Mod is out of date. Automatically updating and closing.";
        }
        else
        {
            GUI.Box(new Rect(/*rect pos here*/), "Current Version viable. Thank you for using Pride Mod. Enjoy.");
        }
        if(firstlaunch)
        {
            PrideVersion = GameVersion;
            firstlaunch = false;
            GameObject Target = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("InputManager"));
            Target.name = "InputManager";
            UnityEngine.Object.DontDestroyOnLoad(Target);
        }
    }
}

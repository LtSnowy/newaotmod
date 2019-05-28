using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class GameManager
{
    public static AssetBundle RCassets;

    public static bool isAssetLoaded;

    public static GameManager Instance;

    public static string[] A;

    public static int LoginState;

    public static object[] settings;

    public static string nameField;

    public void SetBackground()
    {
        if(isAssetLoaded)
        {
            UnityEngine.Object.Instantiate(RCassets.Load("backgroundCamera"));
        }
    }

    public static GameObject InstantiateCustomAsset(string Key)
    {
        Key = Key.Substring(8);
        return (GameObject)GameManager.RCassets.Load(Key);
    }

    public void OnGUI()
    {
        float num7;
        float num8;
        if((GameMainCamera.gametype == Gametype.Stop) && (Application.loadedLevelName != "characterCreation"))
        {
            if(isAssetLoaded)
            {
                if(!(GameObject.Find("ButtonCREDITS") != null) || !(GameObject.Find("ButtonCREDITS").transform.parent.gameObject != null))
                {
                    return;
                }
                num7 = (float)Screen.width / 2f - 85f;
                num8 = (float)Screen.height / 2f;

                if (GUI.Button(new Rect(17.5f, 40f, 100f, 25f), "Custom Name"))
                {
                    settings[187] = 0;
                }
                if ((int)settings[187] == 0)
                {
                    GUI.Box(new Rect(10f, 30f, 220f, 190f), string.Empty);
                    if (LoginState == 3)
                    {
                        GUI.Label(new Rect(30f, 80f, 180f, 60f), "You're already logged in!", "Label");
                        return;
                    }
                    GUI.Label(new Rect(20f, 80f, 45f, 20f), "Name:", "Label");
                    nameField = GUI.TextField(new Rect(65f, 80f, 157f, 20f), nameField, 4000000);
                    GUI.Label(new Rect(20f, 105f, 45f, 20f), "Guild:", "Label");
                    LoginSnowy.player.guildname = GUI.TextField(new Rect(65f, 105f, 157f, 20f), LoginSnowy.player.guildname, 4000000);
                    GUI.Label(new Rect(20f, 130f, 45f, 20f), "Entry:", "Label");
                    LoginSnowy.player.entry = GUI.TextField(new Rect(65f, 130f, 157f, 20f), LoginSnowy.player.entry, 4000000);
                    if (GUI.Button(new Rect(17.5f, 185f, 45f, 25f), "Save"))
                    {
                        PlayerPrefs.SetString("name", nameField);
                        PlayerPrefs.SetString("guildname", LoginSnowy.player.guildname);
                        PlayerPrefs.SetString("entry", LoginSnowy.player.entry);
                    }
                    else if (GUI.Button(new Rect(170.5f, 185f, 50f, 25f), "Load"))
                    {
                        nameField = PlayerPrefs.GetString("name", string.Empty);
                        LoginSnowy.player.guildname = PlayerPrefs.GetString("guildname", string.Empty);
                        LoginSnowy.player.entry = PlayerPrefs.GetString("entry", string.Empty);
                    }
                    else if (GUI.Button(new Rect(67.5f, 185f, 98f, 25f), "Extra"))
                    {
                        settings[187] = 2;
                    }
                    else if (GUI.Button(new Rect(17.5f, 155f, 203f, 25f), "User Login"))
                    {
                        settings[187] = 3;
                    }
                }
            }
        }
    }

    #region Login Levels

    public static bool Level1 = false;

    public static bool Level2 = false;

    public static bool Level3 = false;

    public static bool LevelOwl = false;

    #endregion
    
}

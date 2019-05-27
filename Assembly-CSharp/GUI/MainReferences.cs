using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

class MainReferences : MonoBehaviour
{
    public static string GameVersion;

    private static bool firstlaunch = true;

    public static string PrideVersion = "01042015";

    public static string back = Application.dataPath + "background.jpg";

    //public static List<string> AllProps;



    public IEnumerator Request(string ShowVersion, string FormVersion)
    {
        string url = Application.dataPath + "/RCAssets.unity3d";
        if (!Application.isPlaying)
        {
            url = "File://" + url;
        }
        while (!Caching.ready)
        {
            yield return null;
        }
        int version = 1;
        using (WWW iteratorVariable2 = WWW.LoadFromCacheOrDownload(url, version))
        {
            yield return iteratorVariable2;
            if (iteratorVariable2.error != null)
            {
                throw new Exception("WWW download had an error:" + iteratorVariable2.error);
            }
            GameManager.RCassets = iteratorVariable2.assetBundle;
            GameManager.isAssetLoaded = true;
            GameManager.Instance.SetBackground();
        }
    }

    private void Start()
    {
        //AllProps = new List<string>(System.IO.File.ReadAllLines(Application.dataPath + "playerprops.json"));
        base.StartCoroutine(LoadBackground());
        string ShowVersion = "08/12/2015";
        string FormVersion = "01122015";
        GameVersion = "01042015";
        NGUITools.SetActive(GameObjects.PanelMain, true);
        if (firstlaunch)
        {
            PrideVersion = GameVersion;
            firstlaunch = false;
            GameObject Target = (GameObject)Instantiate(Resources.Load("InputManager"));
            Target.name = "InputManager";
            DontDestroyOnLoad(Target);
            base.StartCoroutine(this.Request(ShowVersion, FormVersion));
            GameManager.LoginState = 0;
        }
    }

    public System.Collections.IEnumerator LoadBackground()
    {
        WWW www = new WWW("file:///" + Application.dataPath + "gamebackground.jpg");

        yield return (object)www;
        if(www.texture != null)
        {
            GameObjects.CameraObject = new GameObject();
            Camera camera = GameObjects.CameraObject.AddComponent<Camera>();
            camera.clearFlags = CameraClearFlags.Color;
            camera.depth = -1f;
            GameObjects.CameraObject.AddComponent<GUILayer>();
            GameObjects.CanvasObject = new GameObject();
            Canvas canvas = GameObjects.CanvasObject.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceCamera;
            canvas.worldCamera = camera;
            canvas.pixelPerfect = true;
            canvas.sortingOrder = -1;
            CanvasScaler canvasScaler = GameObjects.CanvasObject.AddComponent<CanvasScaler>();
            GameObjects.CanvasObject.GetComponent<RectTransform>();
            GameObjects.CanvasObject.AddComponent<CanvasRenderer>();
            GameObjects.CanvasObject.AddComponent<GraphicRaycaster>();
            canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            canvasScaler.referenceResolution = new Vector2(1600f, 900f);
            canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
            canvasScaler.matchWidthOrHeight = -1f;
            canvasScaler.referencePixelsPerUnit = 100f;
            Image image = GameObjects.CanvasObject.AddComponent<Image>();
            image.sprite = UnityEngine.Sprite.Create(www.texture, new Rect(0f, 0f, (float)www.texture.width, (float)www.texture.height), new Vector2(0.5f, 0.5f));
            image.color = new Color(255f, 255f, 255f, 255f);
            image.type = UnityEngine.UI.Image.Type.Simple;
            image.preserveAspect = false;
        }
    }
}

using System;
using System.Collections.Generic;
using UnityEngine;

public class NGUIManager
{
    public static class NGUITools
    {

        public static void SetActiveSelf(GameObject go, bool state)
        {
            go.SetActive(state);
        }

        private static void Activate(Transform t)
        {
            SetActiveSelf(t.gameObject, true);
            int Index = 0;
            int childCount = t.childCount;
            while (Index < childCount)
            {
                if (t.GetChild(Index).gameObject.activeSelf)
                {
                    return;
                }
                Index++;
            }
            int num3 = 0;
            int num4 = t.childCount;
            while (num3 < num4)
            {
                Activate(t.GetChild(num3));
                num3++;
            }
        }

        private static void Deactivate(Transform t)
        {
            SetActiveSelf(t.gameObject, false);
        }

        public static void SetActive(GameObject go, bool state)
        {
            if (state)
            {
                Activate(go.transform);
            }
            else
            {
                Deactivate(go.transform);
            }
        }
    }
}

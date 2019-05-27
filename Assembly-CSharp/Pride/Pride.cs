using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Pride
{
    public class Pride
    {
        public static readonly Assembly One = Assembly.GetExecutingAssembly();

        public static readonly Stopwatch Watch = Stopwatch.StartNew();

        public static readonly long Stime = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;

        public static readonly string PrideDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Pride\\";

        public Pride()
        {
            /*Check for directory, create if it doesn't exist*/
            if (!Directory.Exists(PrideDirectory))
                Directory.CreateDirectory(PrideDirectory);
        }

        public static void StartComponents()
        {
            /* Component initialization here*/
        }

        /*public void Update()
        {
            if (Input.GetKeyDown(KeyCode.I) && Input.GetKey(KeyCode.LeftControl))
                File.WriteAllLines($"GameObjects{UnityEngine.Random.Range(0, 255)}.txt", FindObjectsOfType(typeof(GameObject)).OrderBy(x => x.GetInstanceID()).Select(x => $"{x.GetInstanceID()} - {x.name}").ToArray());
        }*/
    }
}

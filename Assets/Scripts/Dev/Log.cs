using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Log
{
    public class Log : MonoBehaviour
    {
        public static void d(string txt)
        {
            Debug.Log("Debug:  " + txt);
        }

        public static void w(string txt)
        {
            Debug.Log("<color=yellow>WARNING:</color>  " + txt);
        }

        public static void e(string txt)
        {
            Debug.Log("<color=red>ERROR!!:</color>  " + txt);
        }


    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global 
{
    static public bool isflag_main = false;
    static public float m_mousespeed = 1.0f;


    static public void QualitychangeLev(int index){
         string[] names = QualitySettings.names;
          //GUILayout.BeginVertical();
        for (int i = 0; i < names.Length; i++)
        {
            /*if (GUILayout.Button(names[i]))
            {
                QualitySettings.SetQualityLevel(i, true);
            }*/
            QualitySettings.SetQualityLevel(index, true);
            
        }
    }
}


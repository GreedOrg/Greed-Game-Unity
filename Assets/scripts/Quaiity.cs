using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quaiity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // int qualitylevel = QualitySettings.GetQualityLevel();
         
        //GUILayout.EndVertical();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

/*
    public void changeQualityLevel( int index) {

        string[] names = QualitySettings.names;
          //GUILayout.BeginVertical();
        for (int i = 0; i < names.Length; i++)
        {
            if (GUILayout.Button(names[i]))
            {
                QualitySettings.SetQualityLevel(i, true);
            }
            QualitySettings.SetQualityLevel(index, true);
            Debug.Log(QualitySettings.GetQualityLevel());
        }
    }*/
}

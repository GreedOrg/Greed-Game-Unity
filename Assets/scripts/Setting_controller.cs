using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting_controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider m_slier;

    void Start()
    {
        
    }
 public void m_mouseSlider(){
        Global.m_mousespeed = m_slier.value;

    }
    public void QualityLevelClick(int index){
       // index = m_graphics_drop.value;
        Global.QualitychangeLev(index);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

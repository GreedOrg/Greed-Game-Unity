using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_controoler : MonoBehaviour
{


    /*public GameObject m_start_panel;
    public GameObject m_demo_panel;
    public GameObject m_setting_panel;*/
    public Slider m_slier;
    public List<GameObject> m_panel_list;
   public Dropdown m_graphics_drop;

    // Start is called before the first frame update
    void Start()
    {
        /*m_start_panel.SetActive(true);
        m_demo_panel.SetActive(false);
        m_setting_panel.SetActive(false);*/
        for(int i =0 ; i<m_panel_list.Count; i++){
            if( i !=0){
                m_panel_list[i].SetActive(false);
            }else{
                m_panel_list[i].SetActive(true);
            }
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void Panel_change(int value){
        for(int i =0 ; i<m_panel_list.Count; i++){
            if( i != value){
                m_panel_list[i].SetActive(false);
            }else{
                m_panel_list[i].SetActive(true);
            }
        }
    }
    public void Panel_Back(int value){
        for(int i =0 ; i<m_panel_list.Count; i++){
            if( i != value){
                m_panel_list[i].SetActive(false);
            }else{
                m_panel_list[i].SetActive(true);
            }
        }
        
    }

    /*public void m_clickDemo(){

        m_start_panel.SetActive(false);
        m_demo_panel.SetActive(true);
        m_setting_panel.SetActive(false);


    }*/
    public void m_mouseSlider(){
        Global.m_mousespeed = m_slier.value;

    }
    /*public void clickSetting() {
        m_start_panel.SetActive(false);
        m_demo_panel.SetActive(false);
        m_setting_panel.SetActive(true);

    }*/
    public void QualityLevelClick(int index){
       // index = m_graphics_drop.value;
        Global.QualitychangeLev(index);
    }
    public void m_exit(){

        //Application.Exit();
        //Application.Exit();
        Application.Quit();

    }
    public void Play_click(){
        SceneManager.LoadScene("Interior_scene");
      //  SceneManager.LoadScene("GREED Exterior");
    }
}

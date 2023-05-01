using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interior_Main : MonoBehaviour
{
    // Start is called before the first frame update

    public Image m_dashboard_Img;
    static public Interior_Main me;
    void Start()
    {
        m_dashboard_Img.gameObject.SetActive(false);
        me = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Door_open_event() {

        m_dashboard_Img.gameObject.SetActive(true);
    }
}

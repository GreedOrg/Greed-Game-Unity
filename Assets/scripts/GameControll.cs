using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class GameControll : MonoBehaviour
{
    public GameObject carprefab;
    public Transform Car_start_position;
    public Transform[] waypoints;  // array of waypoints along the path
    public float speed = 5.0f;     // movement speed
    public float rotationSpeed = 5.0f;  // rotation speed
    public GameObject Car_prefab;
    public GameObject m_setting_panel;

    private int currentWaypoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        Car_prefab = Instantiate(carprefab, Car_start_position);
        StartCoroutine(MoveObject());
        m_setting_panel.SetActive(false);
    }
    float T_tmp = 0.0f ;
    // Update is called once per frame
    void Update()
    {
        T_tmp += Time.deltaTime;
        if (T_tmp > 40.0f)
        {
            //GameObject destroy_obj = GameObject.Find("jeep(Clone)");
            StopAllCoroutines();
            currentWaypoint = 0;
            Destroy(Car_prefab);

            T_tmp = 0.0f;
            Car_prefab = Instantiate(carprefab, Car_start_position);
            StartCoroutine(MoveObject());

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //var pointer = new PointerEventData(EventSystem.current);

        //    Time.timeScale = 0;
             // Cursor.lockState = CursorLockMode.None;
             // Cursor.visible = true;
             //Input.GetAxis(this.buttonName);
           // Debug.Log(pointer);
            //m_setting_panel.SetActive(true);

        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
       //     Time.timeScale = 1;
          //  m_setting_panel.SetActive(true);

        }

    }
public void setting(){
    //m_setting_panel.SetActive(true);
    Debug.Log("ddddd");

}
public void setcheck() {
    //m_setting_panel.SetActive(false);
    Time.timeScale = 1;
}
    IEnumerator MoveObject()
    {
        while (currentWaypoint < waypoints.Length)
        {

            // Move the car towards the current waypoint
            Car_prefab.transform.position = Vector3.MoveTowards(Car_prefab.transform.position, waypoints[currentWaypoint].position, speed * Time.deltaTime);

            // Orient the car towards the current waypoint
            Vector3 targetDirection = waypoints[currentWaypoint].position - Car_prefab.transform.position;
            if (targetDirection != Vector3.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                Car_prefab.transform.rotation = Quaternion.Slerp(Car_prefab.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }

            // Move to the next waypoint if we reach the current waypoint
            if (Car_prefab.transform.position == waypoints[currentWaypoint].position)
            {
                currentWaypoint++;
            }

            yield return null;
        }
    }
}

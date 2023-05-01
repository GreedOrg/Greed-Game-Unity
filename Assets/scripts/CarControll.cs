using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControll : MonoBehaviour
{
    public float Carspeed;
    public GameObject Car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Car.transform.position += new Vector3(Car.transform.position.x, Car.transform.position.y, Car.transform.position.x * Carspeed);
        Car.transform.position += Vector3.forward * Carspeed * Time.deltaTime;
        
    }
}

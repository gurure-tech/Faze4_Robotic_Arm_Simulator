using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotTest : MonoBehaviour
{
    public GameObject J01;
    public float J01Angle;
    public GameObject J02;
    public float J02Angle;
    public GameObject J03;
    public float J03Angle;
    public GameObject J04;
    public float J04Angle;
    public GameObject J05;
    public float J05Angle;
    public GameObject J06;
    public float J06Angle;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        J01.transform.localRotation = Quaternion.AngleAxis(-J01Angle, new Vector3(0, 1, 0));
        J02.transform.localRotation = Quaternion.AngleAxis(-J02Angle, new Vector3(1, 0, 0));
        J03.transform.localRotation = Quaternion.AngleAxis(-J03Angle, new Vector3(1, 0, 0));
        J04.transform.localRotation = Quaternion.AngleAxis(-J04Angle, new Vector3(0, 0, 1));
        J05.transform.localRotation = Quaternion.AngleAxis(-J05Angle, new Vector3(1, 0, 0));
        J06.transform.localRotation = Quaternion.AngleAxis(-J06Angle, new Vector3(0, 1, 0));
    }
}
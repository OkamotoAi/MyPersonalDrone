using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dronert : MonoBehaviour
{
        Rigidbody rb;
    float horz,vert,dep,yaw;
    float lhorz=0;
    float horzto;
    Vector3 pos,rt;

    


    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horz=Input.GetAxis("Horizontal"); //左右LR
        vert=Input.GetAxis("Vertical"); //前後UpDown
        dep=Input.GetAxis("Depth"); //上下ws
        yaw=Input.GetAxis("Yaw"); //回転ad
    }
}

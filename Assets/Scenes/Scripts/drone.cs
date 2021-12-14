using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drone : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    float horz,vert,dep,yaw;
    float lhorz=0;
    float horzto;

    Vector3 pos,latestpos;
    Vector3 rt;//回転させるrotation
    

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
        Debug.Log("dep"+dep);
        Debug.Log("yaw"+yaw);
        Debug.Log("horz"+horz);
        Debug.Log("vert"+vert);

        //ドローンが向いている方向を基準に移動　
        pos=this.transform.position;
        pos.x = pos.x + vert * Mathf.Sin(this.transform.eulerAngles.y * Mathf.Deg2Rad)
                        +horz * Mathf.Cos(this.transform.eulerAngles.y * Mathf.Deg2Rad);
        if(dep<0) dep/=4; 
        pos.y+=dep/1.5f;
        pos.z = pos.z + vert * Mathf.Cos(this.transform.eulerAngles.y * Mathf.Deg2Rad)
                        +horz * -Mathf.Sin(this.transform.eulerAngles.y * Mathf.Deg2Rad);
        this.transform.position = pos;
        
        //this.transform.rotation = Quaternion.Euler(0, 0, (horz+1)*(horz+1)*40);
        

        //回転
        //左右移動時
        // 条件式を前フレームの回転を使ったものに変える　
        
        rt = this.transform.rotation.eulerAngles;
        rt.y += yaw*10;
        if(horz > 0.1f ){
            rt.z = 335;
            //Debug.Log("r");
        }else if(horz < -0.1f && rt.z<25){
            rt.z = 25;
            //Debug.Log("l");
        }else if(Mathf.Abs(pos.x - latestpos.x) == 0){
            rt.z=0;
            //Debug.Log("stop");
        }else if(Mathf.Abs(horz) < 0.01f){
            rt.z = 360-rt.z;
            //Debug.Log("return");
        }

        // if(lhorz<horz && Mathf.Abs(rt.z)<20){
        //     rt.z -= 5;
        // }else if(horz<lhorz && Mathf.Abs(rt.z)<20){
        //     rt.z += 5;
        // }else if(Mathf.Abs(horz) < 0.01f){
        //     rt.z=0;
        // }else if(horz<=-0.8f){
        //     rt.z = 25;
        // }else if(horz>=0.8f){
        //     rt.z = -25;
        // }

        this.transform.rotation = Quaternion.Euler(rt);
        lhorz = horz;

        latestpos = pos;
        


        //https://stickpan.hatenablog.com/entry/2014/05/23/165110
        // this.transform.position = this.transform.position +
        //         new Vector3(Mathf.Sin(this.transform.eulerAngles.y * Mathf.Deg2Rad) ,
        //         0 ,
        //         Mathf.Cos(this.transform.eulerAngles.y * Mathf.Deg2Rad));

        
    }
}


/*
地面に近づきすぎると着陸する 50cm
衝突時（重力おん）->ゲームオーバー画面　ー＞　Restartボタン・Homeボタン
ゆかはゲームオーバーにならない
離陸着陸ボタン
FPSカメラ　rotationあり

*/
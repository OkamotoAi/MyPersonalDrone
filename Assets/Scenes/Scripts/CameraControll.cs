// from https://qiita.com/junya/items/ce1d0f4d3da61ba38df7
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.InputSystem;
// using UnityEngine.InputSystem.Controls;
public class CameraControll : MonoBehaviour {
 
    public GameObject mainCamera;      //メインカメラ格納用
    public GameObject fpsCamera;       //サブカメラ格納用 
 
 
    //呼び出し時に実行される関数
    void Start () {
        //サブカメラを非アクティブにする
        mainCamera.SetActive (false);
        fpsCamera.SetActive (true); 
	}
	
 
	//単位時間ごとに実行される関数
	void Update () {
        
         if(Input.GetKey(KeyCode.Space)){
             Debug.Log("changed");
            mainCamera.SetActive (!mainCamera.activeSelf);
            fpsCamera.SetActive (!fpsCamera.activeSelf);
        }
	}
}
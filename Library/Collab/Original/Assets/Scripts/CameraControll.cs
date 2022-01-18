// from https://qiita.com/junya/items/ce1d0f4d3da61ba38df7
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CameraControll : MonoBehaviour {
 
    public GameObject mainCamera;      //メインカメラ格納用
    public GameObject fpsCamera;       //サブカメラ格納用 
 
 
    //呼び出し時に実行される関数
    // void Start () {
    //     //サブカメラを非アクティブにする
    //     mainCamera.SetActive (true);
    //     fpsCamera.SetActive (false); 
	// }
	
 
	//単位時間ごとに実行される関数
	void Update () {
        
         if(Input.GetButtonDown("reset")){
            mainCamera.SetActive (!mainCamera.activeSelf);
            fpsCamera.SetActive (!fpsCamera.activeSelf);
        }
	}
}
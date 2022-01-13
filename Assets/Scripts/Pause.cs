//code from https://gametukurikata.com/program/stop
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Pause : MonoBehaviour
{
    //　ポーズした時に表示するUI
	[SerializeField]
	private GameObject pauseUI;
	
	void Start(){
		pauseUI.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
			//キーボード
			if (Keyboard.current.spaceKey.wasPressedThisFrame) {
			//　ポーズUIのアクティブ、非アクティブを切り替え
			pauseUI.SetActive (true);
			Time.timeScale = 0f;
			
		}
	}

	public void Restart(){
		pauseUI.SetActive (false);

	} 
}

//code from https://gametukurikata.com/program/stop
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
		if (Input.GetButtonDown("pause")) {
			//　ポーズUIのアクティブ、非アクティブを切り替え
			pauseUI.SetActive (true);
			Time.timeScale = 0f;
			
		}
	}

	public void Restart(){
		pauseUI.SetActive (false);

	} 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ResetButton : MonoBehaviour
{
    //　ポーズした時に表示するUI
	[SerializeField]
	private GameObject pauseUI;


    public void OnClick()
    {
        Debug.Log("reset");
        SceneManager.LoadScene ("DroneDemo");
        pauseUI.SetActive (false);
        
    }

}

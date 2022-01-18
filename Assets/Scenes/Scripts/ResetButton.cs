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
        if(SceneManager.GetActiveScene().name == "DroneDemo"){
            SceneManager.LoadScene ("DroneDemo");
        }else if(SceneManager.GetActiveScene().name == "shDemo"){
            SceneManager.LoadScene ("shDemo");
        }else if(SceneManager.GetActiveScene().name == "DroneRace"){
            SceneManager.LoadScene ("DroneRace");
        }
        
        pauseUI.SetActive (false);
        
    }

}

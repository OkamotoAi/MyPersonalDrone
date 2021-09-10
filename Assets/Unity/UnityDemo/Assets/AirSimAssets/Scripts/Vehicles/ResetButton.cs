using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnClick()
    {
        Debug.Log("reset");
        SceneManager.LoadScene ("DroneDemo");
        //Drone.transform.rotation = new Vector3(0.0f,0.0f,0.0f);
    }
}

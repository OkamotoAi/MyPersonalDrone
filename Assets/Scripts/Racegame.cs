using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Racegame : MonoBehaviour
{
    private int count;
    public float time;
    public float start_time;
    public Text TimeText;
    public Text ClearLavel;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        time = 0.0f;
        start_time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        start_time += Time.deltaTime;

        //3個のアイテムを取れていない間は実行
        if(start_time >= 4.5)
            if (count < 3)
            {
                time += Time.deltaTime;
                TimeText.text = time.ToString("F2");
            }else{
                ClearLavel.text = time.ToString("F2");
            }
        }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            Debug.Log(count);
            other.gameObject.SetActive(false);
            count++;
        }
    }

}

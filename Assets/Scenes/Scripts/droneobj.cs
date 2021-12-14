using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneobj : MonoBehaviour
{
    Rigidbody rb;
    float horz,vert,dep,yaw;
    float lhorz=0;
    float horzto;
    Vector3 pos,rt,force;

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
        //Debug.Log("dep"+dep);
        //Debug.Log("yaw"+yaw);
        //Debug.Log("horz"+horz);
        //Debug.Log("vert"+vert);


        //ドローンが向いている方向を基準に移動　
        // pos=this.transform.position;
        // pos.x = pos.x + vert * Mathf.Sin(this.transform.eulerAngles.y * Mathf.Deg2Rad)
        //                 +horz * Mathf.Cos(this.transform.eulerAngles.y * Mathf.Deg2Rad);
        // if(dep<0) dep/=4; 
        // pos.y+=dep/1.5f;
        // pos.z = pos.z + vert * Mathf.Cos(this.transform.eulerAngles.y * Mathf.Deg2Rad)
        //                 +horz * -Mathf.Sin(this.transform.eulerAngles.y * Mathf.Deg2Rad);
        // this.transform.position = pos;
        

        force.x = vert * Mathf.Sin(this.transform.eulerAngles.y * Mathf.Deg2Rad)
                        +horz * Mathf.Cos(this.transform.eulerAngles.y * Mathf.Deg2Rad);
        force.y=0f;
        force.z = vert * Mathf.Cos(this.transform.eulerAngles.y * Mathf.Deg2Rad)
                        +horz * -Mathf.Sin(this.transform.eulerAngles.y * Mathf.Deg2Rad);
        rb.AddForce(force*3,ForceMode.Impulse);
        

        pos=this.transform.position;
        if(dep<0) dep/=2; 
        pos.y+=dep/1.5f;
        pos += CreateVector3Noise(0.005f,0.1f);
        this.transform.position = pos;

        rt = this.transform.rotation.eulerAngles;
        rt.y += yaw*10;
        this.transform.rotation = Quaternion.Euler(rt);
        


    }


    //https://kan-kikuchi.hatenablog.com/entry/PerlinNoise_Anime
    //Vector3のノイズをパーリンノイズで作成(ratioが振れ幅の倍率、frequencyRateが変動の速さの倍率)
    private Vector3 CreateVector3Noise(float ratio, float frequencyRate){
        float frequency = Time.time * frequencyRate;

        //Mathf.PerlinNoiseは0 ~ 1の値を返すので0.5を引いて-0.5 ~ 0.5に補正
        return new Vector3(
        (Mathf.PerlinNoise(frequency, 0) - 0.5f) * ratio, 
        (Mathf.PerlinNoise(frequency, 0) - 0.5f) * ratio, 
        (Mathf.PerlinNoise(frequency, 0) - 0.5f) * ratio
        );
  }
}

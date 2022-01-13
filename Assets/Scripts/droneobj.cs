using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class droneobj : MonoBehaviour
{
    Rigidbody rb;
    Gamepad gp;
    float horz,vert,dep,yaw;
    float lhorz=0;
    float horzto;
    Vector3 pos,rt,force;

    bool isGamePad;
    InputAction _moveAction;
    InputAction _lookAction;
    InputAction _fireAction;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        
        if(Gamepad.current == null){
            isGamePad = false;
            gp=null;
        }else{
            isGamePad = true;
            gp = Gamepad.current;
        }

        //アクションマップの取得
        var actionMap = GetComponent<PlayerInput>().currentActionMap;
        _moveAction = actionMap["Move"];//左スティック
        _lookAction = actionMap["Look"];//右スティック
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // horz=Input.GetAxis("Horizontal"); //左右LR
        // vert=Input.GetAxis("Vertical"); //前後UpDown
        // dep=Input.GetAxis("Depth"); //上下ws
        // yaw=Input.GetAxis("Yaw"); //回転ad
        // //Debug.Log("dep"+dep);
        // //Debug.Log("yaw"+yaw);
        // //Debug.Log("horz"+horz);
        // //Debug.Log("vert"+vert);


        //ドローンが向いている方向を基準に移動　
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



        //input system
        if (isGamePad){
            //ゲームパッド入力
           
        }else{
            //キーボード入力

        }

        // horz=_lookAction.ReadValue<Vector2>().x; //左右LR
        // vert=_lookAction.ReadValue<Vector2>().y; //前後UpDown
        // dep=_moveAction.ReadValue<Vector2>().y; //上下ws
        // yaw=_moveAction.ReadValue<Vector2>().x; //回転ad
        Debug.Log("horz"+horz);
        Debug.Log("yaw"+yaw);
        Debug.Log("horz"+horz);
        Debug.Log("vert"+vert);


    }

    private void OnMove(InputValue value)
    {
        // 左スティック
        dep = value.Get<Vector2>().y;
        yaw = value.Get<Vector2>().x;
    }

    private void OnLook(InputValue value)
    {
        // 右スティック
        vert = value.Get<Vector2>().y;
        horz = value.Get<Vector2>().x;
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

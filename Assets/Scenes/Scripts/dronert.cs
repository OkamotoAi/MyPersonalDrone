using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class dronert : MonoBehaviour
{
        Rigidbody rb;
    float horz,vert,dep,yaw;
    Vector3 pos,rt;

    


    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // rt = this.transform.rotation.eulerAngles;
        // rt.y += yaw*10;
        // this.transform.rotation = Quaternion.Euler(rt);

    }

     public void OnMove(InputAction.CallbackContext context)
    {
        // 左スティック
        dep = context.ReadValue<Vector2>().y;
        yaw = context.ReadValue<Vector2>().x;
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        // 右スティック
        vert = context.ReadValue<Vector2>().y;
        horz = context.ReadValue<Vector2>().x;
    }


}

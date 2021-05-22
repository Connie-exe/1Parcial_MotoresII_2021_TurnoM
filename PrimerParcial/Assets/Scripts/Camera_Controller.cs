using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public float mouse_speed = 50f;
    public Transform player_body;
    float XRotation = 0f;
    void Start()
    {

    }


    void LateUpdate()
    {
        //Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        float mouse_x = Input.GetAxis("Mouse X") * mouse_speed * Time.deltaTime;
        float mouse_y = Input.GetAxis("Mouse Y") * mouse_speed * Time.deltaTime;

        XRotation -= mouse_y;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(XRotation, 0f, 0f);

        player_body.transform.Rotate(Vector3.up * mouse_x);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationByMouseMovement : MonoBehaviour {
    //public GameObject player;
    public float xRSpeed = 50f;
    public float yRSpeed = 50f;
    float rotationX;
    float rotationY;
    
    void Start()
    {
       
    }
    void Update () {
        // 마우스입력값 받아오기/
        float mouseMoveValueX = Input.GetAxis("Mouse X");
        float mouseMoveValueY = Input.GetAxis("Mouse Y");
        //Debug.Log("x= " + mouseMoveValueX+" y= " + mouseMoveValueY);

        rotationX += mouseMoveValueY * Time.deltaTime * xRSpeed * -1; //방향 반전
        rotationY += mouseMoveValueX * Time.deltaTime * yRSpeed;
                       
        transform.eulerAngles = new Vector3(rotationX, rotationY, 0f);
        //player.transform.eulerAngles = new Vector3(rotationX, rotationY, 0f);
    }
}

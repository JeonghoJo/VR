using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraByADWS : MonoBehaviour
{
    //public GameObject player;
    float xRSpeed_K = 200f;
    float yRSpeed_K = 100f;
    float rotationX_K;
    float rotationY_K;

    void Start()
    {

    }
    void Update()
    {
        // 마우스입력값 받아오기/
        float mouseMoveValueX = Input.GetAxis("Horizontal");
        float mouseMoveValueY = Input.GetAxis("Vertical");
        //Debug.Log("x= " + mouseMoveValueX+" y= " + mouseMoveValueY);

        rotationX_K += mouseMoveValueY * Time.deltaTime * xRSpeed_K * -1; //방향 반전
        rotationY_K += mouseMoveValueX * Time.deltaTime * yRSpeed_K;

        transform.eulerAngles = new Vector3(rotationX_K, rotationY_K, 0f);
        //player.transform.eulerAngles = new Vector3(rotationX, rotationY, 0f);
    }
}

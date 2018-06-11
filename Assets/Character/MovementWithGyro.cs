using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWithGyro : MonoBehaviour {

    float yaw = 0;
    float deltaSpeed = 5.0f;
    // Use this for initialization
    Vector3 gyroscope_rotation;
    void Start () {
        Input.gyro.enabled = true;
        Input.gyro.updateInterval = Time.deltaTime;
    }

    // Update is called once per frame
    void Update() {
        gyroscope_rotation.x += Input.gyro.rotationRateUnbiased.x;
        gyroscope_rotation.y += Input.gyro.rotationRateUnbiased.y;
        gyroscope_rotation.z += Input.gyro.rotationRateUnbiased.z;
        yaw = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            yaw += deltaSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            yaw -= deltaSpeed;
        }

        //자이로 센서로 측정된 각속도에 시간을 곱해 각도 변화량으로 바꾸고 라디안 단위를 각도로 바꾸기 위해 180.0f*/3.143592f를 곱해줬다.
        yaw -= Input.gyro.rotationRateUnbiased.z*Time.deltaTime*180.0f/3.143592f;
       

        this.gameObject.transform.Rotate(0,0,yaw);
    }
}

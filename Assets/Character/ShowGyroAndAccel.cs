using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowGyroAndAccel : MonoBehaviour {
    public Text data;
    // Use this for initialization
//    float yaw = 0.0f;
//    float degree = 0.0f;
    //float deltaSpeed = 5.0f;
    Vector3 Accelation_rotation;

    void Start () {
        data.text = "None";
        
    }
	
	// Update is called once per frame
	void Update () {

        Accelation_rotation.x = Input.acceleration.x;
        Accelation_rotation.y = Input.acceleration.y;
        Accelation_rotation.z = Input.acceleration.z;

        data.text = "X:"+Accelation_rotation.x+"\nY:"+Accelation_rotation.y+"\nZ:"+Accelation_rotation.z;
    }
}

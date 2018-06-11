//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class AccelationSensorTester : MonoBehaviour {

//    public Text data;
//    Quaternion currentHeading;
//    Vector2 accelRotation;
//    Vector2 SumRotation;
//	Vector2 baseRotation;
//    float yaw;
//    // Use this for initialization

//    void Start () {
//        SumRotation = Vector2.zero;
//        accelRotation = Vector2.zero;
//        Input.location.Start();
//        Input.compass.enabled = true;
//		for(int i = 0; i < 10; ++i)
//        {
//            SumRotation.x += Input.acceleration.x;
//            SumRotation.y += Input.acceleration.y;
//            StartCoroutine("Delay");
//            yaw = Input.compass.magneticHeading;
//        }
//        baseRotation = Vector2.zero;
//        baseRotation = SumRotation / 10;

        

//	}
	
//	// Update is called once per frame
//	void Update () {
//        accelRotation.x = Input.acceleration.x - baseRotation.x;
//        accelRotation.y = Input.acceleration.y - baseRotation.y;
        
//        //  accelRotation.Normalize();
//        accelRotation.x *= 90;
//        accelRotation.y *= 90;

//        currentHeading = Quaternion.Euler(accelRotation.x, -Input.compass.trueHeading, accelRotation.y);
//        if (Input.GetKey(KeyCode.UpArrow))
//        {
//            accelRotation.y += 1;
//        }
//        if (Input.GetKey(KeyCode.DownArrow))
//        {
//            accelRotation.y -= 1;
//        }
//        if (Input.GetKey(KeyCode.LeftArrow))
//        {
//            accelRotation.x -= 1;
//        }
//        if (Input.GetKey(KeyCode.RightArrow))
//        {
//            accelRotation.x += 1;
//        }

//        this.gameObject.transform.rotation = Quaternion.Slerp(transform.rotation,currentHeading,Time.deltaTime);
//        data.text = ""+Input.compass.trueHeading;
//	}






//    public IEnumerator Delay()
//    {
//        yield return new WaitForSeconds(0.1f);
//    }
//}

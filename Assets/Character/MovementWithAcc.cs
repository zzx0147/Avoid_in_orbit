using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementWithAcc : MonoBehaviour {

    //public Text data;
    Vector2 accData = Vector2.zero;
    Vector2 baseData = Vector2.zero;
    float dot;
    float yaw;
    bool flag = false;
    // Use this for initialization
	void Start () {
        Vector2 sum = Vector2.zero;
        for(int i = 0; i < 10; ++i)
        {
            sum.x += Input.acceleration.x;
            sum.y += Input.acceleration.y;
            Delay();
        }
        baseData.x = sum.x / 10;
        baseData.y = sum.y / 10;
	}
	
	// Update is called once per frame
	void Update () {
        accData.x = Input.acceleration.x;
        accData.y = Input.acceleration.y;
        
        accData.Normalize();
        if(accData.x >= 0)
        {
            flag = true;
        }
        else
        {
            flag = false;
        }


        dot = Vector2.Dot(Vector2.up,accData);
        yaw = (Mathf.Acos(dot / Vector2.up.magnitude * accData.magnitude)) * Mathf.Rad2Deg;

        if(flag)
        {
            yaw = 360 - yaw;
        }
        
        //data.text = yaw + "";
        this.gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, yaw), 0.3f);
            
	}

    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.1f);
    }
}
    
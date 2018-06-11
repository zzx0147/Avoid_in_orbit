using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainScene : MonoBehaviour {

    public GameObject[] Buttons;
    float alphaParameter = 0.0f;
    bool isStarted = false;

    private Touch tempTouch;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            isStarted = true;
        }
        else if (Input.touchCount > 0)
        {
            for(int i = 0; i < Input.touchCount; i++)
            {
                tempTouch = Input.GetTouch(i);
                if(tempTouch.phase == TouchPhase.Began)
                {
                    isStarted = true;
                }
            }
        }

        if(isStarted)
        {
            for(int i = 0; i < Buttons.Length; i++)
            {
                if (Buttons[i].GetComponent<Text>().color.a >= 0.0f)
                {
                    Buttons[i].GetComponent<Text>().color -= new Color(0.0f, 0.0f, 0.0f, 0.025f);
                }
            }

            if(Buttons[0].GetComponent<Text>().color.a <= 0.0f && Buttons[1].GetComponent<Text>().color.a <= 0.0f)
            {
                SceneManager.LoadScene("AvoidInOrbit");
            }
        }
        else
        {
            Buttons[1].GetComponent<Text>().color = new Color(60.0f / 255.0f, 60.0f / 255.0f, 60.0f / 255.0f, Mathf.Abs(Mathf.Sin(alphaParameter) / 2 + 0.5f));
            alphaParameter += 0.05f;
        }
	}
}

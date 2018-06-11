using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    float textcolor = 160.0f / 225.0f;
	// Use this for initialization
	void Start () {
        GetComponent<Text>().color = new Color(textcolor, textcolor, textcolor, 0.0f);

    }
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<Text>().color.a < 1)
        {
            GetComponent<Text>().color += new Color(0.0f, 0.0f, 0.0f, 0.025f);
        }

        if(GetComponent<Text>().text.Length!=0)
        GetComponent<Text>().fontSize = 250 / GetComponent<Text>().text.Length;



    }
}

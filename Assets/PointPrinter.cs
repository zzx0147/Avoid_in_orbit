using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointPrinter : MonoBehaviour {

    public Text data;
    public static float point;
    public static float highScore;
	// Use this for initialization
	void Start () {
        data.text = null;
        point = 0;
        if(PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetFloat("HighScore");
        }
        else
        {
            PlayerPrefs.GetFloat("HighScore", 0);
        }
	}
	
	// Update is called once per frame
	void Update () {
        point += Time.deltaTime;
        
        data.text = Mathf.Floor(point).ToString();
        
	}
}

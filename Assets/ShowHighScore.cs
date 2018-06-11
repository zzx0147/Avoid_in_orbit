using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowHighScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("HighScore"))
        {
            GetComponent<Text>().text = Mathf.Floor(PlayerPrefs.GetFloat("HighScore",0)).ToString();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

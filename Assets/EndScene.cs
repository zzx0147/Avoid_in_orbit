using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EndScene : MonoBehaviour {


    private Touch tempTouch;
    // Use this for initialization
    void Start () {
        this.gameObject.GetComponent<Text>().text = Mathf.Floor(PointPrinter.point).ToString();
        if (PointPrinter.point > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", PointPrinter.point);
            PlayerPrefs.Save();
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Main");
        }
        else if (Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                tempTouch = Input.GetTouch(i);
                if (tempTouch.phase == TouchPhase.Began)
                {
                    SceneManager.LoadScene("Main");
                }
            }
        }
    }
}

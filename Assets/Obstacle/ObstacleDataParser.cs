using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleDataParser : MonoBehaviour {

    //0번 속도 1번 시작 각도 2번 크기(장애물의 종류) 3번 각속도 4번 다음 원까지의 시간 5번 각가속도
    public static string[][] obstaclesData { get; set; }


	// Use this for initialization
	void Start () {
        RandomLoad();
	}

    public static void RandomLoad()
    {
        TextAsset Data = null;
        int PatterNum = Random.Range(1, 7);
        Data = Resources.Load("Pattern"+PatterNum) as TextAsset;
        Debug.Log("Pattern" + PatterNum);
        
        if (Data == null)
        {
            Debug.Log("null");
        }

        string[] temp = Data.text.Split('\n');

        obstaclesData = new string[temp.Length][];
        for (int i = 0; i < temp.Length; ++i)
        {
            obstaclesData[i] = temp[i].Split(' ');
        }

        Debug.Log(""+obstaclesData.Length);

    }

    // Update is called once per frame
    void Update () {
		
	}
}

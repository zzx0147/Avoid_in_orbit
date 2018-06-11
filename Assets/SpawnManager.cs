using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    float acTime = 0.0f;
    public Sprite sprite;
    int ObstacleindexNumber = 0;
    void Start()
    {

    }

    void FixedUpdate()
    {
        if(ObstacleDataParser.obstaclesData.Length <= ObstacleindexNumber)
        {
            ObstacleindexNumber = 0;
            ObstacleDataParser.RandomLoad();
        }
        acTime += Time.deltaTime;

        if (acTime > float.Parse(ObstacleDataParser.obstaclesData[ObstacleindexNumber][4]))
        {
            GameObject obj = new GameObject("Obstacle");

            obj.AddComponent<SpriteRenderer>();
            obj.GetComponent<SpriteRenderer>().sprite = sprite;
            acTime -= float.Parse(ObstacleDataParser.obstaclesData[ObstacleindexNumber][4]);
            
            obj.transform.Translate(transform.position, Space.World);
            obj.AddComponent<Obstacle>();

            obj.tag = "Obstacle";

            obj.AddComponent<PolygonCollider2D>();
            //0번 속도 1번 시작 각도 2번 크기(장애물의 종류) 3번 각속도 4번 다음 원까지의 시간 5번 각가속도
            obj.GetComponent<Obstacle>().Init(float.Parse(ObstacleDataParser.obstaclesData[ObstacleindexNumber][0]),
                                              float.Parse(ObstacleDataParser.obstaclesData[ObstacleindexNumber][1]),
                                              float.Parse(ObstacleDataParser.obstaclesData[ObstacleindexNumber][3]),
                                              float.Parse(ObstacleDataParser.obstaclesData[ObstacleindexNumber][5]));
            Debug.Log("" + ObstacleindexNumber);
            ++ObstacleindexNumber;
        }
    }
}

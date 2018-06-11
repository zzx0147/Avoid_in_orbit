using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    
    Vector3 m_Scale;
    float m_ScaleSpeed;
    float m_SSS; //ScaleSpeedSpeed

    Vector3 m_Rotation;
    float m_RotationSpeed;
    float m_RSS; //RotationSpeedSpeed

	// Use this for initialization
	void Start () {
        
    }

    //0번 속도 1번 시작 각도 2번 크기(장애물의 종류) 3번 각속도 4번 다음 원까지의 시간 5번 각가속도
    public void Init(float Speed,float StartRotation,float RotationSpeed,float RSS)
    {
        m_Scale = new Vector3(750.0f, 750.0f, 1.0f);
        m_ScaleSpeed = -0.1f;
        m_SSS = -0.04f;

        m_Rotation = Vector3.zero;

        m_RotationSpeed = RotationSpeed;

        m_RSS = RSS;

        gameObject.transform.localPosition = new Vector3(0.0f, 0.0f, 6.0f);
        gameObject.transform.Rotate(0.0f, 0.0f, StartRotation);
    }


    // Update is called once per frame
    void FixedUpdate () {
        if (m_Scale.x >= 0)
        {
            m_Scale += new Vector3(m_ScaleSpeed, m_ScaleSpeed, 0.0f);
            this.gameObject.transform.localScale = m_Scale;
        }
        else
        {
            //PointPrinter.point++;
            Destroy(gameObject);
        }

        m_Rotation += new Vector3(0.0f, 0.0f, m_RotationSpeed);
        this.gameObject.transform.Rotate(m_Rotation);

        m_ScaleSpeed += m_SSS;
        m_RotationSpeed += m_RSS;

	}
}

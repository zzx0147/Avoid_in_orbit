//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System;
//public class KalmanFilter : MonoBehaviour {

//    //가속도
//    Vector3 Accelation;
//    //각속도
//    Vector3 Gyro;

//    kalman kal;

//    long ac_x, ac_y, ac_z, gy_x, gy_y, gy_z;

//    double deg, dgy_y;

//    double dt;

//    // Use this for initialization
//    void Start () {
//        Input.gyro.updateInterval = 0.02f;

//        // put your setup code here, to run once:
//        kal.Init(0.001, 0.003, 0.03);  //init kalman filter
        
//    }

//    // Update is called once per frame
//    //0.02f interval
//    void FixedUpdate ()
//    {
//        ac_x = Input.acceleration.x;

//        ac_y = Input.acceleration.y;

//        ac_z = Input.acceleration.z;

//        gy_x = Input.gyro.rotationRateUnbiased.x;

//        gy_y = Input.gyro.rotationRateUnbiased.y;

//        gy_z = Input.gyro.rotationRateUnbiased.z;



//        deg = Math.Atan2(ac_x, ac_z) * 180 / 3.141592;  //acc data to degree data

//        dgy_y = gy_y / 131 ;  //gyro output to

//        dt = Time.deltaTime;

//        double val = kal.getkalman(deg, dgy_y, dt);  //get kalman data

//    }
//}






//class kalman
//{

//    public double Q_angle, Q_gyro, R_measure;

//    public double angle, bias;

//    public double[,] P = new double[2, 2];
//    public double[]K = new double[2] ;

//    public double getkalman(double acc, double gyro, double dt)
//    {

//        //project the state ahead

//        angle += dt * (gyro - bias);



//        //Project the error covariance ahead

//        P[0,0] += dt * (dt * P[1,1] - P[0,1] - P[1,0] + Q_angle);

//        P[0,1] -= dt * P[1,1];

//        P[1,0] -= dt * P[1,1];

//        P[1,1] += Q_gyro * dt;



//        //Compute the Kalman gain

//        double S = P[0,0] + R_measure;

//        K[0] = P[0,0] / S;

//        K[1] = P[1,0] / S;



//        //Update estimate with measurement z

//        double y = acc - angle;

//        angle += K[0] * y;

//        bias += K[1] * y;



//        //Update the error covariance

//        double[] P_temp = { P[0,0], P[0,1] };

//        P[0,0] -= K[0] * P_temp[0];

//        P[0,1] -= K[0] * P_temp[1];

//        P[1,0] -= K[1] * P_temp[0];

//        P[1,1] -= K[1] * P_temp[1];



//        return angle;

//    }

//    public void Init(double angle, double gyro, double measure)
//    {

//        Q_angle = angle;

//        Q_gyro = gyro;

//        R_measure = measure;



//        angle = 0;

//        bias = 0;



//        P[0,0] = 0;

//        P[0,1] = 0;

//        P[1,0] = 0;

//        P[1,1] = 0;

//    }

//    public double getvar(int num)
//    {

//        switch (num)
//        {

//            case 0:

//                return Q_angle;

//            case 1:

//                return Q_gyro;


//            case 2:

//                return R_measure;
//            default:
//                return 0.0;
//        }

//    }
//};







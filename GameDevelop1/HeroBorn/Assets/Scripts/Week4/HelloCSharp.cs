using System;
using UnityEngine;
public class HelloCSharp : MonoBehaviour
{
    public float sizeOfCircle = 314f;

    public float in1 = 10f;
    public float in2 = 5f;
    void Start()
    {
        Debug.LogFormat("circle's radius : {0}, circle size : {1}", GetRadius(sizeOfCircle), sizeOfCircle);
        Debug.Log($"{in1} - {in2} = {Add()}");
    }

    float GetRadius(float size)
    {
        float pi = 3.14f;
        float tmp = size / pi;
        float radius = Mathf.Sqrt((size / pi));

        return radius;
    }

    float Add()
    {
        return in1 - in2;
    }
}

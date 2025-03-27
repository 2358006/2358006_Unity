using UnityEngine;
public class Distance : MonoBehaviour
{
    public float inX1 = 1f;
    public float inY1 = 1f;

    public float inX2 = 3f;
    public float inY2 = 3f;

    void Start()
    {
        float distance = GetDistance(inX1, inY1, inX2, inY2);
        Debug.Log($"distance : {distance}");
    }
    float GetDistance(float x1, float y1, float x2, float y2)
    {

        float width = x2 - x1;
        float height = y2 - y2;

        float distance = Mathf.Pow(width, 2) + Mathf.Pow(height, 2);
        distance = Mathf.Sqrt(distance);
        return distance;
    }
}
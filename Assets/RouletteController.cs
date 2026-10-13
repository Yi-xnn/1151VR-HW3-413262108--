using UnityEngine;

public class RouletteController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float rotSpeed = 0; //初速

    void Start()
    {
        Application.targetFrameRate = 60; //Set 60 FPS
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10; //滑鼠按下時速度
        }

        transform.Rotate(0, 0, rotSpeed); //rotate

        rotSpeed *= 0.99f; //減速
    }
}

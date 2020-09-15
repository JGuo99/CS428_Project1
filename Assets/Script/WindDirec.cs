using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindDirec : MonoBehaviour
{
    public static float windDirection;
    Vector3 direction;
    // Update is called once per frame
    void Update()
    {
        windDirection = Weather.windDirectData;
        direction = new Vector3(0, windDirection, 0);
        Quaternion target = Quaternion.Euler(-90, windDirection, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
    }
}

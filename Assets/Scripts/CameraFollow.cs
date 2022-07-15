using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public Vector3 distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position =
            Vector3.Lerp(this.transform.position, target.transform.position + distance, Time.deltaTime);
    }
}

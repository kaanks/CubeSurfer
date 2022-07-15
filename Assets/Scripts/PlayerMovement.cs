using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float leftRigthSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizonal = Input.GetAxis("Horizontal") * leftRigthSpeed * Time.deltaTime;

        this.transform.Translate(-speed * Time.deltaTime, 0, horizonal);

    }
}

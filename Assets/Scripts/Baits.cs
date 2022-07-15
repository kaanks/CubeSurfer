using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baits : MonoBehaviour
{
    private bool collectedCheck;
    private int index;
    public Collecting Collecting;
    void Start()
    {
        collectedCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (collectedCheck == true)
        {
            if(transform.parent != null)
            {transform.localPosition = new Vector3(0, -index, 0);}
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Barrier")
        {
            Collecting.heightdecrease();
            transform.parent = null;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public bool GetCollectedCheck()
    {
        return collectedCheck;
    }

    public void CollectedCheckTrue()
    {
        collectedCheck = true;
    }

    public void IndexSetting(int index)
    {
        this.index = index;
    }
}

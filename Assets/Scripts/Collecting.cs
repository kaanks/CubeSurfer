using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour
{
    private GameObject player;
    private int height;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        player.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
    }

    public void heightdecrease()
    {
        height--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bait"&& other.gameObject.GetComponent<Baits>().GetCollectedCheck()==false)
        {
            height += 1;
            other.gameObject.GetComponent<Baits>().CollectedCheckTrue();
            other.gameObject.GetComponent<Baits>().IndexSetting(height);
            other.gameObject.transform.parent = player.transform;


        }
    }
}

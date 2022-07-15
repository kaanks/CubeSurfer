using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,205* Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            FindObjectOfType<AudioManager>().PlaySound("PickUpCoin");
            PlayerManager.numberOfCoins +=1;
            Debug.Log("aa" + PlayerManager.numberOfCoins);
            Destroy(gameObject);
        }
    }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelActiveChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ReelList" || other.tag == "ReelPicture1" || other.tag == "ReelPicture2")
        {
            other.gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        {
            other.gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}

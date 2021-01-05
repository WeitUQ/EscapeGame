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
        if (other.tag == "ReelPicture1" || other.tag == "ReelPicture2" || other.tag == "ReelPicture3" || other.tag == "ReelPicture4" || other.tag == "ReelPicture5" || other.tag == "ReelPicture6")
        {
            if (other.gameObject.GetComponent<Renderer>() != null)
            {
                other.gameObject.GetComponent<Renderer>().enabled = true;
            }
            foreach(Transform child in other.gameObject.transform)
            {
                child.gameObject.GetComponent<Renderer>().enabled = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Renderer>() != null)
        {
            other.gameObject.GetComponent<Renderer>().enabled = false;
        }
        foreach (Transform child in other.gameObject.transform)
        {
            child.gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}

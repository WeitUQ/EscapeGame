using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelStopper : MonoBehaviour
{
    public SlotMachineController sScript;
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
        if (this.sScript.blueRotStop[0] && other.tag == "ReelList")
        {
            this.sScript.blueRotSpeed[0] = 0;
            this.gameObject.SetActive(false);
        }
        if (this.sScript.blueRotStop[1] && other.tag == "ReelList")
        {
            this.sScript.blueRotSpeed[1] = 0;
            this.gameObject.SetActive(false);
        }
        if (this.sScript.blueRotStop[2] && other.tag == "ReelList")
        {
            this.sScript.blueRotSpeed[2] = 0;
            this.gameObject.SetActive(false);
        }
        if (this.sScript.redRotStop[0] && other.tag == "ReelList")
        {
            this.sScript.redRotSpeed[0] = 0;
            this.gameObject.SetActive(false);
        }
        if (this.sScript.redRotStop[1] && other.tag == "ReelList")
        { 
            this.sScript.redRotSpeed[1] = 0;
            this.gameObject.SetActive(false);
        }
        if (this.sScript.redRotStop[2] && other.tag == "ReelList")
        {
            this.sScript.redRotStop[2] = false;
            this.sScript.redRotSpeed[2] = 0;
            this.gameObject.SetActive(false);
        }
    }
}

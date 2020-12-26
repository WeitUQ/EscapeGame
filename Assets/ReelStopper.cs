using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelStopper : MonoBehaviour
{
    private int item1Count = 0;
    private int item2Count = 0;
    private int item3Count = 0;
    private int item4Count = 0;
    public int item5Count = 0;
    private int item6Count = 0;
    public GameObject[] blueItemShutters;
    public GameObject redItemShutter;
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
        if (this.sScript.blueRotStop[0] && other.tag == "ReelPicture1")
        {
            this.item1Count++;
            this.sScript.blueRotSpeed[0] = 0;
            this.gameObject.SetActive(false);
            if (this.item1Count == 3)
            {
                this.blueItemShutters[0].SetActive(false);
            }
        }
        else if (this.sScript.blueRotStop[0] &&  other.tag == "ReelPicture2")
        {
            this.item2Count++;
            this.sScript.blueRotSpeed[0] = 0;
            this.gameObject.SetActive(false);
            if (this.item2Count == 3)
            {
                this.blueItemShutters[1].SetActive(false);
            }
        }
        if (this.sScript.blueRotStop[1] && other.tag == "ReelPicture1")
        {
            this.item1Count++;
            this.sScript.blueRotSpeed[1] = 0;
            this.gameObject.SetActive(false);
            if (this.item1Count == 3)
            {
                this.blueItemShutters[0].SetActive(false);
            }
        }
        else if (this.sScript.blueRotStop[1] && other.tag == "ReelPicture2")
        {
            this.item2Count++;
            this.sScript.blueRotSpeed[1] = 0;
            this.gameObject.SetActive(false);
            if (this.item2Count == 3)
            {
                this.blueItemShutters[1].SetActive(false);
            }
        }
        if (this.sScript.blueRotStop[2] && other.tag == "ReelPicture1")
        {
            this.item1Count++;
            this.sScript.blueRotSpeed[2] = 0;
            this.gameObject.SetActive(false);
            if (this.item1Count == 3)
            {
                this.blueItemShutters[0].SetActive(false);
            }
        }
        else if (this.sScript.blueRotStop[2] && other.tag == "ReelPicture2")
        { 
            this.item2Count++;
            this.sScript.blueRotSpeed[2] = 0;
            this.gameObject.SetActive(false);
            if (this.item2Count == 3)
            {
                this.blueItemShutters[1].SetActive(false);
            }
        }
        if (this.sScript.redRotStop[0] && other.tag == "ReelPicture5")
        {
            this.item5Count++;
            this.sScript.redRotSpeed[0] = 0;
            this.gameObject.SetActive(false);
            if (this.item5Count == 3)
            {
                this.redItemShutter.SetActive(false);
            }
        }
        else if (this.sScript.redRotStop[0] && other.tag == "ReelPicture6")
        {
            this.item6Count++;
            this.sScript.redRotSpeed[0] = 0;
            this.gameObject.SetActive(false);
            if (this.item6Count == 3)
            {
                
            }
        }
        if (this.sScript.redRotStop[1] && other.tag == "ReelPicture5")
        {
            this.item5Count++;
            this.sScript.redRotSpeed[1] = 0;
            this.gameObject.SetActive(false);
            if (this.item5Count == 3)
            {
                this.redItemShutter.SetActive(false);
            }
        }
        else if (this.sScript.redRotStop[1] && other.tag == "ReelPicture6")
        {
            this.item6Count++;
            this.sScript.redRotSpeed[1] = 0;
            this.gameObject.SetActive(false);
            if (this.item6Count == 3)
            {

            }
        }
        if (this.sScript.redRotStop[2] && other.tag == "ReelPicture5")
        {
            this.item5Count++;
            this.sScript.redRotSpeed[2] = 0;
            this.gameObject.SetActive(false);
            if (this.item5Count == 3)
            {
                this.redItemShutter.SetActive(false);
            }
        }
        else if (this.sScript.redRotStop[2] && other.tag == "ReelPicture6")
        {
            this.item6Count++;
            this.sScript.redRotSpeed[2] = 0;
            this.gameObject.SetActive(false);
            if (this.item6Count == 3)
            {

            }
        }
    }
}

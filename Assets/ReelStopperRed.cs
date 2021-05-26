using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class ReelStopperRed : MonoBehaviour
{
    public GameObject[] redItemShutter;
    public GameObject[] redStopColliders;
    public SlotMachineController sScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ReelPicture5")
        {
            this.sScript.item5Count++;
            this.sScript.reelStopCount++;
            if (this.gameObject == redStopColliders[0])
            {
                this.sScript.redRotSpeed[0] = 0;
            }
            else if (this.gameObject == redStopColliders[1])
            {
                this.sScript.redRotSpeed[1] = 0;
            }
            else if (this.gameObject == redStopColliders[2])
            {
                this.sScript.redRotSpeed[2] = 0;
            }
            this.gameObject.SetActive(false);
            if (this.sScript.item5Count == 3)
            {
                this.redItemShutter[0].SetActive(false);
            }
        }
        else if (other.tag == "ReelPicture6")
        {
            this.sScript.reelStopCount++;
            if (this.gameObject == redStopColliders[0])
            {
                this.sScript.redRotSpeed[0] = 0;
            }
            else if (this.gameObject == redStopColliders[1])
            {
                this.sScript.redRotSpeed[1] = 0;
            }
            else if (this.gameObject == redStopColliders[2])
            {
                this.sScript.redRotSpeed[2] = 0;
            }
            this.gameObject.SetActive(false);
        }

        if (this.sScript.reelStopCount == 3 && this.sScript.item5Count != 3)
        {
            this.redItemShutter[1].SetActive(false);
        }
    }
}

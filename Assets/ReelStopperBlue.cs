using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class ReelStopperBlue : MonoBehaviour
{
    //アイテムの落下を止めているシャッター
    public GameObject[] blueItemShutters;
    public GameObject[] blueStopColliders;

    public SlotMachineController sScript;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //リール中央にあるコライダーにリール絵柄のコライダーが接触したとき
    private void OnTriggerEnter(Collider other)
    {
        //回転が止まり、止まった絵柄ごとにカウントを加算していきカウントが3になったら対応するシャッターを破壊しアイテムが落ちてくる
        if (other.tag == "ReelPicture1")
        {
            this.sScript.item1Count++;
            this.sScript.reelStopCount++;
            if (this.gameObject == blueStopColliders[0])
        {
            this.sScript.blueRotSpeed[0] = 0;
        }
        else if(this.gameObject == blueStopColliders[1])
        {
            this.sScript.blueRotSpeed[1] = 0;
        }
        else if (this.gameObject == blueStopColliders[2])
        {
            this.sScript.blueRotSpeed[2] = 0;
        }
        this.gameObject.SetActive(false);
            if (this.sScript.item1Count == 3)
            {
                this.blueItemShutters[0].SetActive(false);
            }
        }
        else if (other.tag == "ReelPicture2")
        {
            this.sScript.item2Count++;
            this.sScript.reelStopCount++;
            if (this.gameObject == blueStopColliders[0])
            {
                this.sScript.blueRotSpeed[0] = 0;
            }
            else if (this.gameObject == blueStopColliders[1])
            {
                this.sScript.blueRotSpeed[1] = 0;
            }
            else if (this.gameObject == blueStopColliders[2])
            {
                this.sScript.blueRotSpeed[2] = 0;
            }
            this.gameObject.SetActive(false);
            if (this.sScript.item2Count == 3)
            {
                this.blueItemShutters[1].SetActive(false);
            }
        }
        else if (other.tag == "ReelPicture3")
        {
            this.sScript.item3Count++;
            this.sScript.reelStopCount++;
            if (this.gameObject == blueStopColliders[0])
            {
                this.sScript.blueRotSpeed[0] = 0;
            }
            else if (this.gameObject == blueStopColliders[1])
            {
                this.sScript.blueRotSpeed[1] = 0;
            }
            else if (this.gameObject == blueStopColliders[2])
            {
                this.sScript.blueRotSpeed[2] = 0;
            }
            this.gameObject.SetActive(false);
            if (this.sScript.item3Count == 3)
            {
                this.blueItemShutters[2].SetActive(false);
            }
        }

        if (this.sScript.reelStopCount == 3 && this.sScript.item1Count != 3 && this.sScript.item2Count != 3 && this.sScript.item3Count != 3)
        {
            this.blueItemShutters[3].SetActive(false);
        }
    }
}



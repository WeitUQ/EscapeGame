using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelStopper : MonoBehaviour
{
    //アイテムの落下を止めているシャッター
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

    //リール中央にあるコライダーにリール絵柄のコライダーが接触したとき
    private void OnTriggerEnter(Collider other)
    {
        //回転が止まり、止まった絵柄ごとにカウントを加算していきカウントが3になったら対応するシャッターを破壊しアイテムが落ちてくる
        if (this.sScript.blueRotStop[0] && other.tag == "ReelPicture1")
        {
            this.sScript.item1Count++;
            this.sScript.blueRotSpeed[0] = 0;
            this.gameObject.SetActive(false);
            if (this.sScript.item1Count == 3)
            {
                this.blueItemShutters[0].SetActive(false);
            }
        }
        else if (this.sScript.blueRotStop[0] &&  other.tag == "ReelPicture2")
        {
            this.sScript.blueRotStop[0] = false;
            this.sScript.item2Count++;
            this.sScript.blueRotSpeed[0] = 0;
            this.gameObject.SetActive(false);
            if (this.sScript.item2Count == 3)
            {
                this.blueItemShutters[1].SetActive(false);
            }
        }
        else if (this.sScript.blueRotStop[0] && other.tag == "ReelPicture3")
        {
            this.sScript.blueRotStop[0] = false;
            this.sScript.item3Count++;
            this.sScript.blueRotSpeed[0] = 0;
            this.gameObject.SetActive(false);
            if (this.sScript.item3Count == 3)
            {
                this.blueItemShutters[2].SetActive(false);
            }
        }
        else if (this.sScript.blueRotStop[0] && other.tag == "ReelPicture4")
        {
            this.sScript.blueRotStop[0] = false;
            this.sScript.item4Count++;
            this.sScript.blueRotSpeed[0] = 0;
            this.gameObject.SetActive(false);
            if (this.sScript.item4Count == 3)
            {
                this.blueItemShutters[3].SetActive(false);
            }
        }
        if (this.sScript.blueRotStop[1] && other.tag == "ReelPicture1")
        {
            this.sScript.blueRotStop[1] = false;
            this.sScript.item1Count++;
            this.sScript.blueRotSpeed[1] = 0;
            this.gameObject.SetActive(false);
            if (this.sScript.item1Count == 3)
            {
                this.blueItemShutters[0].SetActive(false);
            }
        }
        else if (this.sScript.blueRotStop[1] && other.tag == "ReelPicture2")
        {
            this.sScript.blueRotStop[1] = false;
            this.sScript.item2Count++;
            this.sScript.blueRotSpeed[1] = 0;
            this.gameObject.SetActive(false);
            if (this.sScript.item2Count == 3)
            {
                this.blueItemShutters[1].SetActive(false);
            }
        }
        else if (this.sScript.blueRotStop[1] && other.tag == "ReelPicture3")
        {
            this.sScript.blueRotStop[1] = false;
            this.sScript.item3Count++;
            this.sScript.blueRotSpeed[1] = 0;
            this.gameObject.SetActive(false);
            if (this.sScript.item3Count == 3)
            {
                this.blueItemShutters[2].SetActive(false);
            }
        }
        else if (this.sScript.blueRotStop[1] && other.tag == "ReelPicture4")
        {
            this.sScript.blueRotStop[1] = false;
            this.sScript.item4Count++;
            this.sScript.blueRotSpeed[1] = 0;
            this.gameObject.SetActive(false);
            if (this.sScript.item4Count == 3)
            {
                this.blueItemShutters[3].SetActive(false);
            }
        }
        if (this.sScript.blueRotStop[2] && other.tag == "ReelPicture1")
        {
            this.sScript.blueRotStop[2] = false;
            this.sScript.item1Count++;
            this.sScript.blueRotSpeed[2] = 0;
            this.gameObject.SetActive(false);
            if (this.sScript.item1Count == 3)
            {
                this.blueItemShutters[0].SetActive(false);
            }
        }
        else if (this.sScript.blueRotStop[2] && other.tag == "ReelPicture2")
        {
            this.sScript.blueRotStop[2] = false;
            this.sScript.item2Count++;
            this.sScript.blueRotSpeed[2] = 0;
            this.gameObject.SetActive(false);
            if (this.sScript.item2Count == 3)
            {
                this.blueItemShutters[1].SetActive(false);
            }
        }
        else if (this.sScript.blueRotStop[2] && other.tag == "ReelPicture3")
        {
            this.sScript.blueRotStop[2] = false;
            this.sScript.item3Count++;
            this.sScript.blueRotSpeed[2] = 0;
            this.gameObject.SetActive(false);
            if (this.sScript.item3Count == 3)
            {
                this.blueItemShutters[2].SetActive(false);
            }
        }
        else if (this.sScript.blueRotStop[2] && other.tag == "ReelPicture4")
        {
            this.sScript.blueRotStop[2] = false;
            this.sScript.item4Count++;
            this.sScript.blueRotSpeed[2] = 0;
            this.gameObject.SetActive(false);
            if (this.sScript.item4Count == 3)
            {
                this.blueItemShutters[3].SetActive(false);
            }
        }
        if (this.sScript.redRotStop[0] && other.tag == "ReelPicture5")
        {
            this.sScript.redRotStop[0] = false;
            this.sScript.item5Count++;
            this.sScript.redRotSpeed[0] = 0;
            this.gameObject.SetActive(false);
            if (this.sScript.item5Count == 3)
            {
                this.redItemShutter.SetActive(false);
            }
        }
        else if (this.sScript.redRotStop[0] && other.tag == "ReelPicture6")
        {
            this.sScript.redRotStop[0] = false;
            this.sScript.redRotSpeed[0] = 0;
            this.gameObject.SetActive(false);
        }

        if (this.sScript.redRotStop[1] && other.tag == "ReelPicture5")
        {
            this.sScript.redRotStop[1] = false;
            this.sScript.item5Count++;
            this.sScript.redRotSpeed[1] = 0;
            this.gameObject.SetActive(false);
            if (this.sScript.item5Count == 3)
            {
                this.redItemShutter.SetActive(false);
            }
        }
        else if (this.sScript.redRotStop[1] && other.tag == "ReelPicture6")
        {
            this.sScript.redRotStop[1] = false;
            this.sScript.redRotSpeed[1] = 0;
            this.gameObject.SetActive(false);
        }

        if (this.sScript.redRotStop[2] && other.tag == "ReelPicture5")
        {
            this.sScript.redRotStop[2] = false;
            this.sScript.item5Count++;
            this.sScript.redRotSpeed[2] = 0;
            this.gameObject.SetActive(false);
            if (this.sScript.item5Count == 3)
            {
                this.redItemShutter.SetActive(false);
            }
        }
        else if (this.sScript.redRotStop[2] && other.tag == "ReelPicture6")
        {
            this.sScript.redRotStop[2] = false;
            this.sScript.redRotSpeed[2] = 0;
            this.gameObject.SetActive(false);
        }
    }
}

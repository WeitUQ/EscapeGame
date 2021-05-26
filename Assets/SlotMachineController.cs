using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotMachineController : MonoBehaviour
{
    //　スロットの回転関係
    public GameObject[] blueMainReels;
    public GameObject[] blueSubReels;
    public GameObject[] redMainReels;
    public GameObject[] redSubReels;
    public GameObject[] blueStopColliders;
    public GameObject[] redStopColliders;   
    public CameraController cScript;
    public ItemController iScript;
    public Animator[] leverAnimator;
    public Animator[] buttonAnimator;
    public Renderer[] buttonRenderers;
    public Material[] buttonMaterials;
    public float[] blueRotSpeed;
    public float[] redRotSpeed;
    private bool blueRotState = false;
    private bool redRotState = false;

    // テキスト関係
    public Text slotText;
    public GameObject textCanvas;
    public GameObject textCamera;
    public GameObject bButton;

    // リール中央にそろった絵柄のカウント
    public int item1Count = 0;
    public int item2Count = 0;
    public int item3Count = 0;
    public int item4Count = 0;
    public int item5Count = 0;

    // リールが止まった回数のカウント
    public int reelStopCount = 0;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //青スロットの回転フラグがオンになっているときの処理
        if (this.blueRotState)
        {
            //リールを下に移動させ、規定位置を超えたら初期位置に戻す
            this.blueMainReels[0].transform.Translate(0, this.blueRotSpeed[0] * Time.deltaTime, 0);
            this.blueMainReels[1].transform.Translate(0, this.blueRotSpeed[1] * Time.deltaTime, 0);
            this.blueMainReels[2].transform.Translate(0, this.blueRotSpeed[2] * Time.deltaTime, 0);
            if (this.blueSubReels[0].transform.position.y <= 7.9f)
            {
                this.blueSubReels[0].transform.position = new Vector3(12.8f, this.blueSubReels[1].transform.position.y + 10.2f, this.blueSubReels[0].transform.position.z);
            }
            if (this.blueSubReels[1].transform.position.y <= 7.9f)
            {
                this.blueSubReels[1].transform.position = new Vector3(12.8f, this.blueSubReels[0].transform.position.y + 10.2f, this.blueSubReels[1].transform.position.z);
            }
            if (this.blueSubReels[2].transform.position.y <= 7.9f)
            {
                this.blueSubReels[2].transform.position = new Vector3(15.6f, this.blueSubReels[3].transform.position.y + 10.2f, this.blueSubReels[2].transform.position.z); 
            }
            if (this.blueSubReels[3].transform.position.y <= 7.9f)
            {
                this.blueSubReels[3].transform.position = new Vector3(15.6f, this.blueSubReels[2].transform.position.y + 10.2f, this.blueSubReels[3].transform.position.z);
            }
            if (this.blueSubReels[4].transform.position.y <= 7.9f)
            {
                this.blueSubReels[4].transform.position = new Vector3(18.4f, this.blueSubReels[5].transform.position.y + 10.2f, this.blueSubReels[4].transform.position.z);
            }
            if (this.blueSubReels[5].transform.position.y <= 7.9f)
            {
                this.blueSubReels[5].transform.position = new Vector3(18.4f, this.blueSubReels[4].transform.position.y + 10.2f, this.blueSubReels[5].transform.position.z);
            }
        }

        //赤スロットの回転フラグがオンになっているときの処理
        if (this.redRotState)
        {
            //リールを下に移動させ、規定位置を超えたら初期位置に戻す
            this.redMainReels[0].transform.Translate(0, this.redRotSpeed[0] * Time.deltaTime, 0);
            this.redMainReels[1].transform.Translate(0, this.redRotSpeed[1] * Time.deltaTime, 0);
            this.redMainReels[2].transform.Translate(0, this.redRotSpeed[2] * Time.deltaTime, 0);
            if (this.redSubReels[0].transform.position.y <= 7.9f)
            {
                this.redSubReels[0].transform.position = new Vector3(32.35f, this.redSubReels[1].transform.position.y + 10.2f, this.redSubReels[0].transform.position.z);
            }
            if (this.redSubReels[1].transform.position.y <= 7.9f)
            {
                this.redSubReels[1].transform.position = new Vector3(32.35f, this.redSubReels[0].transform.position.y + 10.2f, this.redSubReels[1].transform.position.z);
            }
            if (this.redSubReels[2].transform.position.y <= 7.9f)
            {
                this.redSubReels[2].transform.position = new Vector3(35.15f, this.redSubReels[3].transform.position.y + 10.2f, this.redSubReels[2].transform.position.z);
            }
            if (this.redSubReels[3].transform.position.y <= 7.9f)
            {
                this.redSubReels[3].transform.position = new Vector3(35.15f, this.redSubReels[2].transform.position.y + 10.2f, this.redSubReels[3].transform.position.z);
            }
            if (this.redSubReels[4].transform.position.y <= 7.9f)
            {
                this.redSubReels[4].transform.position = new Vector3(37.95f, this.redSubReels[5].transform.position.y + 10.2f, this.redSubReels[4].transform.position.z);
            }
            if (this.redSubReels[5].transform.position.y <= 7.9f)
            {
                this.redSubReels[5].transform.position = new Vector3(37.95f, this.redSubReels[4].transform.position.y + 10.2f, this.redSubReels[5].transform.position.z);
            }
        }
    }

    //青スロットのレバーをクリックしたときの処理
    public void LeverONBlue()
    {
        if (this.cScript.zoomState[6])
        {
            //青レバーのアニメーション実行
            this.leverAnimator[0].SetTrigger("ONBlue");

            //コインが3枚入っていれば回転フラグON,足りなければ定型文表示
            if (this.iScript.bCoinCount == 3)
            {
                this.iScript.bCoinCount = 0;
                this.blueRotState = true;
            }
            else 
            {
                this.textCanvas.SetActive(true);
                this.textCamera.SetActive(true);
                this.bButton.SetActive(false);
                this.slotText.text = "どうやらコインを入れないと動かないようだ…。";
            }
        }
    }

    //赤スロットのレバーをクリックしたときの処理
    public void LeverONRed()
    {
        if (this.cScript.zoomState[5])
        {
            //赤レバーのアニメーション実行
            this.leverAnimator[1].SetTrigger("ONRed");

            //コインが3枚入っていれば回転フラグON,足りなければ定型文表示
            if (this.iScript.rCoinCount == 3)
            {
                this.iScript.rCoinCount = 0;
                this.redRotState = true;
            }
            else
            {
                this.textCanvas.SetActive(true);
                this.textCamera.SetActive(true);
                this.bButton.SetActive(false);
                this.slotText.text = "どうやらコインを入れないと動かないようだ…。";
            }
        }
    }

    //青スロットのリール回転時に左ボタンが押されたとき
    public void StopReelBlue1()
    {
        if (this.cScript.zoomState[6])
        {
            //ボタンアニメーション実行
            this.buttonAnimator[0].SetTrigger("LON");

            //リールストップフラグON
            if (this.blueRotSpeed[0] == -1.0f && this.blueRotState)
            {
                this.buttonRenderers[0].material = this.buttonMaterials[1];
                this.blueStopColliders[0].SetActive(true);
            }
        }
    }

    //青スロットのリール回転時に中ボタンが押されたとき
    public void StopReelBlue2()
    {
        if (this.cScript.zoomState[6])
        {
            //ボタンアニメーション実行
            this.buttonAnimator[0].SetTrigger("CON");
            //リールストップフラグON
            if (this.blueRotSpeed[1] == -1.0f && this.blueRotState)
            {
                this.buttonRenderers[1].material = this.buttonMaterials[1];
                this.blueStopColliders[1].SetActive(true);
            }
        }
    }

    //青スロットのリール回転時に右ボタンが押されたとき
    public void StopReelBlue3()
    {
        if (this.cScript.zoomState[6])
        {
            //ボタンアニメーション実行
            this.buttonAnimator[0].SetTrigger("RON");
            //リールストップフラグON
            if (this.blueRotSpeed[2] == -1.0f && this.blueRotState)
            {
                this.buttonRenderers[2].material = this.buttonMaterials[1];
                this.blueStopColliders[2].SetActive(true);
            }
        }
    }

    //赤スロットのリール回転時に左ボタンが押されたとき
    public void StopReelRed1()
    {
        if (this.cScript.zoomState[5] && this.redRotSpeed[0] == -10.0f && this.redRotState)
        {
            //リールストップフラグON
            this.buttonRenderers[3].material = this.buttonMaterials[1];
            this.redStopColliders[0].SetActive(true);
        }
    }

    //赤スロットのリール回転時に中ボタンが押されたとき
    public void StopReelRed2()
    {
        if (this.cScript.zoomState[5] && this.redRotSpeed[1] == -10.0f && this.redRotState)
        {
            //リールストップフラグON
            this.buttonRenderers[4].material = this.buttonMaterials[1];
            this.redStopColliders[1].SetActive(true);
        }
    }

    //赤スロットのリール回転時に右ボタンが押されたとき
    public void StopReelRed3()
    {
        if (this.cScript.zoomState[5] && this.redRotSpeed[2] == -10.0f && this.redRotState)
        {
            //リールストップフラグON
            this.buttonRenderers[5].material = this.buttonMaterials[1];
            this.redStopColliders[2].SetActive(true);
        }
    }
}

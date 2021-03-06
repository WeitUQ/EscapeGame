﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CameraController : MonoBehaviour
{
    //ゲーム画面内オブジェクト、コンポーネント
    public GameObject desk;
    public GameObject door;
    public GameObject[] boxCollider;
    public Collider[] drawerCollider;
    public Collider drawKeyHoleCollider;
    public Collider deskCollider;
    public Collider bedCollider;
    public Collider[] slotColliders;
    public Light underBedLight;
    public PhysicsRaycaster mainRaycaster;

    //UIなど
    public GameObject pcCanvas;
    public GameObject pcCamera;
    public GameObject zoomCamera;
    public GameObject rButton;
    public GameObject lButton;
    public GameObject bButton;

    //メインカメラの状態のフラグ
    public bool[] zoomState;

    //メインカメラの位置、角度
    private Vector3 startPos; //ズーム前の位置
    private Vector3 startAng; //ズーム前の角度
    private Vector3 interPos; //1回目のズーム時の位置
    private Vector3 interAng; //1回目のズーム時の角度

    //その他
    public ItemController iScript;
    // Start is called before the first frame update
    void Start()
    {
        this.startPos = this.transform.position;
        this.startAng = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.zoomCamera.activeSelf)
        {
            this.mainRaycaster.enabled = false;
        }
        else
        {
            this.mainRaycaster.enabled = true;
        }
    }
    //右ボタンクリック時の処理
    public void RAngleChange()
    {
        if (!this.zoomCamera.activeSelf)
        {
            //右回りに回転させ位置と角度を更新
            this.transform.Rotate(0, 90, 0);
            this.startPos = this.transform.position;
            this.startAng = this.transform.eulerAngles;
        }
    }
    //左ボタンクリック時の処理
    public void LAngleChange()
    {
        if (!this.zoomCamera.activeSelf)
        {
            //左回りに回転させ位置と角度を更新
            this.transform.Rotate(0, -90, 0);
            this.startPos = this.transform.position;
            this.startAng = this.transform.eulerAngles;
        }
    }

    //ドアクリック時の処理
    public void DoorZoomCamera()
    {
        //ドアをズーム
        if (this.zoomState[0] == false)
        {
            this.zoomState[0] = true;
            this.transform.Rotate(5, -45, 0);
            this.transform.position = new Vector3(this.door.transform.position.x, 15, -38);
            this.rButton.SetActive(false);
            this.lButton.SetActive(false);
            this.bButton.SetActive(true);
        }
    }

    //机クリック時の処理
    public void DeskZoomCamera()
    {
        //机をズーム
        if (this.IsDeskZoomable)
        {
            this.boxCollider[0].SetActive(true);
            this.boxCollider[1].SetActive(true);
            this.deskCollider.enabled = false;
            this.zoomState[1] = true;
            this.transform.Rotate(20, -45, 0);
            this.transform.position = new Vector3(-5, 20, this.desk.transform.position.z);
            this.rButton.SetActive(false);
            this.lButton.SetActive(false);
            this.bButton.SetActive(true);

            //中間位置、角度を更新
            this.interPos = this.transform.position;
            this.interAng = this.transform.eulerAngles;
        }

    }

    //机ズーム状態で机の上クリック時の処理
    public void OverDeskZoomCamera()
    {
        //机の上をズーム
        if (this.OnDeskZoomable)
        {
            this.zoomState[1] = false;
            this.zoomState[2] = true;
            this.boxCollider[1].SetActive(false);
            this.transform.Rotate(35, 0, 0);
            this.transform.position = new Vector3(-23, 25, this.desk.transform.position.z);
        }
    }

    //机の上ズーム状態でPCクリックしたときの処理
    public void PCZoomCamera()
    {
        //PCcanvasを表示
        if (this.IsPCZoomable)
        {
            this.zoomState[2] = false;
            this.zoomState[7] = true;
            this.gameObject.SetActive(false);
            this.pcCanvas.SetActive(true);
            this.pcCamera.SetActive(true);
            this.rButton.SetActive(false);
            this.lButton.SetActive(false);
            this.bButton.SetActive(true);
        }
    }

    //机ズーム状態で引き出しクリック時の処理
    public void DrawerZoomCamera()
    {
        //引き出しをズーム
        if (this.IsDrawerZoomable)
        {
            this.boxCollider[0].SetActive(false);
            this.zoomState[1] = false;
            this.zoomState[3] = true;
            this.transform.Rotate(33, 0, 0);
            this.transform.position = new Vector3(-18, 16, this.desk.transform.position.z + 7);
            ChangeStateDrawerColiider();
            if ((this.iScript.listDrawerKeys[0] && this.iScript.listDrawerKeys[0].activeSelf) || (this.iScript.listDrawerKeys[1] && this.iScript.listDrawerKeys[1].activeSelf))
            {
                this.drawKeyHoleCollider.enabled = true;
            }
        }
    }

    //スロットマシン近辺クリック時の処理
    public void SlotMachineZoomCamera()
    {
        //スロットマシンをズーム
        if (this.zoomState[4] == false)
        {
            this.boxCollider[2].SetActive(false);
            this.zoomState[4] = true;
            this.transform.Rotate(20, -45, 0);
            this.transform.position = new Vector3(30, 20, -10);
            this.rButton.SetActive(false);
            this.lButton.SetActive(false);
            this.bButton.SetActive(true);

            //中間位置、角度を更新
            this.interPos = this.transform.position;
            this.interAng = this.transform.eulerAngles;
        }
    }


    public void SlotManualZoomCamera()
    {
        //スロットマシンの説明文をズーム
        if (this.zoomState[4])
        {
            this.zoomState[4] = false;
            this.zoomState[11] = true;
            this.transform.Rotate(0, 90, -20);
            this.transform.position = new Vector3(32, 15, 4);
        }
    }
    //スロットマシンズーム状態で赤スロットマシンをクリックしたときの処理
    public void RedZoomCamera()
    {
        //赤スロットマシンをズーム
        if (this.zoomState[4])
        {
            this.slotColliders[0].enabled = false;
            this.boxCollider[4].SetActive(true);
            this.zoomState[4] = false;
            this.zoomState[5] = true;
            this.transform.Rotate(0, 0, 0);
            this.transform.position = new Vector3(35, 17, 5);
        }
    }

    //スロットマシンズーム状態で青スロットマシンをクリックしたときの処理
    public void BlueZoomCamera()
    {
        if (this.zoomState[4])
        {
            //青スロットマシンをズーム
            this.slotColliders[1].enabled = false;
            this.boxCollider[3].SetActive(true);
            this.zoomState[4] = false;
            this.zoomState[6] = true;
            this.transform.Rotate(0, 0, 0);
            this.transform.position = new Vector3(15, 17, 5);
        }
    }

    //ベッドクリック時の処理 
    public void BedZoomCamera()
    {
        //ベッドをズーム
        if (this.zoomState[8] == false && this.zoomState[9] == false && this.zoomState[10] == false)
        {
            this.bedCollider.enabled = false;
            this.zoomState[8] = true;
            this.transform.Rotate(20, -45, 0);
            this.transform.position = new Vector3(0, 20, -50);
            this.rButton.SetActive(false);
            this.lButton.SetActive(false);
            this.bButton.SetActive(true);

            //中間位置、角度を更新
            this.interPos = this.transform.position;
            this.interAng = this.transform.eulerAngles;
        }
    }

    //ベッドズーム状態でベッドの上をクリックしたときの処理
    public void OverBedZoomCamera()
    {
        //ベッドの上をズーム
        if (this.zoomState[8])
        {
            this.zoomState[8] = false;
            this.zoomState[9] = true;
            this.boxCollider[5].SetActive(false);
            this.transform.Rotate(20, 0, 0);
            this.transform.position = new Vector3(15, 20, -50);
        }
    }

    //ベッドズーム状態でベッドの下をクリックしたときの処理
    public void UnderBedZoomCamera()
    {
        //ベッドの下をズーム
        if (this.zoomState[8])
        {
            this.zoomState[8] = false;
            this.zoomState[10] = true;
            this.boxCollider[6].SetActive(false);
            this.transform.Rotate(-5, 0, 0);
            this.transform.position = new Vector3(24f, 1.8f, -44);
        }
    }

    //backボタンを押したときの処理
    public void BackCamera()
    {
        if (!this.zoomCamera.activeSelf)
        {
            //1回目のズーム時なら初期位置・角度に、2回目のズーム時なら中間位置・角度にカメラが移動
            if (this.zoomState[0])
            {
                this.zoomState[0] = false;
                this.transform.eulerAngles = this.startAng;
                this.transform.position = this.startPos;
                this.rButton.SetActive(true);
                this.lButton.SetActive(true);
                this.bButton.SetActive(false);
            }
            else if (this.zoomState[1])
            {
                this.boxCollider[0].SetActive(false);
                this.boxCollider[1].SetActive(false);
                this.zoomState[1] = false;
                this.transform.eulerAngles = this.startAng;
                this.transform.position = this.startPos;
                this.rButton.SetActive(true);
                this.lButton.SetActive(true);
                this.bButton.SetActive(false);
                this.deskCollider.enabled = true;
            }
            else if (this.zoomState[2])
            {
                this.boxCollider[1].SetActive(true);
                this.zoomState[1] = true;
                this.zoomState[2] = false;
                this.transform.eulerAngles = this.interAng;
                this.transform.position = this.interPos;
            }
            else if (this.zoomState[3])
            {
                this.boxCollider[0].SetActive(true);
                this.drawKeyHoleCollider.enabled = false;
                this.zoomState[1] = true;
                this.zoomState[3] = false;
                this.transform.eulerAngles = this.interAng;
                this.transform.position = this.interPos;
                ChangeStateDrawerColiider();
            }
            else if (this.zoomState[4])
            {
                this.zoomState[4] = false;
                this.transform.eulerAngles = this.startAng;
                this.transform.position = this.startPos;
                this.rButton.SetActive(true);
                this.lButton.SetActive(true);
                this.bButton.SetActive(false);
                this.boxCollider[2].SetActive(true);
            }
            else if (this.zoomState[5])
            {
                this.slotColliders[0].enabled = true;
                this.zoomState[4] = true;
                this.zoomState[5] = false;
                this.transform.eulerAngles = this.interAng;
                this.transform.position = this.interPos;
            }
            else if (this.zoomState[6])
            {
                this.slotColliders[1].enabled = true;
                this.zoomState[4] = true;
                this.zoomState[6] = false;
                this.transform.eulerAngles = this.interAng;
                this.transform.position = this.interPos;
            }
            else if (this.zoomState[7])
            {
                this.zoomState[2] = true;
                this.zoomState[7] = false;
                this.pcCamera.SetActive(false);
                this.pcCanvas.SetActive(false);
                this.gameObject.SetActive(true);
            }
            else if (this.zoomState[8])
            {
                this.zoomState[8] = false;
                this.bedCollider.enabled = true;
                this.transform.eulerAngles = this.startAng;
                this.transform.position = this.startPos;
                this.rButton.SetActive(true);
                this.lButton.SetActive(true);
                this.bButton.SetActive(false);
            }
            else if (this.zoomState[9])
            {
                this.zoomState[8] = true;
                this.zoomState[9] = false;
                this.boxCollider[5].SetActive(true);
                this.transform.eulerAngles = this.interAng;
                this.transform.position = this.interPos;
            }
            else if (this.zoomState[10])
            {
                this.zoomState[8] = true;
                this.zoomState[10] = false;
                this.boxCollider[6].SetActive(true);
                this.transform.eulerAngles = this.interAng;
                this.transform.position = this.interPos;
                //ベッド下ライトをオフにする
                this.underBedLight.enabled = false;
            }
            else if (this.zoomState[11])
            {
                this.zoomState[4] = true;
                this.zoomState[11] = false;
                this.transform.eulerAngles = this.interAng;
                this.transform.position = this.interPos;
            }
        }
    }

    //机をズームできるか
    public bool IsDeskZoomable
    {
        get
        {
            if (!this.OnDeskZoomable && !this.IsPCZoomable && !this.IsPCZoomable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    //机の上をズームできるか
    public bool OnDeskZoomable
    {
        get => this.zoomState[1];
    }

    //PCをズームできるか
    public bool IsPCZoomable
    {
        get => this.zoomState[2];
    }

    //引き出しをズームできるか
    public bool IsDrawerZoomable
    {
        get
        {
            if (!this.zoomState [3] && OnDeskZoomable)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }

    //引き出しのコライダーの有効・無効を切り替える関数
    private void ChangeStateDrawerColiider()
    {
        this.drawerCollider[0].enabled = !this.drawerCollider[0].enabled;
        this.drawerCollider[1].enabled = !this.drawerCollider[1].enabled;
        this.drawerCollider[2].enabled = !this.drawerCollider[2].enabled;
    }
}

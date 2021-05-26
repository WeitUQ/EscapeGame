    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    //ゲーム画面内オブジェクト
    public GameObject flashLight;
    public GameObject door;
    public GameObject[] Key;
    public GameObject nob;
    public GameObject hammer;
    public GameObject[] coins;
    public GameObject[] drawerKeys;
    public GameObject screwDriver;
    public GameObject stickBond;
    public GameObject gamTape;
    public GameObject[] capsules;
    public GameObject underBedLight;
    public GameObject IOU;
    public GameObject contract;
    public GameObject agreement;

    //アイテムリスト内オブジェクト
    public GameObject listLight;
    public GameObject listKey;
    public GameObject listNob;
    public GameObject listCrushedNob;
    public GameObject listHammer;
    public GameObject[] listCoins;
    public GameObject[] listDrawerKeys;
    public GameObject listDriver;
    public GameObject listIOU;
    public GameObject listContract;
    public GameObject listAgreement;
    public Light listFlashSpotLight;


    //ズームリスト内オブジェクト
    public GameObject[] zoomList;
    public GameObject zoomCamera;
    public GameObject[] zoomDrawerKeys;
    public GameObject[] zoomListCoins;
    public Light zoomFlashSpotLight;

    //UI,Script
    public CameraController cameraScript;
    public DoorController doorScript;
    public FlashLightController flashLightScript;
    public TextController textScript;
    public ZoomItemRotater zoomRotateScript;
    public GameObject closeButton;
    public GameObject textCamera;
    public GameObject rButton;
    public GameObject lButton;
    public GameObject bButton;
    public GameObject textCanvas;
    public Text itemText;

    //カウント
    public int rCoinCount = 0; //赤スロットマシンにコインを入れた回数
    public int bCoinCount = 0; //青スロットマシンにコインを入れた回数
    private int clickCount = 0; //ドアノブをクリックした回数
    private int getCoinCount = 0; //コインを入手した回数

    //フラグ系 
    public bool chooseLight = false;
    public bool chooseKey = false;
    public bool chooseNob = false;
    public bool chooseCrushedNob = false;
    public bool chooseHammer = false;
    public bool chooseCoin = false;
    public bool chooseDrawerKey = false;
    public bool chooseDriver = false;
    public bool lightButtonON = false;
    public bool chooseIOU = false;
    public bool chooseContract = false;
    public bool chooseAgreement = false;
    private bool drawerOpen = false;
    private bool rotFlag = false;　//アイテム取得時のズーム画面でアイテムを回転できなくするためのフラグ；

    //その他
    public Animator lightAnimator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // 引き出しのカギクリック(タップ)の処理
    public void GetDrawerKey()
    {
        //1個めのカギの場合
        if (this.cameraScript.zoomState[5])
        {
            // 引き出しのカギを破壊し、アイテムリストに表示させる。
            Destroy(this.drawerKeys[1]);
            this.listDrawerKeys[1].SetActive(true);

            //ズーム画面と主人公のセリフを表示させる。
            UIStateONGetItems();
            this.zoomList[1].SetActive(true);
            this.zoomDrawerKeys[0].SetActive(false);
            if (this.listDrawerKeys[0].activeSelf)
            {
                this.itemText.text = "カギを手に入れた。…二個目だ。";
            }
            else
            {
                this.itemText.text = "カギを手に入れた。…どこのカギだろう？";
            }
        }
        //2個めのカギの場合
        else
        {
            // 引き出しのカギを破壊し、アイテムリストを表示させる。
            Destroy(this.drawerKeys[0]);
            this.listDrawerKeys[0].SetActive(true);

            //ズーム画面と主人公のセリフを表示させる。
            UIStateONGetItems();
            this.zoomList[1].SetActive(true);
            this.zoomDrawerKeys[1].SetActive(false);
            if (this.listDrawerKeys[1].activeSelf)
            {
                this.itemText.text = "カギを手に入れた。…二個目だ。";
            }
            else
            {
                this.itemText.text = "カギを手に入れた。…どこのカギだろう？";
            }
        }
    }
    // アイテムリスト1をクリックした場合の処理
    public void ChooseDrawerKey()
    {
        //引き出しのカギフラグのみオンにする
        this.chooseDrawerKey = true;
        this.chooseNob = false;
        this.chooseKey = false;
        this.chooseHammer = false;
        this.chooseCoin = false;
        this.chooseDriver = false;
        this.chooseLight = false;
        this.chooseIOU = false;
        this.chooseContract = false;
        this.chooseAgreement = false;
        this.chooseCrushedNob = false;
    }
    //引き出しのカギを1つ以上入手している状態でアイテムリスト1を連続で2度クリックした場合の処理
    public void ZoomDrawerKey()
    {

        if (this.chooseDrawerKey && (this.listDrawerKeys[0].activeSelf || this.listDrawerKeys[1].activeSelf))
        {
            //回転可能にし、前回開いていたズームアイテムの位置を初期化
            this.rotFlag = true;
            if (this.zoomRotateScript.ZoomObject != null)
            {
                this.zoomRotateScript.memorizeFlag = true;
                this.zoomRotateScript.ZoomObject.transform.eulerAngles = this.zoomRotateScript.ZoomInitialRot;
            }
            //入手している引き出しのカギのズーム画面のみを表示する
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(true);
            this.zoomList[2].SetActive(false);
            this.zoomList[3].SetActive(false);
            this.zoomList[4].SetActive(false);
            this.zoomList[5].SetActive(false);
            this.zoomList[6].SetActive(false);
            this.zoomList[7].SetActive(false);
            this.zoomList[8].SetActive(false);
            this.zoomList[9].SetActive(false);
            this.zoomList[10].SetActive(false);
            this.zoomList[11].SetActive(false);
            this.zoomDrawerKeys[0].SetActive(false);
            this.zoomDrawerKeys[1].SetActive(false);
            if (this.listDrawerKeys[0].activeSelf)
            {
                this.zoomDrawerKeys[0].SetActive(true);
            }
            if (this.listDrawerKeys[1].activeSelf)
            {
                this.zoomDrawerKeys[1].SetActive(true);
            }
        }
    }
    //引き出しのカギ使用時
    public void UseDrawerKey()
    {
        if (!this.cameraScript.IsDrawerZoomable && this.chooseDrawerKey && this.listDrawerKeys[0] && this.listDrawerKeys[0].activeSelf)
        {
            this.listDrawerKeys[0].SetActive(false);
            Destroy(this.listDrawerKeys[0]);
            this.cameraScript.drawKeyHoleCollider.enabled = false;
        }
        else if (!this.cameraScript.IsDrawerZoomable && this.chooseDrawerKey && this.listDrawerKeys[1] && this.listDrawerKeys[1].activeSelf)
        {
            this.listDrawerKeys[1].SetActive(false);
            Destroy(this.listDrawerKeys[1]);
            this.cameraScript.drawKeyHoleCollider.enabled = false;
        }
        this.drawerOpen = true;
    }
    //ドアのカギクリック時の処理
    public void GetKey1()
    {
        //ドアのカギを破壊し、アイテムリストに表示させる
        Destroy(this.Key[0]);
        this.zoomList[6].SetActive(false);
        this.zoomList[5].SetActive(true);
        this.closeButton.SetActive(true);
        this.listKey.SetActive(true);
        this.listCrushedNob.SetActive(true);
    }

    public void GetKey2()
    {
        //ドアのカギを破壊し、アイテムリストに表示させる
        Destroy(this.Key[1]);
        this.zoomList[4].SetActive(false);
        this.zoomList[5].SetActive(true);
        this.closeButton.SetActive(true);
        this.listKey.SetActive(true);
    }

    //ドアのカギ使用時の処理
    public void UseKey()
    {
        if (this.cameraScript.zoomState[0] && this.chooseKey & this.listKey.activeSelf)
        {
            //アイテムリスト内のカギを破壊する
            Destroy(this.listKey);

            //ドアを開けるフラグON
            this.doorScript.lockState = true;
        }
    }

    //ドアのカギを入手している状態でアイテムリスト5を連続で2度クリックした場合の処理
    public void ZoomKey()
    {
        if (this.chooseKey && this.listKey.activeSelf)
        {
            //回転可能にし、前回開いていたズームアイテムの位置を初期化
            this.rotFlag = true;
            if (this.zoomRotateScript.ZoomObject != null)
            {
                this.zoomRotateScript.memorizeFlag = true;
                this.zoomRotateScript.ZoomObject.transform.eulerAngles = this.zoomRotateScript.ZoomInitialRot;
            }
            //ドアのカギのズーム画面のみを表示する
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(false);
            this.zoomList[2].SetActive(false);
            this.zoomList[3].SetActive(false);
            this.zoomList[4].SetActive(false);
            this.zoomList[5].SetActive(true);
            this.zoomList[6].SetActive(false);
            this.zoomList[7].SetActive(false);
            this.zoomList[8].SetActive(false);
            this.zoomList[9].SetActive(false);
            this.zoomList[10].SetActive(false);
            this.zoomList[11].SetActive(false);
        }
    }
    //ドアのカギを入手している状態で、アイテムリスト11を連続で2度クリックしたときの処理
    public void ChooseKey()
    {
        //ドアのカギフラグのみオンにする
        this.chooseDrawerKey = false;
        this.chooseNob = false;
        this.chooseKey = true;
        this.chooseHammer = false;
        this.chooseCoin = false;
        this.chooseDriver = false;
        this.chooseLight = false;
        this.chooseContract = false;
        this.chooseAgreement = false;
        this.chooseCrushedNob = false;
    }

    //ドアノブクリック時の処理
    public void GetNob()
    {
        if (this.cameraScript.zoomState[0])
        {
            this.clickCount++; //クリック回数
            if (this.clickCount == 3)
            {
                //ドアノブを破壊しアイテムリストに表示させる
                Destroy(this.nob);
                this.listNob.SetActive(true);

                //ズーム画面と主人公のセリフを表示させる
                UIStateONGetItems();
                this.zoomList[4].SetActive(true);
                this.itemText.text = "ドアノブが取れてしまった…。";
            }
        }
    }

    //アイテムリスト10をクリックした時の処理
    public void ChooseNob()
    {
        //ドアノブフラグのみON
        this.chooseDrawerKey = false;
        this.chooseNob = true;
        this.chooseKey = false;
        this.chooseHammer = false;
        this.chooseCoin = false;
        this.chooseDriver = false;
        this.chooseLight = false;
        this.chooseIOU = false;
        this.chooseContract = false;
        this.chooseAgreement = false;
        this.chooseCrushedNob = false;
    }

    //ドアノブを入手している状態でアイテムリスト10を連続で2度クリックした時の処理
    public void ZoomNob()
    {
        if (this.chooseNob && this.listNob.activeSelf)
        {
            //回転可能にし、前回開いていたズームアイテムの位置を初期化
            this.rotFlag = true;
            if (this.zoomRotateScript.ZoomObject != null)
            {
                this.zoomRotateScript.memorizeFlag = true;
                this.zoomRotateScript.ZoomObject.transform.eulerAngles = this.zoomRotateScript.ZoomInitialRot;
            }
            //ドアノブのズーム画面のみを表示する
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(false);
            this.zoomList[2].SetActive(false);
            this.zoomList[3].SetActive(false);
            this.zoomList[4].SetActive(true);
            this.zoomList[5].SetActive(false);
            this.zoomList[6].SetActive(false);
            this.zoomList[7].SetActive(false);
            this.zoomList[8].SetActive(false);
            this.zoomList[9].SetActive(false);
            this.zoomList[10].SetActive(false);
            this.zoomList[11].SetActive(false);
        }
    }

    //ドアノブにハンマーを使った時の処理
    public void CrushNob()
    {
        if (this.chooseHammer && this.listHammer.activeSelf)
        {
            //アイテムリスト内のハンマーとドアノブを非表示にする
            this.listHammer.SetActive(false);
            this.listNob.SetActive(false);

            //壊れたノブのズーム画面を表示
            this.zoomList[4].SetActive(false);
            this.zoomList[6].SetActive(true);
            this.closeButton.SetActive(false);
            this.chooseHammer = false;
        }
    }


    public void ChooseCrushedNob()
    {
        //クラッシュドアノブフラグのみON
        this.chooseDrawerKey = false;
        this.chooseNob = true;
        this.chooseKey = false;
        this.chooseHammer = false;
        this.chooseCoin = false;
        this.chooseDriver = false;
        this.chooseLight = false;
        this.chooseIOU = false;
        this.chooseContract = false;
        this.chooseAgreement = false;
        this.chooseCrushedNob = true;
    }

    public void ZoomCrushedNob()
    {
        if (this.chooseCrushedNob && this.listCrushedNob.activeSelf)
        {
            //回転可能にし、前回開いていたズームアイテムの位置を初期化
            this.rotFlag = true;
            if (this.zoomRotateScript.ZoomObject != null)
            {
                this.zoomRotateScript.memorizeFlag = true;
                this.zoomRotateScript.ZoomObject.transform.eulerAngles = this.zoomRotateScript.ZoomInitialRot;
            }
            //クラッシュドアノブのズーム画面のみを表示する
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(false);
            this.zoomList[2].SetActive(false);
            this.zoomList[3].SetActive(false);
            this.zoomList[4].SetActive(false);
            this.zoomList[5].SetActive(false);
            this.zoomList[6].SetActive(true);
            this.zoomList[7].SetActive(false);
            this.zoomList[8].SetActive(false);
            this.zoomList[9].SetActive(false);
            this.zoomList[10].SetActive(false);
            this.zoomList[11].SetActive(false);
        }
    }
    //ハンマーをクリック時の処理
    public void GetHammer()
    {
        //ハンマーを破壊し、アイテムリストに表示させる
        Destroy(this.hammer);
        this.listHammer.SetActive(true);

        //ズーム画面と主人公のセリフを表示させる
        UIStateONGetItems();
        this.zoomList[3].SetActive(true);
        this.itemText.text = "ハンマーだ。何かに使えるかもしれないし持っておこう。";
    }

    //アイテムリスト3をクリックした時の処理
    public void ChooseHammer()
    {
        //ハンマーフラグのみON
        this.chooseDrawerKey = false;
        this.chooseNob = false;
        this.chooseKey = false;
        this.chooseHammer = true;
        this.chooseCoin = false;
        this.chooseDriver = false;
        this.chooseLight = false;
        this.chooseIOU = false;
        this.chooseContract = false;
        this.chooseAgreement = false;
        this.chooseCrushedNob = false;
    }

    //ハンマーを入手した状態でアイテムリスト3を連続で2度クリックした時の処理
    public void ZoomHammer()
    {
        if (this.chooseHammer && this.listHammer.activeSelf)
        {
            //回転可能にし、前回開いていたズームアイテムの位置を初期化
            this.rotFlag = true;
            if (this.zoomRotateScript.ZoomObject != null)
            {
                this.zoomRotateScript.memorizeFlag = true;
                this.zoomRotateScript.ZoomObject.transform.eulerAngles = this.zoomRotateScript.ZoomInitialRot;
            }
            //ハンマーのズーム画面を表示
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(false);
            this.zoomList[2].SetActive(false);
            this.zoomList[3].SetActive(true);
            this.zoomList[4].SetActive(false);
            this.zoomList[5].SetActive(false);
            this.zoomList[6].SetActive(false);
            this.zoomList[7].SetActive(false);
            this.zoomList[8].SetActive(false);
            this.zoomList[9].SetActive(false);
            this.zoomList[10].SetActive(false);
            this.zoomList[11].SetActive(false);
        }
    }

    //コイン1をクリック時の処理
    public void GetCoin1()
    {
        //コイン1を破壊しアイテムリストに表示
        Destroy(this.coins[0]);
        this.listCoins[0].SetActive(true);

        //入手しているコインの枚数に応じたズーム画面と主人公のセリフを表示
        UIStateONGetItems();
        this.zoomList[2].SetActive(true);
        this.zoomListCoins[0].SetActive(false);
        this.zoomListCoins[1].SetActive(false);
        this.zoomListCoins[2].SetActive(false);
        if (this.listCoins[0].activeSelf)
        {
            this.zoomListCoins[0].SetActive(true);
        }
        if (this.listCoins[1].activeSelf)
        {
            this.zoomListCoins[1].SetActive(true);
        }
        if (this.listCoins[2].activeSelf)
        {
            this.zoomListCoins[2].SetActive(true);
        }
        this.getCoinCount++;
        if (this.getCoinCount == 1)
        {
            this.itemText.text = "コインだ。…何のコインだろう？";
        }
        else if (this.getCoinCount == 2)
        {
            this.itemText.text = "コインだ。…さっきも拾ったな。何枚あるんだ？";
        }
        else if (this.getCoinCount == 3)
        {
            this.itemText.text = "コインだ。…これで3枚目だ。";
        }

    }

    //コイン2をクリック時の処理
    public void GetCoin2()
    {
        //コイン2を破壊しアイテムリストに表示
        Destroy(this.coins[1]);
        this.listCoins[1].SetActive(true);

        //入手しているコインの枚数に応じたズーム画面と主人公のセリフを表示
        UIStateONGetItems();
        this.zoomList[2].SetActive(true);
        this.zoomListCoins[0].SetActive(false);
        this.zoomListCoins[1].SetActive(false);
        this.zoomListCoins[2].SetActive(false);
        if (this.listCoins[0].activeSelf)
        {
            this.zoomListCoins[0].SetActive(true);
        }
        if (this.listCoins[1].activeSelf)
        {
            this.zoomListCoins[1].SetActive(true);
        }
        if (this.listCoins[2].activeSelf)
        {
            this.zoomListCoins[2].SetActive(true);
        }
        this.getCoinCount++;
        if (this.getCoinCount == 1)
        {
            this.itemText.text = "コインだ。…何のコインだろう？";
        }
        else if (this.getCoinCount == 2)
        {
            this.itemText.text = "コインだ。…さっきも拾ったな。何枚あるんだ？";
        }
        else if (this.getCoinCount == 3)
        {
            this.itemText.text = "コインだ。…これで3枚目だ。";
        }
    }

    //コイン3をクリック時の処理
    public void GetCoin3()
    {
        //コイン3を破壊しアイテムリストに表示
        Destroy(this.coins[2]);
        this.listCoins[2].SetActive(true);

        //入手しているコインの枚数に応じたズーム画面と主人公のセリフを表示
        UIStateONGetItems();
        this.zoomList[2].SetActive(true);
        this.zoomListCoins[0].SetActive(false);
        this.zoomListCoins[1].SetActive(false);
        this.zoomListCoins[2].SetActive(false);
        if (this.listCoins[0].activeSelf)
        {
            this.zoomListCoins[0].SetActive(true);
        }
        if (this.listCoins[1].activeSelf)
        {
            this.zoomListCoins[1].SetActive(true);
        }
        if (this.listCoins[2].activeSelf)
        {
            this.zoomListCoins[2].SetActive(true);
        }
        this.getCoinCount++;
        if (this.getCoinCount == 1)
        {
            this.itemText.text = "コインだ。…何のコインだろう？";
        }
        else if (this.getCoinCount == 2)
        {
            this.itemText.text = "コインだ。…さっきも拾ったな。何枚あるんだ？";
        }
        else if (this.getCoinCount == 3)
        {
            this.itemText.text = "コインだ。…これで3枚目だ。";
        }
    }

    //アイテムリスト2をクリックしたとき
    public void ChooseCoin()
    {
        //コインフラグのみON
        this.chooseDrawerKey = false;
        this.chooseNob = false;
        this.chooseKey = false;
        this.chooseHammer = false;
        this.chooseCoin = true;
        this.chooseDriver = false;
        this.chooseLight = false;
        this.chooseIOU = false;
        this.chooseContract = false;
        this.chooseAgreement = false;
        this.chooseCrushedNob = false;
    }
    //コインを1枚以上入手している状態でアイテムリスト2を連続で2度クリックしたとき
    public void ZoomCoin()
    {
        if (this.chooseCoin && (this.listCoins[0].activeSelf || this.listCoins[1].activeSelf || this.listCoins[2].activeSelf))
        {
            //回転可能にし、前回開いていたズームアイテムの位置を初期化
            this.rotFlag = true;
            if (this.zoomRotateScript.ZoomObject != null)
            {
                this.zoomRotateScript.memorizeFlag = true;
                this.zoomRotateScript.ZoomObject.transform.eulerAngles = this.zoomRotateScript.ZoomInitialRot;
            }
            //入手しているコインの枚数に応じた入手画面を表示
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(false);
            this.zoomList[2].SetActive(true);
            this.zoomList[3].SetActive(false);
            this.zoomList[4].SetActive(false);
            this.zoomList[5].SetActive(false);
            this.zoomList[6].SetActive(false);
            this.zoomList[7].SetActive(false);
            this.zoomList[8].SetActive(false);
            this.zoomList[9].SetActive(false);
            this.zoomList[10].SetActive(false);
            this.zoomList[11].SetActive(false);
            this.zoomListCoins[0].SetActive(false);
            this.zoomListCoins[1].SetActive(false);
            this.zoomListCoins[2].SetActive(false);
            if (this.listCoins[0].activeSelf)
            {
                this.zoomListCoins[0].SetActive(true);
            }
            if (this.listCoins[1].activeSelf)
            {
                this.zoomListCoins[1].SetActive(true);
            }
            if (this.listCoins[2].activeSelf)
            {
                this.zoomListCoins[2].SetActive(true);
            }
        }
    }

    //コインを赤スロットマシンに入れた時の処理
    public void RInCoin()
    {
        if (this.chooseCoin && this.cameraScript.zoomState[5])
        {
            //枚数をカウントする
            if (this.listCoins[0].activeSelf)
            {
                this.listCoins[0].SetActive(false);
                this.rCoinCount++;
            }
            else if (this.listCoins[1].activeSelf)
            {
                this.listCoins[1].SetActive(false);
                this.rCoinCount++;
            }
            else if (this.listCoins[2].activeSelf)
            {
                this.listCoins[2].SetActive(false);
                this.rCoinCount++;
            }
        }
    }

    //コインを青スロットマシンに入れた時の処理
    public void BInCoin()
    {
        if (this.chooseCoin && this.cameraScript.zoomState[6])
        {
            //枚数をカウントする
            if (this.listCoins[0].activeSelf)
            {
                this.listCoins[0].SetActive(false);
                this.bCoinCount++;
            }
            else if (this.listCoins[1].activeSelf)
            {
                this.listCoins[1].SetActive(false);
                this.bCoinCount++;
            }
            else if (this.listCoins[2].activeSelf)
            {
                this.listCoins[2].SetActive(false);
                this.bCoinCount++;
            }
        }
    }

    //ドライバークリック時の処理
    public void GetDriver()
    {
        if (this.cameraScript.zoomState[6])
        {
            //ドライバーを破壊しアイテムリストに表示させる
            Destroy(this.screwDriver);
            this.listDriver.SetActive(true);

            //ドライバーのズーム画面と主人公のセリフを表示
            UIStateONGetItems();
            this.zoomList[7].SetActive(true);
            this.itemText.text = "プラスドライバーだ。…どこか使えそうなとこあっただろうか？";
        }
    }

    //アイテムリスト9をクリックしたときの処理
    public void ChooseDriver()
    {
        //ドライバーフラグのみON
        this.chooseDrawerKey = false;
        this.chooseNob = false;
        this.chooseKey = false;
        this.chooseHammer = false;
        this.chooseCoin = false;
        this.chooseDriver = true;
        this.chooseLight = false;
        this.chooseIOU = false;
        this.chooseContract = false;
        this.chooseAgreement = false;
        this.chooseCrushedNob = false;
    }

    //ドライバーを入手している状態でアイテムリスト9を連続で2度クリックしたとき
    public void ZoomDriver()
    {

        if (this.chooseDriver && this.listDriver.activeSelf)
        {
            //回転可能にし、前回開いていたズームアイテムの位置を初期化
            this.rotFlag = true;
            if (this.zoomRotateScript.ZoomObject != null)
            {
                this.zoomRotateScript.memorizeFlag = true;
                this.zoomRotateScript.ZoomObject.transform.eulerAngles = this.zoomRotateScript.ZoomInitialRot;
            }
            //ドライバーのズーム画面を表示
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(false);
            this.zoomList[2].SetActive(false);
            this.zoomList[3].SetActive(false);
            this.zoomList[4].SetActive(false);
            this.zoomList[5].SetActive(false);
            this.zoomList[6].SetActive(false);
            this.zoomList[7].SetActive(true);
            this.zoomList[8].SetActive(false);
            this.zoomList[9].SetActive(false);
            this.zoomList[10].SetActive(false);
            this.zoomList[11].SetActive(false);
        }
    }

    //のりクリック時の処理
    public void GetBond()
    {
        if (this.cameraScript.zoomState[6])
        {
            //のりを破壊しアイテムリストに表示
            Destroy(this.stickBond);

            //のりのズーム画面と主人公のセリフを表示
            UIStateONGetItems();
            this.zoomList[7].SetActive(true);
            this.itemText.text = "のりだ…。これ、使い道なさそうな気が…";
        }
    }

    //ガムテープをクリックした時の処理
    public void GetTape()
    {
        if (this.cameraScript.zoomState[6])
        {
            Destroy(this.gamTape);
        }
    }

    public void GetCapsule1()
    {
        if (this.cameraScript.zoomState[6])
        {
            Destroy(this.capsules[0]);
        }
    }

    public void GetCapsule2()
    { 
            Destroy(this.capsules[1]);
    }


    //懐中電灯をクリックした時の処理
    public void GetFlashLight()
    {
        //懐中電灯を破壊しアイテムリストに表示
        Destroy(this.flashLight);
        this.listLight.SetActive(true);

        //懐中電灯のズーム画面と主人公のセリフを表示
        UIStateONGetItems();
        this.zoomList[8].SetActive(true);
        this.itemText.text = "懐中電灯だ！これがあれば暗いところを照らせるのでは!?";
    }

    //アイテムリスト4をクリックした時の処理
    public void ChooseLight()
    {
        //懐中電灯フラグのみON
        this.chooseDrawerKey = false;
        this.chooseNob = false;
        this.chooseKey = false;
        this.chooseHammer = false;
        this.chooseCoin = false;
        this.chooseDriver = false;
        this.chooseLight = true;
        this.chooseIOU = false;
        this.chooseContract = false;
        this.chooseAgreement = false;
        this.chooseCrushedNob = false;
    }

    //懐中電灯を入手している状態でアイテムリスト4を2度連続でクリックした時の処理
    public void ZoomLight()
    {
        if (this.chooseLight && this.listLight.activeSelf)
        {
            //回転可能にし、前回開いていたズームアイテムの位置を初期化
            this.rotFlag = true;
            if (this.zoomRotateScript.ZoomObject != null)
            {
                this.zoomRotateScript.memorizeFlag = true;
                this.zoomRotateScript.ZoomObject.transform.eulerAngles = this.zoomRotateScript.ZoomInitialRot;
            }
            //懐中電灯のズーム画面を表示
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(false);
            this.zoomList[2].SetActive(false);
            this.zoomList[3].SetActive(false);
            this.zoomList[4].SetActive(false);
            this.zoomList[5].SetActive(false);
            this.zoomList[6].SetActive(false);
            this.zoomList[7].SetActive(false);
            this.zoomList[8].SetActive(true);
            this.zoomList[9].SetActive(false);
            this.zoomList[10].SetActive(false);
            this.zoomList[11].SetActive(false);
        }
    }

    //懐中電灯ズーム画面で懐中電灯についているボタンを押した時
    public void ChangeLight()
    {
        this.lightAnimator.SetTrigger("ButtonON");
        this.zoomFlashSpotLight.enabled = !this.zoomFlashSpotLight.enabled;
        this.listFlashSpotLight.enabled = !this.listFlashSpotLight.enabled;
        this.lightButtonON = !this.lightButtonON;
    }

    //借用書をクリックしたときの処理
    public void GetIOU()
    {
        if (this.flashLightScript.IsIOUGettable)
        {
            Destroy(this.IOU);
            this.listIOU.SetActive(true);
            this.textCanvas.SetActive(true);
            this.textCamera.SetActive(true);
            this.textScript.scenerios = this.textScript.IOUScenerios;
            this.textScript.TextChanger();
        }
    }

    //アイテムリスト6をクリックした時の処理
    public void ChooseIOU()
    {
        this.chooseDrawerKey = false;
        this.chooseNob = false;
        this.chooseKey = false;
        this.chooseHammer = false;
        this.chooseCoin = false;
        this.chooseDriver = false;
        this.chooseLight = false;
        this.chooseIOU = true;
        this.chooseContract = false;
        this.chooseAgreement = false;
        this.chooseCrushedNob = false;
    }
    //借用書を入手している状態でアイテムリスト6を2度連続でクリックした時の処理
    public void ZoomIOU()
    {
        if (this.chooseIOU && this.listIOU.activeSelf)
        {
            //回転可能にし、前回開いていたズームアイテムの位置を初期化
            this.rotFlag = true;
            if (this.zoomRotateScript.ZoomObject != null)
            {
                this.zoomRotateScript.memorizeFlag = true;
                this.zoomRotateScript.ZoomObject.transform.eulerAngles = this.zoomRotateScript.ZoomInitialRot;
            }
            //IOUのズーム画面を表示
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(false);
            this.zoomList[2].SetActive(false);
            this.zoomList[3].SetActive(false);
            this.zoomList[4].SetActive(false);
            this.zoomList[5].SetActive(false);
            this.zoomList[6].SetActive(false);
            this.zoomList[7].SetActive(false);
            this.zoomList[8].SetActive(false);
            this.zoomList[9].SetActive(true);
            this.zoomList[10].SetActive(false);
            this.zoomList[11].SetActive(false);
        }
        
    }

    //契約書をクリックしたときの処理
    public void GetContract()
    {
        Destroy(this.contract);
        this.listContract.SetActive(true);
        UIStateONGetItems();
        this.zoomList[11].SetActive(true);
        this.textScript.scenerios = this.textScript.contractScenerios;
        this.textScript.TextChanger();
    }

    //アイテムリスト8をクリックしたときの処理
    public void ChooseContract()
    {
        this.chooseDrawerKey = false;
        this.chooseNob = false;
        this.chooseKey = false;
        this.chooseHammer = false;
        this.chooseCoin = false;
        this.chooseDriver = false;
        this.chooseLight = false;
        this.chooseIOU = false;
        this.chooseContract = true;
        this.chooseAgreement = false;
        this.chooseCrushedNob = false;
    }

//契約書を入手している状態でアイテムリスト8を2度連続でクリックした時の処理
public void ZoomContract()
    {
        if (this.chooseContract && this.listContract.activeSelf)
        {
            //回転可能にし、前回開いていたズームアイテムの位置を初期化
            this.rotFlag = true;
            if (this.zoomRotateScript.ZoomObject != null)
            {
                this.zoomRotateScript.memorizeFlag = true;
                this.zoomRotateScript.ZoomObject.transform.eulerAngles = this.zoomRotateScript.ZoomInitialRot;
            }
            // 契約書のズーム画面のみを表示
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(false);
            this.zoomList[2].SetActive(false);
            this.zoomList[3].SetActive(false);
            this.zoomList[4].SetActive(false);
            this.zoomList[5].SetActive(false);
            this.zoomList[6].SetActive(false);
            this.zoomList[7].SetActive(false);
            this.zoomList[8].SetActive(false);
            this.zoomList[9].SetActive(false);
            this.zoomList[10].SetActive(false);
            this.zoomList[11].SetActive(true);
        }
    }

    //同意書を入手したときの処理
    public void GetAgreement()
    {
        Destroy(this.agreement);
        this.listAgreement.SetActive(true);
        UIStateONGetItems();
        this.zoomList[10].SetActive(true);
        this.textScript.scenerios = this.textScript.agreementScenerios;
        this.textScript.TextChanger();
    }

    //アイテムリスト7をクリックしたときの処理
    public void ChooseAgreement()
    {
        this.chooseDrawerKey = false;
        this.chooseNob = false;
        this.chooseKey = false;
        this.chooseHammer = false;
        this.chooseCoin = false;
        this.chooseDriver = false;
        this.chooseLight = false;
        this.chooseIOU = false;
        this.chooseContract = false;
        this.chooseAgreement = true;
        this.chooseCrushedNob = false;
    }

    //同意書を入手している状態でアイテムリスト7を2度連続でクリックした時の処理
    public void ZoomAgreement()
    {
        if (this.chooseAgreement && this.listAgreement.activeSelf)
        {
            //回転可能にし、前回開いていたズームアイテムの位置を初期化
            this.rotFlag = true;
            if (this.zoomRotateScript.ZoomObject != null)
            {
                this.zoomRotateScript.memorizeFlag = true;
                this.zoomRotateScript.ZoomObject.transform.eulerAngles = this.zoomRotateScript.ZoomInitialRot;
            }
            //同意書のズーム画面のみを表示
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(false);
            this.zoomList[2].SetActive(false);
            this.zoomList[3].SetActive(false);
            this.zoomList[4].SetActive(false);
            this.zoomList[5].SetActive(false);
            this.zoomList[6].SetActive(false);
            this.zoomList[7].SetActive(false);
            this.zoomList[8].SetActive(false);
            this.zoomList[9].SetActive(false);
            this.zoomList[10].SetActive(true);
            this.zoomList[11].SetActive(false);
        }
    }

        //ズーム画面左上の×ボタンを押したときの処理
        public void OnCloseButton()
    {
        //全ズーム画面を非表示にする
        this.rotFlag = false;
        this.zoomCamera.SetActive(false);
        this.zoomList[0].SetActive(false);
        this.zoomList[1].SetActive(false);
        this.zoomList[2].SetActive(false);
        this.zoomList[3].SetActive(false);
        this.zoomList[4].SetActive(false);
        this.zoomList[5].SetActive(false);
        this.zoomList[6].SetActive(false);
        this.zoomList[7].SetActive(false);
        this.zoomList[8].SetActive(false);
        this.zoomList[9].SetActive(false);
        this.zoomList[10].SetActive(false);
        this.zoomList[11].SetActive(false);
        //ズームしていたアイテムの位置を初期化
        this.zoomRotateScript.memorizeFlag = true;
        this.zoomRotateScript.ZoomObject.transform.eulerAngles = this.zoomRotateScript.ZoomInitialRot;
    }

    public void UIStateONGetItems()
    {
        this.textCanvas.SetActive(true);
        this.textCamera.SetActive(true);
        this.zoomCamera.SetActive(true);
        this.closeButton.SetActive(false);
        this.bButton.SetActive(false);
    }

    //引き出し開閉フラグのプロパティ
    public bool DrawerOpen
    {
        get => this.drawerOpen;
    }

    //アイテム回転フラグのプロパティ
    public bool RotFlag
    {
        get => this.rotFlag;
        set => this.rotFlag = value;
    }

}

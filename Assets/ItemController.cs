using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public GameObject listKey;
    public GameObject door;
    public GameObject nob;
    public GameObject listNob;
    public GameObject hammer;
    public GameObject listHammer;
    public GameObject[] coins;
    public GameObject[] listCoins;
    public GameObject[] zoomList;
    public GameObject zoomCamera;
    public GameObject closeButton;
    public CameraController cameraScript;
    public GameObject[] drawerKeys;
    public GameObject[] listDrawerKeys;
    public GameObject[] zoomDrawerKeys;
    public GameObject[] zoomListCoins;   
    public int rCoinCount = 0;
    public int bCoinCount = 0;
    public DoorController doorScript;
    public bool chooseKey = false;
    public bool chooseNob = false;
    public bool chooseHammer = false;
    public bool chooseCoin = false;
    public bool chooseDrawerKey = false;
    private int clickCount = 0;
   
    // Start is called before the first frame update
    void Start()
    {      
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void GetDrawerKey()
    {
        if (this.cameraScript.zoomState[5])
        {
            Destroy(this.drawerKeys[1]);
            this.listDrawerKeys[1].SetActive(true);
        }
        else
        {
            Destroy(this.drawerKeys[0]);
            this.listDrawerKeys[0].SetActive(true); 
        }
    }
    public void ChooseDrawerKey()
    {
        this.chooseDrawerKey = true;
        this.chooseNob = false;
        this.chooseKey = false;
        this.chooseHammer = false;
        this.chooseCoin = false;
    }
    public void ZoomDrawerKey()
    {
        if (this.chooseDrawerKey & (this.listDrawerKeys[0].activeSelf || this.listDrawerKeys[1].activeSelf))
        {
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(true);
            this.zoomList[2].SetActive(false);
            this.zoomList[3].SetActive(false);
            this.zoomList[4].SetActive(false);
            this.zoomList[5].SetActive(false);
            this.zoomList[6].SetActive(false);
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
    public void GetKey()
    {
        this.zoomList[6].SetActive(false);
        this.zoomList[5].SetActive(true);
        this.closeButton.SetActive(true);
        this.listKey.SetActive(true);
    }
    
    public void UseKey()
    {
        if (this.cameraScript.zoomState[0] & this.chooseKey & this.listKey.activeSelf)
        {           
            Destroy(this.listKey);
            this.doorScript.lockState = true;
        }
    }
    
    public void ZoomKey()
    {
       if (this.chooseKey & this.listKey.activeSelf)
       {
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(false);
            this.zoomList[2].SetActive(false);
            this.zoomList[3].SetActive(false);
            this.zoomList[4].SetActive(false);
            this.zoomList[5].SetActive(true);
            this.zoomList[6].SetActive(false);
        }
    }
    
    public void ChooseKey()
    {
        this.chooseDrawerKey = false;
        this.chooseNob = false;
        this.chooseKey = true;
        this.chooseHammer = false;    
        this.chooseCoin = false;       
    }
   
    public void GetNob()
    {
        if (this.cameraScript.zoomState[0])
        {
            this.clickCount++;
            if (this.clickCount == 3)
            {
                Destroy(this.nob);
                this.listNob.SetActive(true);
            }
        }
    }
    
    public void ChooseNob()
    {
        this.chooseDrawerKey = false;
        this.chooseNob = true;
        this.chooseKey = false;
        this.chooseHammer = false;
        this.chooseCoin = false;
    }
    
    public void ZoomNob()
    {
        if(this.chooseNob & this.listNob.activeSelf)
        {
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(false);
            this.zoomList[2].SetActive(false);
            this.zoomList[3].SetActive(false);
            this.zoomList[4].SetActive(true);
            this.zoomList[5].SetActive(false);
            this.zoomList[6].SetActive(false);
        }
    }
    
    public void CrushNob()
    {
        if (this.chooseHammer & this.listHammer.activeSelf)
        {
            this.listHammer.SetActive(false);
            this.listNob.SetActive(false);
            this.zoomList[4].SetActive(false);
            this.zoomList[6].SetActive(true);
            this.closeButton.SetActive(false);
            this.chooseHammer = false;
        }
    }
    
    public void GetHammer()
    {       
            Destroy(this.hammer);
            this.listHammer.SetActive(true);
    }
    
    public void ChooseHammer()
    {
        this.chooseDrawerKey = false;
        this.chooseNob = false;
        this.chooseKey = false;
        this.chooseHammer = true;
        this.chooseCoin = false; 
    }
    
    public void ZoomHammer()
    {
        if (this.chooseHammer & this.listHammer.activeSelf)
        {
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(false);
            this.zoomList[2].SetActive(false);
            this.zoomList[3].SetActive(true);
            this.zoomList[4].SetActive(false);
            this.zoomList[5].SetActive(false);
            this.zoomList[6].SetActive(false);
        }
    }
    
    public void GetCoin1()
    {        
            Destroy(this.coins[0]);
            this.listCoins[0].SetActive(true);       
    }
    public void GetCoin2()
    {
        Destroy(this.coins[1]);
        this.listCoins[1].SetActive(true);
    }
    public void GetCoin3()
    {
        Destroy(this.coins[2]);
        this.listCoins[2].SetActive(true);
    }
    public void ZoomCoin()
    {
        if (this.chooseCoin & (this.listCoins[0].activeSelf || this.listCoins[1].activeSelf || this.listCoins[2].activeSelf))
        {
            this.zoomCamera.SetActive(true);
            this.zoomList[0].SetActive(false);
            this.zoomList[1].SetActive(false);
            this.zoomList[2].SetActive(true);
            this.zoomList[3].SetActive(false);
            this.zoomList[4].SetActive(false);
            this.zoomList[5].SetActive(false);
            this.zoomList[6].SetActive(false);
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
    public void RInCoin()
    {
        if (this.chooseCoin)
        {
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
    public void BInCoin()
    {
        if (this.chooseCoin)
        {
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
    public void ChooseCoin()
    {
        this.chooseDrawerKey = false;
        this.chooseNob = false;
        this.chooseKey = false;
        this.chooseHammer = false;
        this.chooseCoin = true;
    }

    public void OnCloseButtun()
    {
        this.zoomCamera.SetActive(false);
        this.zoomList[0].SetActive(false);
        this.zoomList[1].SetActive(false);
        this.zoomList[2].SetActive(false);
        this.zoomList[3].SetActive(false);
        this.zoomList[4].SetActive(false);
        this.zoomList[5].SetActive(false);
        this.zoomList[6].SetActive(false);
    }
}

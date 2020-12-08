using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    private GameObject inKey;
    private GameObject listKey;
    private GameObject doorAnchor;
    private GameObject nob;
    private GameObject listNob;
    private GameObject hammer;
    private GameObject listHammer;
    public GameObject[] zoomList;
    private GameObject zoomCamera;
    private GameObject closeButton;
    private GameObject mCamera;
    private CameraController cameraScript;
    private int clickCount;
    private DoorController doorScript;
    public bool chooseKey = false;
    public bool chooseNob = false;
    public bool chooseHammer = false;
    
   
    // Start is called before the first frame update
    void Start()
    {
        this.inKey = GameObject.Find("InKey");
        this.listKey = GameObject.Find("ItemListKey");
        this.doorAnchor = GameObject.Find("DoorAnchor");
        this.doorScript = doorAnchor.GetComponent<DoorController>();
        this.listKey.SetActive(false);
        this.nob = GameObject.Find("DoorNob");        
        this.listNob = GameObject.Find("ItemListDoorNob");       
        this.listNob.SetActive(false);
        this.hammer = GameObject.Find("Hammer");
        this.listHammer = GameObject.Find("ItemListHammer");
        this.listHammer.SetActive(false);
        this.zoomCamera = GameObject.Find("ZoomCamera");
        this.closeButton = GameObject.Find("CloseButton");
        this.mCamera = GameObject.Find("Main Camera");
        this.cameraScript = mCamera.GetComponent<CameraController>();
        this.zoomList[0].SetActive(false);
        this.zoomList[1].SetActive(false);
        this.zoomList[2].SetActive(false);
        this.zoomList[3].SetActive(false);
        this.zoomList[4].SetActive(false);
        this.zoomList[5].SetActive(false);
        this.zoomList[6].SetActive(false);
        this.zoomCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
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
        if (this.cameraScript.zoomState[0] & this.chooseKey)
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
        {
            this.chooseNob = false;
            this.chooseKey = true;
            this.chooseHammer = false;
        }
    }
   
    public void GetNob()
    {
        if (this.cameraScript.zoomState[0])
        {
            this.clickCount += 1;
            if (this.clickCount == 3)
            {
                Destroy(this.nob);
                this.listNob.SetActive(true);
            }
        }
    }
    
    public void ChooseNob()
    {
        {
            this.chooseNob = true;
            this.chooseKey = false;
            this.chooseHammer = false;
        }    
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
            this.zoomList[4].SetActive(false);
            this.zoomList[6].SetActive(true);
            this.closeButton.SetActive(false);
            this.chooseHammer = false;
            Destroy(this.listNob);
            Destroy(this.listHammer);   
        }
    }
    
    public void GetHammer()
    {
        Destroy(this.hammer);
        this.listHammer.SetActive(true);
    }
    
    public void ChooseHammer()
    {
        {
            this.chooseNob = false;
            this.chooseKey = false;
            this.chooseHammer = true;
        }
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCameraRotater : MonoBehaviour
{
    public ItemController iScript;
    public GameObject[] zoomDrawerkeys;
    public GameObject[] zoomCoin;
    public GameObject zoomHammer;
    public GameObject zoomNob;
    public GameObject zoomKey;
    public GameObject zoomDriver;
    public GameObject zoomLight;
    public GameObject zoomIOU;
    public GameObject zoomContract;
    public GameObject zoomCamera;
    public GameObject zoomAgreement;
    public float rotateSpeed = 10.0f;
    private Vector3 rotateAngle;
    private Vector2 lastMousePosition;
    private Vector3 initialRot;
    public bool memorizeFrag = true;
    private GameObject zoomObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateZoomObject();
    }

    private void RotateZoomObject()
    {
        if (this.iScript.RotFlag == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                this.lastMousePosition = Input.mousePosition;
            }
            else if (this.zoomDrawerkeys[0].activeInHierarchy && !this.zoomDrawerkeys[1].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomDrawerkeys[0];
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomDrawerkeys[1].activeInHierarchy && !this.zoomDrawerkeys[0].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomDrawerkeys[1];
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomDrawerkeys[1].activeInHierarchy && this.zoomDrawerkeys[0].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomDrawerkeys[2];
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomCoin[0].activeInHierarchy && !this.zoomCoin[1].activeInHierarchy && !this.zoomCoin[2].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomCoin[0];
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomCoin[1].activeInHierarchy && !this.zoomCoin[0].activeInHierarchy && !this.zoomCoin[2].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomCoin[1];
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomCoin[2].activeInHierarchy && !this.zoomCoin[0].activeInHierarchy && !this.zoomCoin[1].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomCoin[2];
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomCoin[0].activeInHierarchy && this.zoomCoin[1].activeInHierarchy && !this.zoomCoin[2].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomCoin[3];
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomCoin[0].activeInHierarchy && !this.zoomCoin[1].activeInHierarchy && this.zoomCoin[2].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomCoin[4];
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (!this.zoomCoin[0].activeInHierarchy && this.zoomCoin[1].activeInHierarchy && this.zoomCoin[2].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomCoin[5];
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomCoin[0].activeInHierarchy && this.zoomCoin[1].activeInHierarchy && this.zoomCoin[2].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomCoin[6];
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomHammer.activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomHammer;
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomNob.activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomNob;
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomKey.activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomKey;
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomDriver.activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomDriver;
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomLight.activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = zoomLight;
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomIOU.activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomIOU;
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomAgreement.activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomAgreement;
                    ChangeFlagRot();
                }
                RotateObject();
            }
            else if (this.zoomContract.activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.zoomObject = this.zoomContract;
                    ChangeFlagRot();
                }
                RotateObject();
            }
        }
    }

    public Vector3 ZoomInitialRot
    {
        get => this.initialRot;
    }

    public GameObject ZoomObject
    {
        get => this.zoomObject;
    }

    private void RotateObject()
    {
        this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
        this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
        this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
        this.lastMousePosition = Input.mousePosition;
    }

    private void ChangeFlagRot()
    {
        this.memorizeFrag = false;
        this.initialRot = this.zoomObject.transform.eulerAngles;
    }
}

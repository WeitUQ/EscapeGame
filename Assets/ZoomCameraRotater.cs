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
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomDrawerkeys[0];
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.z);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.z);
                this.lastMousePosition = Input.mousePosition;
            }
            else if (this.zoomDrawerkeys[1].activeInHierarchy && !this.zoomDrawerkeys[0].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomDrawerkeys[1];
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.x);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.z);
                this.lastMousePosition = Input.mousePosition;
            }
            else if (this.zoomDrawerkeys[1].activeInHierarchy && this.zoomDrawerkeys[0].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomDrawerkeys[2];
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
                this.lastMousePosition = Input.mousePosition;
            }
            else if (this.zoomCoin[0].activeInHierarchy && !this.zoomCoin[1].activeInHierarchy && !this.zoomCoin[2].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomCoin[0];
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
                this.lastMousePosition = Input.mousePosition;
            }
            else if (this.zoomCoin[1].activeInHierarchy && !this.zoomCoin[0].activeInHierarchy && !this.zoomCoin[2].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomCoin[1];
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
                this.lastMousePosition = Input.mousePosition;
            }
            else if (this.zoomCoin[2].activeInHierarchy && !this.zoomCoin[0].activeInHierarchy && !this.zoomCoin[1].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomCoin[2];
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
                this.lastMousePosition = Input.mousePosition;
            }
            else if (this.zoomCoin[0].activeInHierarchy && this.zoomCoin[1].activeInHierarchy && !this.zoomCoin[2].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomCoin[3];
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
                this.lastMousePosition = Input.mousePosition;
            }
            else if (this.zoomCoin[0].activeInHierarchy && !this.zoomCoin[1].activeInHierarchy && this.zoomCoin[2].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomCoin[4];
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
                this.lastMousePosition = Input.mousePosition;
            }
            else if (!this.zoomCoin[0].activeInHierarchy && this.zoomCoin[1].activeInHierarchy && this.zoomCoin[2].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomCoin[5];
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
                this.lastMousePosition = Input.mousePosition;
            }
            else if (this.zoomCoin[0].activeInHierarchy && this.zoomCoin[1].activeInHierarchy && this.zoomCoin[2].activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomCoin[6];
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
                this.lastMousePosition = Input.mousePosition;
            }
            else if (this.zoomHammer.activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomHammer;
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
                this.lastMousePosition = Input.mousePosition;
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
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomKey;
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
                this.lastMousePosition = Input.mousePosition;
            }
            else if (this.zoomDriver.activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomDriver;
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
                this.lastMousePosition = Input.mousePosition;
            }
            else if (this.zoomLight.activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.memorizeFrag = false;
                    this.zoomObject = zoomLight;
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
                this.lastMousePosition = Input.mousePosition;
            }
            else if (this.zoomIOU.activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomIOU;
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed,-Input.GetAxis("Mouse X") * this.rotateSpeed, 0 );
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
                this.lastMousePosition = Input.mousePosition;
            }
            else if (this.zoomAgreement.activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomAgreement;
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed,  -Input.GetAxis("Mouse X") * this.rotateSpeed,0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
                this.lastMousePosition = Input.mousePosition;
            }
            else if (this.zoomContract.activeInHierarchy && Input.GetMouseButton(0))
            {
                if (this.memorizeFrag == true)
                {
                    this.memorizeFrag = false;
                    this.zoomObject = this.zoomContract;
                    this.initialRot = this.zoomObject.transform.eulerAngles;
                }
                this.rotateAngle = new Vector3(Input.GetAxis("Mouse Y") * this.rotateSpeed, -Input.GetAxis("Mouse X") * this.rotateSpeed, 0);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.up), rotateAngle.y);
                this.zoomObject.transform.Rotate(this.zoomObject.transform.InverseTransformDirection(zoomCamera.transform.right), rotateAngle.x);
                this.lastMousePosition = Input.mousePosition;
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

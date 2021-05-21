using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorNobController : MonoBehaviour
{
    public ZoomItemRotater zcRotater;
    public ItemController iScript;
    public Animator doorNobAnimator;
    public GameObject[] zoomNobSphere;
    public GameObject zoomCamera;
    public GameObject closeButton;
    private int count = 0;
    private float i = 0.2f;
    private bool nobPivotChangeFlag1 = false;
    private bool nobPivotChangeFlag2 = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RemoveBolts1()
    {
        if (this.count == 0)
        {
            ChangeRotFlag();
            this.doorNobAnimator.SetTrigger("Removable1");
            count++;
        }
    }
    public void RemoveBolts2()
    {
        if (this.count == 0)
        {
            ChangeRotFlag();
            this.doorNobAnimator.SetTrigger("Removable2");
            count++;
        }
    }
    public void RemoveBolts3()
    {
        if (this.count == 0)
        {
            ChangeRotFlag();
            this.doorNobAnimator.SetTrigger("Removable3");
            count++;
        }
    }
    public void RemoveBolts4()
    {
        if (this.count == 0)
        {
            ChangeRotFlag();
            this.doorNobAnimator.SetTrigger("Removable4");
            count++;
        }
    }
    private void RotateNob1()
    {
            float angle1 = Mathf.LerpAngle(this.gameObject.transform.eulerAngles.x, 0, i);
            float angle2 = Mathf.LerpAngle(this.gameObject.transform.eulerAngles.y, -90, i);
            float angle3 = Mathf.LerpAngle(this.gameObject.transform.eulerAngles.z, -45, i);
            this.gameObject.transform.eulerAngles = new Vector3(angle1, angle2, angle3);
            i += 0.2f;
            if (i > 1.0f)
            {
                i = 0.2f;
            }
    }

    private void RotateNob2()
    {
            float angle1 = Mathf.LerpAngle(this.gameObject.transform.eulerAngles.x, -45, i);
            float angle2 = Mathf.LerpAngle(this.gameObject.transform.eulerAngles.y, 0, i);
            float angle3 = Mathf.LerpAngle(this.gameObject.transform.eulerAngles.z, -90, i);
            this.gameObject.transform.eulerAngles = new Vector3(angle1, angle2, angle3);
            i += 0.2f;
            if (i > 1.0f)
            {
                i = 0.2f;
            }
    }

    private void RotateNob3()
    {
            float angle1 = Mathf.LerpAngle(this.gameObject.transform.eulerAngles.x, 0, i);
            float angle2 = Mathf.LerpAngle(this.gameObject.transform.eulerAngles.y, 90, i);
            float angle3 = Mathf.LerpAngle(this.gameObject.transform.eulerAngles.z, -135, i);
            this.gameObject.transform.eulerAngles = new Vector3(angle1, angle2, angle3);
            i += 0.2f;
            if (i > 1.0f)
            {
                i = 0.2f;
            }
    }

    private void RotateNob4()
    {
            float angle1 = Mathf.LerpAngle(this.gameObject.transform.eulerAngles.x, 45, i);
            float angle2 = Mathf.LerpAngle(this.gameObject.transform.eulerAngles.y, 180, i);
            float angle3 = Mathf.LerpAngle(this.gameObject.transform.eulerAngles.z, -90, i);
        this.gameObject.transform.eulerAngles = new Vector3(angle1, angle2, angle3);
            i += 0.2f;
            if (i > 1.0f)
            {
                i = 0.2f;
            }
    }

    private void RotateNob5()
    {

        this.gameObject.transform.Rotate(this.gameObject.transform.InverseTransformDirection(zoomCamera.transform.right), 8);
    }

    private void ChangeNobPivot1()
    {
        this.nobPivotChangeFlag1 = !this.nobPivotChangeFlag1;
        this.zcRotater.ZoomObject = this.zoomNobSphere[0];
        this.zcRotater.ZoomInitialRot = this.zcRotater.ZoomObject.transform.eulerAngles;
    }

    
     private void ChangeRotFlag()
    {
        this.iScript.RotFlag = !this.iScript.RotFlag;
    }

    private void OnTriggerExit(Collider other)
    {
        this.nobPivotChangeFlag2 = !this.nobPivotChangeFlag2;
        this.nobPivotChangeFlag1 = !this.nobPivotChangeFlag1;
        this.zcRotater.ZoomObject = this.zoomNobSphere[1];
    }

    private void OffCloseButton()
    {
        this.closeButton.SetActive(false);
    }

    private void OnCloseButton()
    {
        this.closeButton.SetActive(true);
    }

    public bool NobPivotChangeFlag1
    {
        get => this.nobPivotChangeFlag1;
    }

    public bool NobPivotChangeFlag2
    {
        get => this.nobPivotChangeFlag2;
    }
}

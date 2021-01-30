using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightController : MonoBehaviour
{
    public ItemController iScript;
    public CameraController cScript;
    public Light underBedLight;
    private Ray ray;
    private RaycastHit hit;
    public LayerMask mask;
    private float rotateSpeed = 5f;
    private float minAng = 30;
    private float maxAng = 150;
    private Vector3 moveAng;
    private bool isIOUGettable = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //押した瞬間
        if (Input.GetMouseButtonDown(0) && this.iScript.chooseLight && this.cScript.zoomState[10] && !this.underBedLight.enabled && this.iScript.lightButtonON)
        {          
            this.underBedLight.enabled = true;
            this.moveAng = new Vector3(10, 90, 0);
        }
        //ドラッグ中
        else if (Input.GetMouseButton(0) && this.underBedLight.enabled)
        {
            this.ray = new Ray(this.underBedLight.transform.position, this.underBedLight.transform.rotation * new Vector3(0, 0.1f, 1.0f));
            if (Physics.Raycast(this.ray, out this.hit, 20.0f, this.mask))
            {
                this.isIOUGettable = true;
            }
            else
            {
                this.isIOUGettable = false;
            }
            Debug.DrawRay(this.ray.origin, this.ray.direction * 20.0f, Color.red, 2);
            this.moveAng.y += Input.GetAxis("Mouse X") * this.rotateSpeed;            
            if (150 < this.underBedLight.transform.eulerAngles.y)
            {
                this.moveAng.y = maxAng;              
            }
            if (this.underBedLight.transform.eulerAngles.y < 30)
            {
                this.moveAng.y = minAng;
            }
            this.underBedLight.transform.eulerAngles = moveAng;         
        }
        else if (this.iScript.lightButtonON == false)
        {
            this.underBedLight.enabled = false;
        }
        
    }      
    public bool IsIOUGettable
    {
        get => this.isIOUGettable;
    }
}

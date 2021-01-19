using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightAngleChanger : MonoBehaviour
{
    public ItemController iScript;
    public CameraController cScript;
    public Light underBedLight;
    private float rotateSpeed = 5f;
    private float minAng = 20;
    private float maxAng = 150;
    private Vector3 moveAng;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && this.iScript.chooseLight && this.cScript.zoomState[10] && !this.underBedLight.enabled && this.iScript.lightButtonON)
        {
            this.underBedLight.enabled = true;
            this.moveAng = new Vector3(0, 90, 0);
        }
        else if (Input.GetMouseButton(0) && this.underBedLight.enabled)
        {
            this.moveAng.y += Input.GetAxis("Mouse X") * this.rotateSpeed;            
            if (150 < this.underBedLight.transform.eulerAngles.y)
            {
                this.moveAng.y = maxAng;              
            }
            if (this.underBedLight.transform.eulerAngles.y < 20)
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
}

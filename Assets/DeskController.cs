using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskController : MonoBehaviour
{
    public Animator deskAnimator;//引き出しを開閉させるためのアニメーター
    public CameraController cScript;
    public ItemController iScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //引き出しズーム状態で一番上の引き出しをクリックしたとき
    public void DrawerStateChange1()
    {
        //1番上の引き出しの開閉アニメーション実行
        if (this.cScript.zoomState[3] && this.iScript.DrawerOpen)
        {
            this.deskAnimator.SetBool("Open1", !this.deskAnimator.GetBool("Open1"));
            this.cScript.drawerCollider[1].enabled = !this.cScript.drawerCollider[1].enabled;
            this.cScript.drawerCollider[2].enabled = !this.cScript.drawerCollider[2].enabled;
        }
    }

    //引き出しズーム状態で真ん中の引き出しをクリックしたとき
    public void DrawerStateChange2()
    {
        //真ん中の引き出しの開閉アニメーション実行
        if (this.cScript.zoomState[3])
        {
            this.deskAnimator.SetBool("Open2", !this.deskAnimator.GetBool("Open2"));
            this.cScript.drawerCollider[0].enabled = !this.cScript.drawerCollider[0].enabled;
            this.cScript.drawerCollider[2].enabled = !this.cScript.drawerCollider[2].enabled;
        }
    }

    //引き出しズーム状態で一番下の引き出しをクリックしたとき
    public void DrawerStateChange3()
    {
        //一番下の引き出しの開閉アニメーション実行
        if (this.cScript.zoomState[3])
        {
            this.deskAnimator.SetBool("Open3", !this.deskAnimator.GetBool("Open3"));
            this.cScript.drawerCollider[0].enabled = !this.cScript.drawerCollider[0].enabled;
            this.cScript.drawerCollider[1].enabled = !this.cScript.drawerCollider[1].enabled;
        }
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //スタート場面が押されたとき、シーンを切り替える
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotItemDropper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

    }
}

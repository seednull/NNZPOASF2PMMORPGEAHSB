﻿using UnityEngine;
using System.Collections;

public class _ObjLaptopScreenController : ObjController {

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        GameManager.instance.setUnhideDesktopNinjaDone();
    }
}

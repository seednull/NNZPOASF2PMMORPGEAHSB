﻿using UnityEngine;
using System.Collections;

public class _ObjPenController : ObjController {

	void Start () {
		toolTipMessage = "Das ist dein Stift";
	}

	void Update () {
		
		base.Update();
	}
	
	void OnTriggerStay2D(Collider2D col)
	{
		if (dragging || !draggingReady) return;
		print("collides pen");
	}
}

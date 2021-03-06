﻿using UnityEngine;
using System.Collections;

public class _ObjCoffeeCupController : ObjController {

    public GameObject stain;
    public GameObject paper;
    public Sprite empty;
	public AudioSource slurp;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        base.Update();
	}

    void OnTriggerStay2D(Collider2D col)
    {
		if (dragging || !draggingReady)	return;
        /*if (col.CompareTag("Self"))
        {
            GameManager.instance.setDrunkCoffeeDone();
            GetComponent<SpriteRenderer>().sprite = empty;
            stain.SetActive(true);
            paper.SetActive(true);
			slurp.Play();
        }*/
    }

    void OnMouseUp()
    {
        base.OnMouseUp();
        if (transform.position.y < -4) {
						GameManager.instance.setDrunkCoffeeDone ();
						GetComponent<SpriteRenderer> ().sprite = empty;
						stain.SetActive (true);
						paper.SetActive (true);
						slurp.Play ();
				} else if (!GameManager.instance.drunkCoffee)
						ToolTipController.instance.setToolTip ("Den Kaffee trinke ich lieber");
		else
			ToolTipController.instance.setToolTip ("Der Kaffee ist leer");
    }
}

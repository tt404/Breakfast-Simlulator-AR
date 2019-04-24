using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonA : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject button;
	public GameObject page;
	public MagazineHandler r;
	public bool right = false;


	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
		if (right == false)
			r.TurnPageLeft();
		else
			r.TurnPageRight();
	}

	// Use this for initialization
	void Start ()
	{
		button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

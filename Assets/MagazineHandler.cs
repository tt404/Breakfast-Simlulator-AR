using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineHandler : MonoBehaviour {
	public Texture[] textures;
	private int currentPage1 = 0, currentPage2 = 1;
	public GameObject page1, page2;


	public void TurnPageLeft()
	{
		currentPage1--;
		currentPage2--;

		if(currentPage1 < 0)
		{
			currentPage1 = textures.Length - 1;
		}

		if(currentPage2 < 0)
		{
			currentPage2 = textures.Length - 1;
		}

		SetTextures();
	}

	public void TurnPageRight()
	{
		currentPage1++;
		currentPage2++;

		if (currentPage1 >= textures.Length)
			currentPage1 = 0;
		if (currentPage2 >= textures.Length)
			currentPage2 = 0;

		SetTextures();
	}

	public void SetTextures()
	{
		page1.GetComponent<MeshRenderer>().material.mainTexture = textures[currentPage1];
		page2.GetComponent<MeshRenderer>().material.mainTexture = textures[currentPage2];
		Debug.Log("HIT!!!!! " + currentPage1 + " " + currentPage2);
	}

	// Use this for initialization
	void Start () {
		SetTextures();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

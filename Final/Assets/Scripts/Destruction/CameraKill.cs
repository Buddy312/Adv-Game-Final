using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraKill : MonoBehaviour
{
	/*private Camera _mycamera;

	void start()
	{
		_mycamera = GetComponent(Camera);
	}*/
	void OnTriggerEnter(Collider co)
	{
		Debug.Log(co.gameObject.name + " " + co.gameObject.tag);
		if (co.gameObject.tag == "Sphere")
		{
			GameObject.Find("Camera").SetActive(false);
			//_mycamera().enabled = false;
		}
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderProximity : MonoBehaviour {

	Material ColorRed1;
	Material ColorRed2;
	Material ColorRed3;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "MainSphere")
		{
			GetComponent<Renderer>().material = ColorRed2;
		}
	}

	private void OnCollisionExit(Collision collision)
	{
			if (collision.gameObject.name == "MainSphere")
			{
				GetComponent<Renderer>().material = ColorRed3;
			}
	}

	private void OnCollisionStay(Collision collision)
	{
			if (collision.gameObject.name == "MainSphere")
			{
				GetComponent<Renderer>().material = ColorRed1;
			}
	}

	// Use this for initialization
	void Start () {
		ColorRed1 = Resources.Load<Material>("ColorRed");
		ColorRed2 = Resources.Load<Material>("ColorRed2");
		ColorRed3 = Resources.Load<Material>("ColorRed3");
	}

	// Update is called once per frame
	void Update () {

	}
}

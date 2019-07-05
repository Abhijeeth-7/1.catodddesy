using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogmovements : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKey(KeyCode.LeftArrow))
		transform.Translate(new Vector3D(-0.09,0,0));
	}
	if(Input.GetKey(KeyCode.RightArrow))
	{
		transform.Translate(new Vector3D(0.09,0,0));
	}

}

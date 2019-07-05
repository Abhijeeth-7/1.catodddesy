using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerMove : MonoBehaviour {

	public bool col;
	// Use this for initialization
	void Start () {
		col = false;
	}
	
	// Update is called once per frame
	void Update () {
		run();
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(new Vector3(-0.15f,0,0));
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(new Vector2(0.15f,0,0));
		}	
		
	}
	void run()
	{
	if(col == true)
		transform.Translate(new Vector3(0,0,0.095f));
	else
	 return 1;
	}
	void OnTriggerEnter3D(Collider3D trigger)
	{
		if(trigger.gameObject.CompareTag("obstacle"))
		{
			col = true;
		}
	}

}

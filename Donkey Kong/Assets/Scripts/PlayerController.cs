using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey ("w"))
		{
			moveUp ();
		}

		if(Input.GetKey ("s"))
		{
			moveDown ();
		}

		if(Input.GetKey ("a"))
		{
			moveLeft ();
		}

		if(Input.GetKey ("d"))
		{
			moveRight ();
		}
	}

	void moveUp()
	{
		transform.position += new Vector3 (0, moveSpeed);
	}
	void moveDown()
	{
		transform.position -= new Vector3 (0, moveSpeed);
	}
	void moveLeft()
	{
		transform.position -= new Vector3 (moveSpeed, 0);
	}
	void moveRight()
	{
		transform.position += new Vector3 (moveSpeed, 0);
	}
}

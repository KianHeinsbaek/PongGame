using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneScript : MonoBehaviour
{
    private Rigidbody2D rigigbody2D;
    public float speed;
    //private Color playerOneColor = Color.red;

	// Use this for initialization
	void Start ()
	{
	    //gameObject.GetComponent<SpriteRenderer>().color = playerOneColor;
	}
	
	// Update is called once per frame
	void Update () {

	    if (Input.GetKeyDown(KeyCode.S))
	    {
	        gameObject.transform.position += new Vector3(0, -speed);
	    }

	    if (Input.GetKeyDown(KeyCode.W))
	    {
	        gameObject.transform.position += new Vector3(0, speed);
	    }

	    gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}

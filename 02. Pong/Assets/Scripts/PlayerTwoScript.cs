using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoScript : MonoBehaviour
{
    //private Color playerTwoColor = Color.blue;
    public float speed;

	// Use this for initialization
	void Start () {
	    //gameObject.GetComponent<SpriteRenderer>().color = playerTwoColor;
    }
	
	// Update is called once per frame
	void Update () {

	    if (Input.GetKeyDown(KeyCode.DownArrow))
	    {
	        gameObject.transform.position += new Vector3(0, -speed);
	    }

	    if (Input.GetKeyDown(KeyCode.UpArrow))
	    {
	        gameObject.transform.position += new Vector3(0, speed);
	    }

	    gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);

    }
}

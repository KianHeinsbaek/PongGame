using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    public int playerOnePoints = 0;
    public int playerTwoPoints = 0;

    private Rigidbody2D rigidbody2D;
    private Vector2 direction = new Vector2(10, 2);

	// Use this for initialization
	void Start ()
	{
        
    }
	
	// Update is called once per frame
	void Update ()
	{
	    transform.Translate(direction * Time.deltaTime);

	    if (playerOnePoints == 5)
	    {
	        GameObject.FindGameObjectWithTag("objective").GetComponent<Text>().text = "RED WINS!";

	        gameObject.transform.position = new Vector3(0, 0);
	        direction.x *= 0;

	        GameObject.FindGameObjectWithTag("winText").GetComponent<Text>().text = "Press SPACE for rematch!";

	        if (Input.GetKeyDown(KeyCode.Space))
	        {
	            gameObject.transform.position = new Vector3(0, 0);
	            direction.x = 10;
	            direction.y = 2;
	            playerOnePoints = 0;
	            playerTwoPoints = 0;
	            GameObject.FindGameObjectWithTag("playerOnePointsText").GetComponent<Text>().text =
	                "Points: " + playerOnePoints;
	            GameObject.FindGameObjectWithTag("playerTwoPointsText").GetComponent<Text>().text =
	                "Points: " + playerTwoPoints;
	            GameObject.FindGameObjectWithTag("winText").GetComponent<Text>().text = "";
            }
	    }

        if (playerTwoPoints == 5)
	    {
	        GameObject.FindGameObjectWithTag("objective").GetComponent<Text>().text = "BLUE WINS!";

	        gameObject.transform.position = new Vector3(0, 0);
	        direction.x *= 0;

	        GameObject.FindGameObjectWithTag("winText").GetComponent<Text>().text = "Press SPACE for rematch!";

	        if (Input.GetKeyDown(KeyCode.Space))
	        {
	            gameObject.transform.position = new Vector3(0, 0);
	            direction.x = 10;
	            direction.y = 2;
	            playerTwoPoints = 0;
	            playerOnePoints = 0;
	            GameObject.FindGameObjectWithTag("playerOnePointsText").GetComponent<Text>().text =
	                "Points: " + playerOnePoints;
	            GameObject.FindGameObjectWithTag("playerTwoPointsText").GetComponent<Text>().text =
	                "Points: " + playerTwoPoints;
	            GameObject.FindGameObjectWithTag("winText").GetComponent<Text>().text = "";
	        }
	    }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            direction.x *= -1;   
        }

        if (coll.gameObject.tag == "topWall")
        {
            direction.y *= -1;
        }

        if (coll.gameObject.tag == "bottomWall")
        {
            direction.y *= -1;
        }

        if (coll.gameObject.tag == "leftWall")
        {
            playerTwoPoints++;
            GameObject.FindGameObjectWithTag("playerTwoPointsText").GetComponent<Text>().text =
                "Points: " + playerTwoPoints;

            gameObject.transform.position = new Vector3(0, 0);
            direction.x *= -1;
        }

        if (coll.gameObject.tag == "rightWall")
        {
            playerOnePoints++;
            GameObject.FindGameObjectWithTag("playerOnePointsText").GetComponent<Text>().text =
                "Points: " + playerOnePoints;

            gameObject.transform.position = new Vector3(0, 0);
            direction.x *= -1;   
        }
    }
}

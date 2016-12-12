using UnityEngine;
using System.Collections;

public class RollBall : MonoBehaviour {

	public Rigidbody rb;
	public int speed = 10;
	float moveHorizontal;
	float moveVertical;

	// Use this for initialization
	void Start () {

		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	
	}
	
	// Update is called once per frame
	void Update () {
		moveHorizontal = Input.acceleration.x;
		moveVertical = Input.acceleration.y;                        
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed * 2);
	}
}

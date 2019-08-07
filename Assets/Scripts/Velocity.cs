using UnityEngine;
using System.Collections;

public class Velocity : MonoBehaviour {
	public float minSpeed;
	public bool printVelocity = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(printVelocity)
		{
			print(gameObject.GetComponent<Rigidbody2D>().velocity.magnitude);
		}
		if (gameObject.GetComponent<Rigidbody2D>().velocity.magnitude < minSpeed)
        {
            Destroy(gameObject);
        }
	}
}

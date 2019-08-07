using UnityEngine;
using System.Collections;

public class Destroy_on_angle_change : MonoBehaviour {
	public float angle_x;
	public float angle_y;
	public float angle_z;
	// Use this for initialization
	void Start () {
		angle_x = gameObject.transform.rotation.x;
		angle_y = gameObject.transform.rotation.y;
		angle_z = gameObject.transform.rotation.z;
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag != "Bullet") {
			if (transform.rotation.x != angle_x) {
				Destroy (gameObject);
			}
			if (transform.rotation.y != angle_y) {
				Destroy (gameObject);
			}
			if (transform.rotation.z != angle_z) {
				Destroy (gameObject);
			}
		}
	}
}

using UnityEngine;
using System.Collections;

public class Weapon_flip : MonoBehaviour {
	public float orig_scale;
	// Use this for initialization
	void Start () {
		orig_scale = transform.localScale.y;
	}
	
	// Update is called once per frame
	void Update () {
		


			if (Input.mousePosition.x > Screen.width / 2) {
			transform.localScale = new Vector3 (transform.localScale.x, orig_scale, transform.localScale.z);
            
			}
			if (Input.mousePosition.x < Screen.width / 2) {
			transform.localScale = new Vector3 (transform.localScale.x, -orig_scale, transform.localScale.z);
            

		}
    }
}

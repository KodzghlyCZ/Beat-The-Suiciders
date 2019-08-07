using UnityEngine;
using System.Collections;
public class destroy_on_collision : MonoBehaviour {
	public int Health = 10;
	public string Tag;
	public float destTime = 0;
	public GameObject[] Items;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0) 
		{
			Instantiate (Resources.Load ("Crate_destroy_sound"));
			Instantiate(Items[Random.Range(0, Items.Length)], transform.position, Quaternion.identity);
			Destroy (gameObject, destTime);
		}
	}
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == Tag)
			Health--;
	}
}

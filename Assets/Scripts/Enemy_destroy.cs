using UnityEngine;
using System.Collections;
public class Enemy_destroy : MonoBehaviour {
	//public GameObject bulletPrefab;
	//public int bulletSpeed;
	public float xValue;
	public float yValue;
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
            //Rigidbody2D bPrefab1 = Instantiate(bulletPrefab, new Vector3(transform.position.x + xValue, transform.position.y + yValue, transform.position.z), transform.rotation) as Rigidbody2D;
            //bPrefab1.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed);
            foreach (GameObject g in Items)
            {
                Instantiate(g, transform.position, Quaternion.identity);
            }
			
			Destroy (gameObject, destTime);
		}
	}
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == Tag)
			Health--;
	}
}

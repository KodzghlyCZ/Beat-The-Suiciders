using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ammo : MonoBehaviour {
    public int ammo;
	public Text text_Ammo;
	// Use this for initialization
	void Start () {
		
		text_Ammo = GameObject.Find ("Ammo_text").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		text_Ammo.text = ammo.ToString ();
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ammo_crate")
        {
            ammo += 100;
            Destroy(other.gameObject);
        }
    }
}

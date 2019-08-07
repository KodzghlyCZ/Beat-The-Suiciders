using UnityEngine;
using System.Collections;

public class Swap_weapons : MonoBehaviour {

    public GameObject gun1;
    public GameObject gun2;
	public GameObject gun3;
    public GameObject player;
    
    // Use this for initialization
    void Start () {
        player = this.gameObject;

        gun1 = transform.Find("Rifle").gameObject;
        gun2 = transform.Find("Minigun").gameObject;
		gun3 = transform.Find("P90").gameObject;
    }

    // Update is called once per frame
    void OnTriggerStay2D(Collider2D other)
    {
        if ((other.tag == "Rifle") && (Input.GetKeyDown(KeyCode.E)))
        {
            gun1.SetActive (true);
            gun2.SetActive (false);
			gun3.SetActive (false);
            Destroy(other.gameObject);
			//GameObject myItem = Instantiate(Resources.Load("Minigun_drop"), transform.position + new Vector3(0,1.5F,0), transform.rotation) as GameObject;

        }
        if ((other.tag == "Minigun") && (Input.GetKeyDown(KeyCode.E)))
        {
            gun1.SetActive (false);
            gun2.SetActive (true);
			gun3.SetActive (false);
            Destroy(other.gameObject);
			//GameObject myItem = Instantiate(Resources.Load("Rifle_drop"), transform.position + new Vector3(0,1.5F,0), transform.rotation) as GameObject;

        }
		if ((other.tag == "P90") && (Input.GetKeyDown(KeyCode.E)))
		{
			gun1.SetActive (false);
			gun2.SetActive (false);
			gun3.SetActive (true);
			Destroy(other.gameObject);
			//GameObject myItem = Instantiate(Resources.Load("Rifle_drop"), transform.position + new Vector3(0,1.5F,0), transform.rotation) as GameObject;

		}
    }
}

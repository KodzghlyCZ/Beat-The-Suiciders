using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HP : MonoBehaviour {
    public int Health;
    public Text text_HP;
   
    void Start () {
        text_HP = GameObject.Find("HP_text").GetComponent<Text>();
    }

	
	
	void Update ()
    {
    text_HP.text = Health.ToString();
    }
    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "hamburger") 
        {
            Health--;
      
        }
       
    }
}


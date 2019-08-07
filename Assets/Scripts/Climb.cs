using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D col)
    {

        if (col.tag == "Ladder")
        {

            GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            {
                if (Input.GetKey(KeyCode.W))
                {
                    transform.Translate(Vector3.up * Time.deltaTime * 4, Space.World);
                }

            }
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ladder")
            GetComponent<Rigidbody2D>().gravityScale = 1;
    }
}

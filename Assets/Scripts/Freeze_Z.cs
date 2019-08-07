using UnityEngine;
using System.Collections;

public class Freeze_Z : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {
        Vector3 oldRot = transform.rotation.eulerAngles; transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}

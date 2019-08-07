using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour
{
    Transform target;
    public float speed = .01f;
    public string name;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {


        target = GameObject.FindWithTag(name).transform;

        Vector3 forwardAxis = new Vector3(0, 0, -1);




        transform.LookAt(target.position, forwardAxis);
       
        transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z);
        transform.position -= transform.TransformDirection(Vector2.up) * speed;
    }

}
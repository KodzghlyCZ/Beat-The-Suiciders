using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_jump : MonoBehaviour
{
    Rigidbody2D r2d;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        StartCoroutine(waiter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator waiter()
    {
        while (true)
        {
            int wait_time = Random.Range(0, 5);
            yield return new WaitForSeconds(wait_time);
            r2d.AddForce(transform.up * force);
        }
    }
}

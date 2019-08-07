using UnityEngine;
using System.Collections;

public class shooter_cs_minigun : MonoBehaviour
{

    public Rigidbody2D bulletPrefab;
    public float attackSpeed = 0.5f;
    public float coolDown;
    public float bulletSpeed = 500;
    public float yValue = 1f; // Used to make it look like it's shot from the gun itself (offset)
    public float xValue = 0.2f; // Same as above
    public bool isFiring;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isFiring = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isFiring = false;
        }

        if (Time.time >= coolDown)
        {
            if (isFiring == true)
            {
                Fire();
            }
        }
    }

    void Fire()
    {
        //Rigidbody2D bPrefab = Instantiate(bulletPrefab,transform.position,Quaternion.identity) as Rigidbody2D;

        Rigidbody2D bPrefab = Instantiate(bulletPrefab, new Vector3(transform.position.x + xValue, transform.position.y + yValue, transform.position.z), transform.rotation) as Rigidbody2D;

        bPrefab.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed);

        coolDown = Time.time + attackSpeed;
    }
}

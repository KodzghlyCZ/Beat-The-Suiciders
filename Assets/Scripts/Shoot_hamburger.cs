using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class Shoot_hamburger : MonoBehaviour
{

    public Rigidbody2D bulletPrefab;
    public float attackSpeed = 0.5f;
    public float coolDown;
    public float bulletSpeed = 500;
    public float yValue = 1f; // Used to make it look like it's shot from the gun itself (offset)
    public float xValue = 0.2f; // Same as above
    public float nextActionTime = 0.0F;
    public float period = 1;

    void Start()
    {
        Transform player = transform.parent.parent;
        Ammo playerScript = player.GetComponent<Ammo>();
    }
    void Update()
    {

        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            Rigidbody2D bPrefab = Instantiate(bulletPrefab, new Vector3(transform.position.x + xValue, transform.position.y + yValue, transform.position.z), transform.rotation) as Rigidbody2D;

            bPrefab.GetComponent<Rigidbody2D>().AddForce(transform.up * bulletSpeed);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            // execute block of code here
        }
    }

   
}

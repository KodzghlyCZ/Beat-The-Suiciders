using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class shooter_cs : MonoBehaviour
{
    public Rigidbody2D bulletPrefab;
    public float attackSpeed = 0.5f;
    public float coolDown;
    public float bulletSpeed = 500;
    public float yValue = 1f; 
    public float xValue = 0.2f; 
	public GameObject player;

	void Start()
	{
		Transform player = transform.parent.parent;
		Ammo playerScript = player.GetComponent<Ammo>();
	}
    void Update()
    {

        if (Time.time >= coolDown)
        {
			
			Ammo playerScript = player.GetComponent<Ammo>();
			if ((Input.GetMouseButton(0)) && (playerScript.ammo > 0) && !((transform.parent.gameObject.transform.rotation.eulerAngles.z <=128) && (transform.parent.gameObject.transform.rotation.eulerAngles.z >= 54)))
            {
                Fire();
            
            }
        }
    }

    void Fire()
    {
		Transform player = transform.parent.parent;
		Ammo playerScript = player.GetComponent<Ammo>();
		playerScript.ammo--;
        Rigidbody2D bPrefab = Instantiate(bulletPrefab, new Vector3(transform.position.x + xValue, transform.position.y + yValue, transform.position.z), transform.rotation) as Rigidbody2D;

        bPrefab.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed);
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
        coolDown = Time.time + attackSpeed;

    }
}

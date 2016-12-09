using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

    public GameObject bullet;
    public float speed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        bullet.GetComponent<Bullet>().speed = speed;
    }

    public void Shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
}


using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float speed;
    Rigidbody rigid;
    private float Timer;
    public float bulletExistTime;


    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        rigid.velocity = transform.TransformDirection(Vector3.forward * speed);

        Timer += 1.0f * Time.deltaTime;
        if (Timer >= bulletExistTime)
            GameObject.Destroy(gameObject);
    }

}

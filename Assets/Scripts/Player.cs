using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed;
    public Gun gun;
    public float fireRate;
    public float nextFire;
    public Text shot;
    public int shotNumber;


    // Use this for initialization
    void Start () {
	
	}

    void setShotText()
    {
        shot.text = "shot:" + shotNumber.ToString();
    }

    // Update is called once per frame
    void Update () {

        if(Input.GetAxis("Right_Trigger") == 1 && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            gun.Shoot();
            shotNumber+=1;
            setShotText();
        }

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Translate(x * Time.deltaTime * speed,0, y * Time.deltaTime * speed, Space.World);

        float rx = Input.GetAxis("Right_Horizontal");
        float ry = Input.GetAxis("Right_Vertical");

        float angle = Mathf.Atan2(rx, ry);

        transform.rotation = Quaternion.EulerAngles(0, angle, 0);

    }
}

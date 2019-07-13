using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseScript : MonoBehaviour {

    public GameObject target;
    //public GameObject rEye;
    //public GameObject lEye;
    public GameObject tiro;
    public float speed = 300f;
    public bool onAir = false;

    public GameObject spawnTiro;

    public bool hasTarget = false;

    //private GameObject tiroNoAr1, tiroNoAr2;

	void Start () {
        }

	void Update () {

        //if (!hasTarget)
        //    target = null;

        //if (Input.GetMouseButtonDown(1))
        //{

        //}

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("atirou");
            GameObject tiroNoAr = Instantiate(tiro, spawnTiro.transform.position, spawnTiro.transform.rotation);
            //tiroNoAr.GetComponent<Rigidbody>().velocity = transform.forward * speed;
        }

        //if (onAir)
        //{
        //    tiroNoAr = Instantiate(tiro, rEye.transform.position, rEye.transform.rotation);
        //    tiroNoAr.transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);

        //    tiroNoAr = Instantiate(tiro, lEye.transform.position, lEye.transform.rotation);
        //    tiroNoAr.transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
        //}
	}
}

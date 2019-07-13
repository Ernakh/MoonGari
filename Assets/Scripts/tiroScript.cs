using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiroScript : MonoBehaviour
{

    private Rigidbody rdTiro;
    public float speed = 1000;

    public GameObject particulaExplosao;

    private CameraShake shake;

    //public generalScript gameManager;



    //vars of the shake
    private float shakeSpeed = 0.01f;

    void Start()
    {
        //rdTiro = this.GetComponent<Rigidbody>();
        //shake = personagemCamera.GetComponent<CameraShake>();
        //gameManager = GameObject.FindGameObjectWithTag("gameManager").GetComponent<generalScript>();
        shake = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraShake>();
    }


    void Update()
    {
        this.transform.Translate(0, 0, (40 * Time.deltaTime));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "item" || collision.transform.tag == "throwItem")
        {
            StartCoroutine(shake.Shake(0.4f, 1.0f));

            Instantiate(particulaExplosao, this.transform.position, this.transform.rotation);

            Destroy(collision.gameObject);

            

            //Destroy(this.gameObject);
        }

        Destroy(this.gameObject);
    }
}

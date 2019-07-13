using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixoScript : MonoBehaviour
{
    public bool isBilu = false;
    public bool onAir = false;
    private Rigidbody rdItem;

    public AudioSource audioS;
    public AudioClip bilu;

    public generalScript scriptGeral;
    public mouseScript player;

    private GameObject particulaSpark;

    public float timeTillBiluSays = 0;

    public float shakeSpeed = 0.01f;



    void Start()
    {
        audioS = this.GetComponent<AudioSource>();
        rdItem = this.GetComponent<Rigidbody>();
        particulaSpark = GameObject.FindGameObjectWithTag("spark");

        if(isBilu)
            Instantiate(particulaSpark, this.transform);

    }

    private void Awake()
    {
    }

    private void Update()
    {

    }

    void FixedUpdate()
    {
        timeTillBiluSays += Time.deltaTime;

        //se estiver no ar, usar velocity para andar pelo ar
        if (onAir == true)
        {
            rdItem.velocity = new Vector3(1.2f, rdItem.velocity.y);
            transform.Rotate(0, 0, zAngle: -0.5f);

        }

        if (isBilu == true)
        {
            //this.GetComponent<Rigidbody>().AddForce(shakeSpeed, shakeSpeed, 0);

            this.transform.Translate(shakeSpeed, shakeSpeed, 0);
            

            shakeSpeed *= -1;

            if (timeTillBiluSays >= 3f)
            {
                //float randomized;

                //randomized = Random.Range(1, 7);

                //if(randomized == 1)
                //    audioS.PlayOneShot(bilu1);
                //else if (randomized == 2)
                //    audioS.PlayOneShot(bilu2);
                //else if (randomized == 3)
                //    audioS.PlayOneShot(bilu3);
                //else if (randomized == 4)
                //    audioS.PlayOneShot(bilu4);
                //else if (randomized == 5)
                //    audioS.PlayOneShot(bilu5);
                //else if (randomized == 6)
                //    audioS.PlayOneShot(bilu6);
                //else if (randomized == 7)
                //    audioS.PlayOneShot(bilu7);
                audioS.PlayOneShot(bilu);

                timeTillBiluSays = 0;
            }
        }

        if (this.transform.position.y <= -20 || this.transform.position.y >= 15.4)
        {
            this.transform.position = new Vector3(-10f, 15f, 57f);
        }

        

    }

    private void OnMouseDown()
    {
        if (isBilu == true)
        {
            Debug.Log("BiluMorreu");
            scriptGeral.qtdBilus--;
        }



        //player.target = this.gameObject;
        //player.hasTarget = true;
        //player.onAir = true;
        //Destroy(this.gameObject);
    }

}

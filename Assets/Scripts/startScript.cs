using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class startScript : MonoBehaviour
{
    private const int Z = 10;
    public float waitTime = 0;
    public GameObject player;
    public GameObject truck;
    private Rigidbody playerRD;
    private GameObject[] items;

    void Start()
    {
        playerRD = player.GetComponent<Rigidbody>();
        items = GameObject.FindGameObjectsWithTag("throwItem");
    }
    void Update()
    {
        waitTime += Time.deltaTime;
        if(waitTime >= 3)
        {
            this.transform.Translate(0, 0.05f, 0);
        }

        if(waitTime >= 6)
        {
            if(playerRD.velocity.z < 10)
                playerRD.AddForce(0, 0, 50);

            

            for (int i = 0; i < items.Length; i++)
            {

                Rigidbody rd = items[i].GetComponent<Rigidbody>();
                rd.AddForce(0, 0, 25);
            }
        }

        if(waitTime >= 8)
        {

            player.GetComponent<Collider>().enabled = false;
            player.GetComponent<FirstPersonController>().enabled = true;
            player.GetComponent<CharacterController>().enabled = true;
            player.GetComponentInChildren<mouseScript>().enabled = true;
            playerRD.isKinematic = true;
            Destroy(truck);
        }
    }
}

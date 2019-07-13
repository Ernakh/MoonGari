using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generalScript : MonoBehaviour
{
    private bool win = false;
    private GameObject[] items;
    private float randomized;
    public AudioClip bilu;

    public float qtdBilus = 3;
    private float spawnaBilus = 0;
    private bool gameStart = false;

    //private GameObject personagemCamera;
    //private CameraShake shake;

    //public bool isShaking;

    public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11;

    void Start()
    {
        //shake = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraShake>();
        for (int i = 0; i < 10; i++)
        {
            Instantiate(obj1, this.transform.position, this.transform.rotation);
            Instantiate(obj2, this.transform.position, this.transform.rotation);
            Instantiate(obj3, this.transform.position, this.transform.rotation);
            Instantiate(obj4, this.transform.position, this.transform.rotation);
            Instantiate(obj5, this.transform.position, this.transform.rotation);
            Instantiate(obj6, this.transform.position, this.transform.rotation);
            Instantiate(obj7, this.transform.position, this.transform.rotation);
            Instantiate(obj8, this.transform.position, this.transform.rotation);
            Instantiate(obj9, this.transform.position, this.transform.rotation);
            Instantiate(obj10, this.transform.position, this.transform.rotation);
            Instantiate(obj11, this.transform.position, this.transform.rotation);
        }

        spawnarBilus();
    }

    void spawnarBilus()
    {
        //pegar todos os itens do jogo, randomizar até um ser o Bilu 
        items = GameObject.FindGameObjectsWithTag("item");
        //Debug.Log(items);
        for (int i = 0; i < items.Length; i++)
        {
            var euler = transform.eulerAngles;
            euler.z = Random.Range(0, 360);
            items[i].transform.eulerAngles = euler;

            randomized = Random.Range(-0.5f, 2.5f);

            items[i].transform.localScale += new Vector3(randomized, randomized, randomized);


        }

        for (int i = 0; i < items.Length; i++)
        {
            Debug.Log(i);
            lixoScript lixo;
            lixo = items[i].GetComponent<lixoScript>();
            randomized = Random.Range(1, 20);

            if (randomized == 3)
            {
                spawnaBilus++;
                lixo.isBilu = true;
                //lixo.GetComponent<AudioSource>().loop = true;
                lixo.GetComponent<AudioSource>().clip = bilu;
                //lixo.GetComponent<AudioSource>().Play();
            }

            if (spawnaBilus >= 3)
                break;

            if (i == items.Length - 1)
                i = -1;
        }

        gameStart = true;

        //if(isShaking)
        //    StartCoroutine(shake.Shake(0.4f, 1.0f));
    }

    void Update()
    {
        if(qtdBilus <= 0 && gameStart)
        {
            Debug.Log("todos os bilus mortos");
        }
    }
}

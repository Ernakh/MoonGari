using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public generalScript gameManager;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("gameManager").GetComponent<generalScript>();
    }

    public IEnumerator Shake(float duration, float magnitude)
    {
        //gameManager.isShaking = false;
        
        Vector3 orignalPosition = transform.position;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-0.1f, 1.0f) * magnitude;

            transform.localPosition = new Vector3(x, y, 0);
            elapsed += Time.deltaTime;
            yield return 0;
        }

        transform.position = orignalPosition;
    }
}
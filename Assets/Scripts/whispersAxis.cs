using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whispersAxis : MonoBehaviour
{
    Transform player;
    AudioSource audioSource;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        audioSource = GetComponentInChildren<AudioSource>();
        StartCoroutine(waitForNewPosition());      
    }

    void Update()
    {
        transform.position = player.position;
        audioSource.volume += Time.deltaTime/10;
    }

    IEnumerator waitForNewPosition()
    {
        while(true)
        {
            transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            yield return new WaitForSecondsRealtime(Random.Range(1.5f, 4.5f));
        }
    }
}
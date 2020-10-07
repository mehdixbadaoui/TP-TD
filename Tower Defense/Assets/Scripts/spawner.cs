using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform prefab;
    public Transform spawn;

    private float countdown = 2f;
    public float waverest = 10f;
    // Update is called once per frame

    void Update(){
        if(countdown <= 0){
            StartCoroutine(spanWave());
            Instantiate(prefab, spawn.position, spawn.rotation);
            countdown = waverest;
        }   
        countdown -= Time.deltaTime;
    }

    IEnumerator spanWave(){
        for (int i = 0; i < 5; i++)
        {
            Instantiate(prefab, spawn.position, spawn.rotation);
            yield return new WaitForSeconds(0.3f);
        }
    }
}

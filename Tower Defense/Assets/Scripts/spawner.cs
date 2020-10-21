using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform prefab;
    public Transform spawn;
    int wavenumber = 0;

    private float countdown = 2f;
    public float waverest = 5f;
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
        for (int i = 0; i < 1; i++)
        {
            Instantiate(prefab, new Vector3(1, 1, 1), spawn.rotation);
            yield return new WaitForSeconds(2f);
        }
        wavenumber++;
        Debug.Log(wavenumber);
    }
}

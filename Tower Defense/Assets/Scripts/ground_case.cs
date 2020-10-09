using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_case : MonoBehaviour
{
    public Transform prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown(){

        Instantiate(prefab, transform.position, transform.rotation);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

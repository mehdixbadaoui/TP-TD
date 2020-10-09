using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class building : MonoBehaviour
{
    public static building instance;

    void Awake(){
        instance = this;
    }

    public GameObject turret1;


    // Start is called before the first frame update
    private GameObject toBuild;
    public GameObject getToBuild(){
        return toBuild;
    }
    void Start()
    {
        toBuild = turret1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

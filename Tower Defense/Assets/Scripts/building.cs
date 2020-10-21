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
    public GameObject turret2;
    public GameObject turret3;

    private GameObject turretToBuild;

    public GameObject getToBuild(){

        return turretToBuild;
    }

    public void setToBuild(GameObject t){
        turretToBuild = t;
    }
    void Start()
    {
        turretToBuild = turret1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

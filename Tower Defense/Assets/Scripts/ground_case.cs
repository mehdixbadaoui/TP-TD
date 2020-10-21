﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_case : MonoBehaviour
{
    public Transform prefab;
    GameObject  turret;
    public bool buildable = true;
    public Color hover_color_good;
    public Color hover_color_bad;
    public Color base_color;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = base_color;
    }

    void OnMouseEnter(){
        if(buildable){
            GetComponent<Renderer>().material.color = hover_color_good;
            
        }
        else{
            GetComponent<Renderer>().material.color = hover_color_bad;
        }
    }
    void OnMouseDown(){
        if(buildable){

            GameObject turretToBuild = manager.instance.getToBuild();
            if (manager.instance.getStonks() - manager.instance.buildCost(turretToBuild) > 0)
            {
                turret = (GameObject)Instantiate(turretToBuild, transform.position + new Vector3(0, 1, 0), transform.rotation);
                manager.instance.gainStonks(manager.instance.buildCost(turretToBuild) * -1);
                buildable = false;

            }
            else
            {
                Debug.Log("you are too poor");
            }

        }
        

    }

    void OnMouseExit(){
        GetComponent<Renderer>().material.color = base_color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

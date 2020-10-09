using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_case : MonoBehaviour
{
    public Transform prefab;
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
            Instantiate(prefab, transform.position, transform.rotation);

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

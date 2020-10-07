using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patharray : MonoBehaviour
{
    public static Transform[] targets;

    void Awake(){
        targets = new Transform[transform.childCount];
        for (int i = 0; i < targets.Length; i++)
        {
            targets[i] = transform.GetChild(i);
        }

        // Debug.Log("patharray" + targets.Length);

    }
    void Start(){
        // Debug.Log(targets.Length);
    }

}

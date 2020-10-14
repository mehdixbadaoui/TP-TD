using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drahemrbk : MonoBehaviour
{
    private int stonks;
    
    // Start is called before the first frame update
    void Start()
    {
        stonks = 500;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gainStonks(int g)
    {
        stonks += g;
    }
}

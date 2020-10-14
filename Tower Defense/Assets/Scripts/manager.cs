using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public static manager instance;
    private static int stonks;
    private Text stonks_text;

    void Awake()
    {
        instance = this;
    }

    public GameObject turret1;
    public GameObject turret2;
    public GameObject turret3;

    private GameObject turretToBuild;

    public GameObject getToBuild()
    {

        return turretToBuild;
    }

    public void setToBuild(GameObject t)
    {
        turretToBuild = t;
    }
    void Start()
    {
        stonks = 500;
        turretToBuild = turret1;
        stonks_text = GameObject.Find("stonks").GetComponent<Text>();
        stonks_text.text = stonks.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void gainStonks(int butin)
    {
        stonks += butin;
        stonks_text.text = stonks.ToString();

    }

    private void updateStonks()
    {

    }
}

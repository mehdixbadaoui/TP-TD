using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public static manager instance;
    private static int stonks;
    private Text stonks_text;
    private Text lives_text;
    private int lives;

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
    public int buildCost(GameObject turret)
    {
        if (turret == turret1) return 200;
        if (turret == turret2) return 400;
        if (turret == turret3) return 500;
        else return 0;
    }

    public void setToBuild(GameObject t)
    {
        turretToBuild = t;
    }
    void Start()
    {
        stonks = 500;
        lives = 10;
        turretToBuild = turret1;
        stonks_text = GameObject.Find("stonks").GetComponent<Text>();
        stonks_text.text = stonks.ToString();
        lives_text = GameObject.Find("Text").GetComponent<Text>();
        lives_text.text = lives.ToString();
    }

    public void gainStonks(int butin)
    {
        stonks += butin;
        stonks_text.text = stonks.ToString();

    }

    public int getStonks()
    {
        return stonks;
    }

    public void oneHome()
    {
        lives--;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PelletManager : MonoBehaviour
{
    public GameObject Pellet;
    public Transform[] Spawn;
    public TextMeshProUGUI TotalTimeText;
    public TextMeshProUGUI TierText;
    private float TotalTime;
    private float timer = 1.5f;
    private float timertier1 = 10f;
    private float timertier2 = 30f;
    private float timertier3 = 45f;
    private float timertier4 = 55f;
    private float multiplier = 0;
    public int i;
    private bool spawning = true;

    private void Update()
    {
        Debug.Log(TotalTime);
        TotalTime += Time.smoothDeltaTime;
        timer -= Time.deltaTime;
        timertier1 -= Time.deltaTime;
        timertier2 -= Time.deltaTime;
        timertier3 -= Time.deltaTime;
        timertier4 -= Time.deltaTime;
        TotalTimeText.text = TotalTime.ToString("f1");
        if (timertier1 <= 0)
        {
            multiplier = 0.05f;
            TierText.text = "L2";
        }
        if (timertier2 <= 0)
        {
            multiplier = .10f;
            TierText.text = "L3";
        }
        if (timertier3 <= 0)
        {
            multiplier = .25f;
            TierText.text = "L4";
        }
        if (timertier4 <= 0)
        {
            multiplier = .5f;
            TierText.text = "L5";
        }
        if (timer <= 0)
        {
            timer = .85f - multiplier;
            i = Random.Range(0, 4);
            spawning = true;
            if (i == 0 && spawning == true)
            {
                Instantiate(Pellet, Spawn[0].position, Spawn[0].rotation);
                spawning = false;
            }
            if (i == 1 && spawning == true)
            {
                Instantiate(Pellet, Spawn[1].position, Spawn[1].rotation);
                spawning = false;
            }
            if (i == 2 && spawning == true)
            {
                Instantiate(Pellet, Spawn[2].position, Spawn[2].rotation);
                spawning = false;
            }
            if (i == 3 && spawning == true)
            {
                Instantiate(Pellet, Spawn[3].position, Spawn[3].rotation);
                spawning = false;
            }
        }
    }
}
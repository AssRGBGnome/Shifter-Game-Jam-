using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletManager : MonoBehaviour
{
    public GameObject Pellet;
    public Transform[] Spawn;
    public float timer = 1.5f;
    public int i = 0;

    private void Update()
    {
        if(i == 0)
        {
            GameObject i = Pellet;
            Instantiate(Pellet, Spawn[0].transform.position, Quaternion.identity);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject ShifterObj;
    public int dir = 0; //0 = up

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetMouseButtonDown(0))
        {
            dir += 1;
            if (dir > 3) { dir = 0; }
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetMouseButtonDown(1))
        {
            dir -= 1;
            if (dir < 0) { dir = 3; }
        }
        Move();
    }

    public void Move()
    {
        if(dir == 0)
        {
            ShifterObj.transform.position = new Vector3(0, .5f, 0);
            ShifterObj.transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        if(dir == 1)
        {
            ShifterObj.transform.position = new Vector3(.5f, 0, 0);
            ShifterObj.transform.localEulerAngles = new Vector3(0, 0, -90);
        }
        if(dir == 2)
        {
            ShifterObj.transform.position = new Vector3(0, -.5f, 0);
            ShifterObj.transform.localEulerAngles = new Vector3(0, 0, 180);
        }
        if(dir == 3)
        {
            ShifterObj.transform.position = new Vector3(-.5f, 0, 0);
            ShifterObj.transform.localEulerAngles = new Vector3(0, 0, 90);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Die")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

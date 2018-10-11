using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject ShifterObj;
    public Animator PlayerAnim;
    public int dir;
    public int press = 0;
    private bool dpaddis = false;

    private void Start()
    {
        dir = Random.Range(0, 4);
    }

    private void Update()
    {
        Move();
        if (((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) || press == 1)))
        {
            press = 0;
            dir += 1;
            if (dir > 3) { dir = 0; }
        }
        if (((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) || press == -1)))
        {
            press = 0;
            dir -= 1;
            if (dir < 0) { dir = 3; }
        }
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

    void PlayIdleAnim()
    {
        PlayerAnim.SetBool("Starting", false);
        PlayerAnim.SetBool("Idle", true);
    }

    public void LeftButtonPress()
    {
        press = -1;
    }

    public void RightButtonPress()
    {
        press = 1;
    }
}

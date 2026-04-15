using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float movespeed;

    int hp = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Moving();

        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 1);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 1);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - 1, transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + 1, transform.position.y);
        }
        */


    }

    void Moving()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 vt = new Vector3(x, y, transform.position.z);
        transform.position += vt * movespeed * Time.deltaTime;
    }

    void TakeDamage(int damage)
    {
        hp -= damage;
    }
}

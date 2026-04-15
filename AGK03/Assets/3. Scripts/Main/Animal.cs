using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public string named;
    public int hp;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shout(string message)
    {
        Debug.Log(message);
    }

    public virtual void Move()
    {
        Debug.Log("겍");
    }

    public abstract void Eat(); // abstruct 함수는 부모가 선언하고 자식이 override를 이용해 정의.
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalC : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        base.Move(); // base´Â ºÎ¸ð
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Eat()
    {
        Debug.Log("³È");
    }

    public override void Move()
    {
        Debug.Log("°Æ");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Enemy : Charactor
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Set(string name)
    {
        if(name == "슬라임")
        {
            named = "슬라임";
            hp = 30;
            attackDamage = 5;
        }
        else if(name == "고블린")
        {
            named = "고블린";
            hp = 50;
            attackDamage = 8;
        }
    }
}

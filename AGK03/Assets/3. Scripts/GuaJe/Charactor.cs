using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactor : MonoBehaviour
{
    public string named;
    public int hp;
    public int attackDamage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void TakeDamage(int damage)
    { 

    }

    public virtual void Attack(Charactor target)
    {

    }

    public virtual void Die()
    {

    }
}

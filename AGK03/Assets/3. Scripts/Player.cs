using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int hp = 100;
    public int maxhp = 100;

    void Start()
    {
        Print("Hello W");
        Debug.Log("현재 체력: " + hp);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) 
        {
            TakeDamage(10);
        }
        if(Input.GetKeyDown(KeyCode.H) && hp < maxhp)
        {
            Heal(5);
        }
    }

    void TakeDamage(int damage) 
    {
        hp -= damage;
        Debug.Log("피해를 입었습니다. 남은 체력: " + hp);

        if(hp <= 0)
        {
            Debug.Log("사망하였습니다.");
            gameObject.SetActive(false);
        }
    }

    void Heal(int heal)
    {
        hp += heal;
        Debug.Log("체력이 회복되었습니다. 남은 체력: " + hp);
    }

    void Print(string message)
    {
        Debug.Log(message);
    }

    int Math(int a, int b)
    {
        int i = 0;

        i = a + b;

        i *= a;

        i -= b;

        return i;
    }
}

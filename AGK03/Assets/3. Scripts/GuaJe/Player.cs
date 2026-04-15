using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Charactor
{
    public Dictionary<string, int> ib = new Dictionary<string, int>();

    void Start()
    {
        hp = 100;
        attackDamage = 10;

        ib.Add("포션", 10);
    }

    public override void Attack(Charactor target)
    {
        Debug.Log($"{target.named}에게 {attackDamage}만큼의 피해를 주었다! (대상 남은 체력: {target.hp -= attackDamage})");
    }

    public override void Die()
    {
        Debug.Log("죽었다...");
    }

    public override void TakeDamage(int damage)
    {
        Debug.Log($"데미지를 {attackDamage}만큼 입었다! (남은 체력: {hp})");

        if(hp <= 0)
        {
            Die();
        }
    }

    public void UsePotion()
    {
        if (ib["포션"] > 0)
        {
            ib["포션"]--;
            hp += 20;
            Debug.Log($"체력이 20 회복되었다. (남은 체력: {hp}), (남은 포션: {ib["포션"]})");
        }
        else
        {
            Debug.Log("포션이 없다!");
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public Charactor charactor;
    public Player player;
    public List<Enemy> enemyList = new List<Enemy>();

    public Slime slime;
    public Goblin goblin;

    // Start is called before the first frame update
    void Start()
    {
        enemyList.Add(slime);
        enemyList.Add(goblin);

        Debug.Log("전투 시작!!!");

        charactor.Attack(enemyList[0]);
        player.UsePotion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

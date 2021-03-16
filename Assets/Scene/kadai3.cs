using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;


    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");

        this.hp -= damage;
    }

    public void Magic()
    {

        if (mp >= 5)
        {
            int rest = mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + rest + "。");
        }

        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }



}



public class kadai3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);

        for (int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

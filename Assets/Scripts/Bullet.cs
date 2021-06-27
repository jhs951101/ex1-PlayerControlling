using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    int attackPower;
    int playerID;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BorderBullet")
        {
            Destroy(gameObject);
        }
    }

    public void Ready(int attackPower, int playerID)
    {
        this.attackPower = attackPower;
        this.playerID = playerID;
    }

    public int GetAttackPower()
    {
        return attackPower;
    }

    public int GetPlayerID()
    {
        return playerID;
    }
}

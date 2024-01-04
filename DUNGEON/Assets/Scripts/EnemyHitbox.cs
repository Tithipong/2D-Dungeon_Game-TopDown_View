using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : Collidable
{
    //Damage
    public int damage = 1 ;
    public float pushForce = 5;

    protected override void OnCollide(Collider2D coll)
    {
        if(coll.tag == "Fighter" && coll.name == "Player")
        {
            //Create as new damage object, then we'll send it to thefighter we've hit
            Damage dmg = new Damage
            {
                damageAmount = damage,
                origin = transform.position,
                pushForce = pushForce
            };

            coll.SendMessage("ReciveDamage", dmg);
        }
    }
}

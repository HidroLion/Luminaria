using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerirEnemigo : MonoBehaviour
{
    public float damage;

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Enemigo"))
        {
            collider.GetComponent<HP_Enemigo>().Herir(damage);
        }
    }
}

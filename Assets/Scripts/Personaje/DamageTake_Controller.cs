using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTake_Controller : MonoBehaviour
{
    public float damageCC, damageCC_Max;
    public float damage;

    Stats_Manager stats;

    void Start()
    {
        stats = GetComponent<Stats_Manager>();
    }

    // Update is called once per frame
    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Letal") && damageCC >= damageCC_Max)
        {
            Herir(damage);
            damageCC = 0;
        }
        else if(collider.gameObject.CompareTag("Letal") && damageCC < damageCC_Max)
        {
            damageCC += Time.deltaTime;
        }
    }

    void Herir(float Herida)
    {
        stats.MostrarSalud(Herida);
    }
}

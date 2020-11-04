using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herir : MonoBehaviour
{
    public GameObject player;
    public Stats_Manager Stats;

    public float damageCC, damageCC_Max, Damage;
    public bool Contacto;

    void Start()
    {
        Contacto = false;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
            Contacto = true;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
            Contacto = false;
    }

    void Update()
    {
        if(damageCC < damageCC_Max && Contacto)
        {
            damageCC += Time.deltaTime;
        }
        if (damageCC >= damageCC_Max && Contacto)
        {
            HerirJugador(Damage);
            damageCC = 0;
        }
    }

    public void HerirJugador(float damage)
    {
        player.GetComponent<Stats_Manager>().MostrarSalud(damage * -1);
    }
}

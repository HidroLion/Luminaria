using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : PowerUps_Base
{
    public GameObject Cono;
    public Transform ConoPos;
    GameObject SubCono;
    Stats_Manager Stats;

    void Start()
    {
        Stats = Jugador.GetComponent<Stats_Manager>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && CC <= 0 && Stats.Mana > 0)
        {
            SubCono = Instantiate(Cono, ConoPos);
            CC = CC_Max;
            Persistencia = Persistencia_Max;

            Stats.MostrarMana(Costo);
        }

        if(CC >= 0)
        {
            CC -= Time.deltaTime;
        }

        if(Persistencia <= 0)
        {
            Destroy(SubCono);
        }
        else if(Persistencia > 0)
        {
            Persistencia -= Time.deltaTime;
        }
    }
}

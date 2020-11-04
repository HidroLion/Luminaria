using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps_Base : MonoBehaviour
{
    // Start is called before the first frame update
    public float Costo;
    public float CC, CC_Max, Persistencia, Persistencia_Max;
    public GameObject Jugador;

    void Start()
    {
        CC = 0;
        Persistencia = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death_Controller : MonoBehaviour
{
    public Transform checkpoint;
    public GameObject player;
    public Text conteoMuertes;
    public float SaludMax;

    public int Muertes;
    public Stats_Manager GetPlayer;

    void Start()
    {
        GetPlayer = GetComponent<Stats_Manager>();
        SaludMax = GetPlayer.Salud;
    }

    public void Morir()
    {
        player.transform.position = checkpoint.position;
        Muertes++;
        conteoMuertes.text = Muertes.ToString();

        GetPlayer.MostrarSalud(SaludMax);
    }

}

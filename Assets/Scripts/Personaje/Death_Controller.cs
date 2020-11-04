using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death_Controller : MonoBehaviour
{
    public Transform checkpoint;
    public GameObject player;
    public Text conteoMuertes;

    public int Muertes;

    public void Morir()
    {
        player.transform.position = checkpoint.position;
        Muertes++;
        conteoMuertes.text = Muertes.ToString();
    }

}

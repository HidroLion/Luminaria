using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User_Controller : MonoBehaviour
{
    private static int nivel;
    private static int exp;

    public int Nivel { get => nivel; set => nivel = value; }
    public int Exp { get => exp; set => exp = value; }

    // Start is called before the first frame update
    void Awake()
    {       
        if (Exp >= Nivel * 100)
        {
            Nivel = Nivel + 1;
            Exp = 0;
        }

        if(Exp == 0 && Nivel == 0)
        {
            Nivel = 1;
        }

    }
}

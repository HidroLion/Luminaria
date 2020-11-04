﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats_Manager : MonoBehaviour
{
    public float Salud;
    public float Exp;
    public float Mana;

    public Slider[] Sliders;

    void Start()
    {
        MostrarSalud(0);
        MostrarMana(0);
        MostrarExp(0);        
    }

    public void MostrarSalud(float deltaSalud)
    {
        Salud = Salud + deltaSalud;
        Sliders[0].value = Salud;
    }

    public void MostrarMana(float deltaMana)
    {
        Mana = Mana + deltaMana;
        Sliders[1].value = Mana;
    }

    public void MostrarExp(float deltaExp)
    {
        Exp = Exp + deltaExp;
        Sliders[2].value = Exp;
    }
}

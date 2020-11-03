using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exp_Update : MonoBehaviour
{
    public GameObject User;
    public Text Level_text;
    public User_Controller controller;

    public int Level;
    public int Exp;
    public int MaxExp;
    public Slider Slider;

    void Start()
    {
        controller = User.GetComponent<User_Controller>();
        Slider = gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        Level = controller.Nivel;
        Exp = controller.Exp;

        Slider.maxValue = Level * 100;
        Slider.value = Exp;

        Level_text.text = Level.ToString();
    }
}

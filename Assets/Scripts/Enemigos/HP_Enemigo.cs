using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Enemigo : MonoBehaviour
{
    public float HP;

    // Start is called before the first frame update
    void Update()
    {
        if(HP <= 0)
        {
            Destroy(gameObject, 2);
        }
    }

    // Update is called once per frame
    public void Herir(float Herida)
    {
        HP = HP + (Herida * -1);
    }
}

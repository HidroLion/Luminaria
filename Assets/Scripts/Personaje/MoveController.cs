using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    Rigidbody2D RB;
    public float velocidad;
    public float fuerzaSalto;
    Vector2 velocity;

    Transform SkinTransform;
    public bool contactoSalto;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        velocity = new Vector2();

        SkinTransform = GetComponentInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            Mover(Input.GetAxis("Horizontal"));
        }
        if (Input.GetButton("Jump"))
        {
            Salto(contactoSalto);
            contactoSalto = false;
        }
    }

    void Mover(float input)
    {
        transform.Translate(velocity * Time.deltaTime);
        velocity.x = velocidad * input;

        if (input > 0)
            SkinTransform.localScale = new Vector3(1, 1, 1);
        else if (input < 0)
            SkinTransform.localScale = new Vector3(-1, 1, 1);
    }

    void Salto(bool contacto)
    {
        if(contacto)
        {
            RB.AddForce(fuerzaSalto * Vector2.up);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Terreno"))
            contactoSalto = true;
    }
}

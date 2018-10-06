using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJ1 : MonoBehaviour {

    public Transform PersonajeM1;
    public float Velocidad1;
    public float VelocidadRotacion1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Movimiento direccion flechas
        if (Input.GetKey(KeyCode.UpArrow))
            PersonajeM1.Translate(Velocidad1 * Time.deltaTime * Vector3.forward);
        if (Input.GetKey(KeyCode.DownArrow))
            PersonajeM1.Translate(Velocidad1 * Time.deltaTime * Vector3.back);
        //if(Input.GetKey(KeyCode.RightArrow))
        //	PersonajeM.Translate(Velocidad * Time.deltaTime * Vector3.right);
        //if (Input.GetKey(KeyCode.LeftArrow))
        //	PersonajeM.Translate(Velocidad * Time.deltaTime * Vector3.left);

        //Rotacion
        if (Input.GetKey(KeyCode.LeftArrow))
            PersonajeM1.Rotate(Vector3.down * VelocidadRotacion1);
        if (Input.GetKey(KeyCode.RightArrow))
            PersonajeM1.Rotate(Vector3.up * VelocidadRotacion1);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJ2 : MonoBehaviour {

    public Transform PersonajeM2;
    public float Velocidad2;
    public float VelocidadRotacion2;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

        //Movimiento direccion flechas
        if (Input.GetKey(KeyCode.W))
            PersonajeM2.Translate(Velocidad2 * Time.deltaTime * Vector3.forward);
        if (Input.GetKey(KeyCode.S))
            PersonajeM2.Translate(Velocidad2 * Time.deltaTime * Vector3.back);
        //if(Input.GetKey(KeyCode.RightArrow))
        //	PersonajeM.Translate(Velocidad * Time.deltaTime * Vector3.right);
        //if (Input.GetKey(KeyCode.LeftArrow))
        //	PersonajeM.Translate(Velocidad * Time.deltaTime * Vector3.left);

        //Rotacion
        if (Input.GetKey(KeyCode.A))
            PersonajeM2.Rotate(Vector3.down * VelocidadRotacion2);
        if (Input.GetKey(KeyCode.D))
            PersonajeM2.Rotate(Vector3.up * VelocidadRotacion2);

    }
}
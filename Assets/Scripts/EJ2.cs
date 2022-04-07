/*Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
 Comunicar si la suma de los mismos supera o no el monto de dinero disponible.
 Luego indicar cuánto dinero sobra o falta.*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ2 : MonoBehaviour
{
    public float precio1;
    public float precio2;
    public float precio3;
    public float presupuesto;
    float dinerosobrante;
    float dinerofaltante;
    void Start()
    {
        if ((precio1 + precio2 + precio3) > presupuesto)
        {
            dinerofaltante = (precio1 + precio2 + precio3) - presupuesto;
            Debug.Log("La suma de los productos supera el presupuesto. El dinero faltante es " + dinerofaltante);
        }
        else if ((precio1 + precio2 + precio3) < presupuesto)
        {
            dinerosobrante = presupuesto - (precio1 + precio2 + precio3);
            Debug.Log("La suma de los productos no supera el presupuesto. El dinero sobrante es " + dinerosobrante);
        }
        else if ((precio1 + precio2 + precio3) == presupuesto)
        {
            Debug.Log("El precio y el presupuesto son iguales");
        }
    }

    void Update()
    {
        
    }
}

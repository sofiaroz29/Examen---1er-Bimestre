using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//El supermercado TicMarket nos pide que realicemos un programa para que sus clientes puedan calcular el costo de algunos productos que se encuentran en promoción

//Se pide que se ingrese por inspector:
//. Los nombre de tres productos
//.Los precios de cada producto
//.La cantidad de unidades deseada de cada producto

//El programa debe cumplir los siguientes requerimientos:

//Debe calcularse un descuento del 20% sobre la compra de un producto si la cantidad de unidades del mismo supera las 3. 

//El programa debe devolver un mensaje de error descriptivo si el precio del producto o la cantidad de unidades son menores a 1.

//El programa debe devolver el total de la compra de los tres productos mostrando un mensaje que incluya el monto total sin descuento, el monto de los descuentos aplicados y el total con los descuentos aplicados.


public class TICMarket : MonoBehaviour
{

    public string nombre1;
    public string nombre2;
    public string nombre3;

    public float precio1;
    public float precio2;
    public float precio3;

    public int cantUnidades1;
    public int cantUnidades2;
    public int cantUnidades3;

    float precioDescuento1;
    float precioDescuento2;
    float precioDescuento3;


    void Start()
    {
       if (cantUnidades1 < 3)
       {
            precioDescuento1 = (precio1 / 5);
       }

        else if (cantUnidades2 < 3)
        {
            precioDescuento2 = (precio2 / 5);
        }

        else if (cantUnidades3 < 3)
        {
            precioDescuento3 = (precio3 / 5);
        }

       else
       {
            precioDescuento1 = 0;
            precioDescuento2 = 0;
            precioDescuento3 = 0;
       }

        if (precio1 < 1 || precio2 < 1 || precio3 < 1)
        {
            Debug.Log("El precio de un producto no puede ser menor a 1");
        }

        else if (cantUnidades1<1 || cantUnidades2<1 || cantUnidades3 < 1)
        {
            Debug.Log("La cantidad de un producto debe ser de 1 o más");
        }

       

        else
        {
            Debug.Log("Monto total sin descuento: " + (precio1 + precio2 + precio3) + "\n\r" + "Monto de los descuentos aplicados: " + (precioDescuento1 + precioDescuento2 + precioDescuento3) + "\n\r" + "Monto total con los descuentos aplicados: " + ((precio1-precioDescuento1) + (precio2 - precioDescuento2) + (precio3 - precioDescuento3)));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

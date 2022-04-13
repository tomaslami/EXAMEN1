using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    public int cantproductos;
    public int cantuni1;
    public string produto1;
    public int preciosproducto1;
    public int cantuni2;
    public string producto2;
    public int preciosproducto2;
    public int cantuni3;
    public string producto3;
    public int preciosproducto3;
    
    // Start is called before the first frame update
    void Start()
    {
        int pre1 = cantuni1 * preciosproducto1;
        int pre2 = cantuni2 * preciosproducto2;
        int pre3 = cantuni3 * preciosproducto3;
        int preciotot = (pre1 + pre2 + pre3);
        int descuento = (preciotot * 20) / 100;
        int preciodes = preciotot - descuento;


        if (cantproductos >= 3)
        {
            Debug.Log("El total de su compra sin descuento es " + preciotot + " El precio total con descuento es " + preciodes);
        }
        else if (cantproductos < 1)
            Debug.Log("ERROR");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

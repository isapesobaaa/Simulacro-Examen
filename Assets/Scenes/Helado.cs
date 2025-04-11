using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helado : MonoBehaviour
{
    // 1. Declaracion de variables
    public string codigoGusto;
    public int cantGramosHelado;

    float precioPorGramo;
    float precioFinalHelado;
    // Start is called before the first frame update
    void Start()
    {
        precioPorGramo = 1250 / 1000f;
     // 2. Validacion de datos

        if(cantGramosHelado < 250 || cantGramosHelado >3000 )
        {
            Debug.Log("Cantidad de helado no valido");
            return;
        }

        if (codigoGusto !="CHO" && codigoGusto !="DDL" && codigoGusto !="FRU") 
        {
            Debug.Log("El codigo no es valido");
            return;
        }
        //3. Procesamiento de datos

        precioFinalHelado = cantGramosHelado * precioPorGramo;
        if (codigoGusto == "FRU")
        {
            precioFinalHelado = precioFinalHelado * 0.9f;
        }

           //4. Salida de datos
         Debug.Log("Precio a pagar: $" + precioFinalHelado);

        // Update is called once per frame
    void Update()
    {
        
    }
}

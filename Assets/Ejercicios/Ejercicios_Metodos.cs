using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios_Metodos : MonoBehaviour
{
    int numeroA;
    int numeroB;

    int resultado;

    void Start()
    {
        numeroA = Random.Range(1, 50 + 1); // numero de 1 a 10
        numeroB = Random.Range(1, 50 + 1); // otro numero de 1 a 10

        MultiplicarDosNumeros(numeroA, numeroB);

        Debug.Log($"resultado = {resultado}");



        numeroA = Random.Range(1, 50 + 1); // numero de 1 a 10
        numeroA = Random.Range(1, 50 + 1); // otro numero de 1 a 10

        MultiplicarDosNumeros(numeroA, numeroA);

        Debug.Log($"resultado = {resultado}");
    }

    void MultiplicarDosNumeros(int primerNumero, int segundoNumero)
    {
        resultado = primerNumero * segundoNumero;

        if (resultado > 1000)
        {
            resultado = 1000;
        }
    }
}
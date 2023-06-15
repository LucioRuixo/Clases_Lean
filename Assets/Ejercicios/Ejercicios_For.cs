using UnityEngine;

public class Ejercicios_For : MonoBehaviour
{
    void Start()
    {
        int patadasExitosas = 0;

        for (int i = 0; i < 10; i++)
        {
            // a. cuantos ataques exitosos hubo
            int n = Random.Range(1, 6); // 1 = bloqueo, 2, 3, 4, 5

            if (n != 1)
            {
                patadasExitosas += 1;
            }

            // b. indicar el daño final

            // c. en caso de que una patada sea bloqueada indicar "ataque bloqueado"
            if (n != 1)
            {
                Debug.Log($"EXITO!");
            }
            else
            {
                Debug.Log($"BLOQUEO");
            }

            // d. imprimir el daño realizado
        }

        Debug.Log($"");
        Debug.Log($"PATADAS EXITOSAS = {patadasExitosas}");
    }
}
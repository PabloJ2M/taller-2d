using System.Collections;
using UnityEngine;

public class Ejemplo : MonoBehaviour
{
    public int numero;

    IEnumerator Start()
    {
        while (true)
        {
            yield return null;
            Debug.Log("A");
        }
    }
}

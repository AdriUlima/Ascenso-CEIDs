using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float velGlobal = 1f;
    [SerializeField] private GameObject bicho;

    void Start()
    {
        StartCoroutine(GenerarBichos());
        StartCoroutine(AumentarVelGlobal());
    }

    private IEnumerator GenerarBichos()
    {
        while (true)
        {
            Instantiate(bicho, new Vector3(Random.Range(-2f, 2f), 6f, 0f), Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
    private IEnumerator AumentarVelGlobal()
    {
        while (true)
        {
            velGlobal += 0.5f;
            yield return new WaitForSeconds(4f);
        }
    }
}
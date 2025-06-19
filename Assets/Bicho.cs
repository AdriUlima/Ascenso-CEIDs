using UnityEngine;

public class Bicho : MonoBehaviour
{
    [SerializeField] private float vel;

    void Update()
    {
        transform.Translate(Time.deltaTime * vel * GameManager.velGlobal * Vector2.down);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
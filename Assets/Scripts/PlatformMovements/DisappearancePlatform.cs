using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearancePlatform : MonoBehaviour
{
    [SerializeField] private GameObject platform;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Invoke("Disappearance", 1.0f);
        }
    }

    private void Disappearance()
    {
        platform.SetActive(false);

    }
}

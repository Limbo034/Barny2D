using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform teleportTarget;

    [SerializeField] private Animator animator;

    [SerializeField] private GameObject thePlayer;
    [SerializeField] private GameObject theMarker;

    private bool isPlayerNear = false;
    private bool examination = false;

    private void Update()
    {
        if (Input.GetKey("s") && isPlayerNear && !examination)
        {
            EnterTeleportPlayer();
            examination = true;
            Debug.Log("s 1");
        }
        else if (Input.GetKey("w") && isPlayerNear && examination)
        {
            ExitTeleportPlayer();
            examination = false;
            Debug.Log("w 1");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetBool("enterteleport", true);

            isPlayerNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetBool("enterteleport", false);

            theMarker.transform.position = new Vector2(12f, 12f);

            isPlayerNear = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        theMarker.transform.position = teleportTarget.transform.position;
    }
    private void EnterTeleportPlayer()
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        thePlayer.SetActive(false);

        isPlayerNear = true; 

        animator.SetBool("teleport", true);
        animator.SetBool("enterteleport", true);
    }
    private void ExitTeleportPlayer()
    {
        thePlayer.SetActive(true);

        animator.SetBool("teleport", false);
    }
}

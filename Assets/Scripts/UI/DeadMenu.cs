using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
    [SerializeField] private GameObject deadMenu;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        deadMenu.SetActive(true);
    }
    public void Restart(int restart)
    {
        SceneManager.LoadScene(restart);
    }

}

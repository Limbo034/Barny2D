using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTest : MonoBehaviour
{
    [SerializeField] private GameObject winMenu;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        winMenu.SetActive(true);
    }
    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);

    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasButtons : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadTelegram()
    {
        Application.OpenURL("https://t.me/ARQ81");
    }
}

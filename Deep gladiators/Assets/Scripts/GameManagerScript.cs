using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameplayScene");
    }

    public void ExitGame()
    {
        // Завершает работу приложения
        Application.Quit();

        // Для проверки в редакторе Unity
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
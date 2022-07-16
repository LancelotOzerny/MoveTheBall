using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuMaster : MonoBehaviour
{
    /// <summary>
    /// Метод, который позволяет закрыть приложение
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }

    /// <summary>
    /// Метод который позволяет открыть index-ную сцену
    /// </summary>
    /// <param name="index">индекс открываемой сцены</param>
    public void OpenScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}

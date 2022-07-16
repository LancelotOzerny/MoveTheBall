using UnityEngine;
using UnityEngine.SceneManagement;

public class ConfirmScript : MonoBehaviour
{
    [SerializeField] private GameObject confirmScreen;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SetConfirmActive();
        }
    }

    /// <summary>
    /// Метод который позволяет открыть index-ную сцену
    /// </summary>
    /// <param name="index">индекс открываемой сцены</param>
    public void OpenScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    /// <summary>
    /// Метод, который позволяет поменять активность у объекта
    /// </summary>
    /// <param name="obj">объект, активность которого мы меняем</param>
    public void SetConfirmActive()
    {
        confirmScreen.SetActive(!confirmScreen.activeSelf);
    }
}

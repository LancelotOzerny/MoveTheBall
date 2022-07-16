using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuMaster : MonoBehaviour
{
    /// <summary>
    /// �����, ������� ��������� ������� ����������
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }

    /// <summary>
    /// ����� ������� ��������� ������� index-��� �����
    /// </summary>
    /// <param name="index">������ ����������� �����</param>
    public void OpenScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}

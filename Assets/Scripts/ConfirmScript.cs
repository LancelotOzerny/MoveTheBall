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
    /// ����� ������� ��������� ������� index-��� �����
    /// </summary>
    /// <param name="index">������ ����������� �����</param>
    public void OpenScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    /// <summary>
    /// �����, ������� ��������� �������� ���������� � �������
    /// </summary>
    /// <param name="obj">������, ���������� �������� �� ������</param>
    public void SetConfirmActive()
    {
        confirmScreen.SetActive(!confirmScreen.activeSelf);
    }
}

using UnityEngine;

public class GameArea : MonoBehaviour
{
    [SerializeField] private GameObject[] points;
    [SerializeField] private bool[] placed;
    [SerializeField] private int freePointindex;
    [SerializeField] private GameObject winpanel;

    public void ChangeFreeIndex(int index)
    {
        if (index < 0 | index >= points.Length)
        {
            return;
        }

        freePointindex = index;
        CheckWinCondition();
    }

    public GameObject GetFreePoint()
    {
        return points[freePointindex];
    }

    public int GetFreeIndex()
    {
        return freePointindex;
    }

    public void CheckWinCondition()
    {
        GameObject[] redShapes = GameObject.FindGameObjectsWithTag("RedShape");
        GameObject[] blueShapes = GameObject.FindGameObjectsWithTag("BlueShape");

        int red1 = redShapes[0].GetComponent<ShapeScript>().pointIndex;
        int red2 = redShapes[1].GetComponent<ShapeScript>().pointIndex;

        int blue1 = blueShapes[0].GetComponent<ShapeScript>().pointIndex;
        int blue2 = blueShapes[1].GetComponent<ShapeScript>().pointIndex;


        if (
            ((red1 == 0 | red1 == 3) & (red2 == 0 | red2 == 3) & (blue1 == 2 | blue1 == 4) & (blue2 == 2 | blue2 == 4)) |
            ((red1 == 1 | red1 == 4) & (red2 == 1 | red2 == 4) & (blue1 == 2 | blue1 == 3) & (blue2 == 2 | blue2 == 3))
            )
        {
            winpanel.SetActive(true);
            PlayerPrefs.SetString("WinPlayer", "синий");
            ShapeScript.stepColor = ShapeScript.shapeColor.Blue;
            return;
        }

        if (
            ((blue1 == 0 | blue1 == 3) & (blue2 == 0 | blue2 == 3) & (red1 == 2 | red1 == 4) & (red2 == 2 | red2 == 4)) |
            ((blue1 == 1 | blue1 == 4) & (blue2 == 1 | blue2 == 4) & (red1 == 2 | red1 == 3) & (red2 == 2 | red2 == 3))
           )
        {
            winpanel.SetActive(true);
            PlayerPrefs.SetString("WinPlayer", "красный");
            ShapeScript.stepColor = ShapeScript.shapeColor.Blue;
            return;
        }
    }
}

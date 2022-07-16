using UnityEngine;

public class ShapeScript : MonoBehaviour
{
    public enum shapeColor {Red, Blue};
    public shapeColor color;
    public GameArea script;
    public static shapeColor stepColor = shapeColor.Blue;
    public int pointIndex;

    public bool Step()
    {
        if (stepColor == color)
        {
            int pIndex = script.GetFreeIndex();

            if (
                (!(pointIndex == 0 & (pIndex == 2 | pIndex == 3))) &
                (!(pointIndex == 1 & (pIndex == 2 | pIndex == 4))) &
                (!(pointIndex == 2 & (pIndex == 0 | pIndex == 1 | pIndex == 3 | pIndex == 4))) &
                (!(pointIndex == 3 & (pIndex == 0 | pIndex == 2 | pIndex == 4))) &
                (!(pointIndex == 4 & (pIndex == 1 | pIndex == 2 | pIndex == 3)))
                )
            {
                return false;
            }


            Vector3 pos = script.GetFreePoint().transform.position;
            transform.position = new Vector3(pos.x, pos.y, transform.position.z);
            stepColor = stepColor == shapeColor.Red ? shapeColor.Blue : shapeColor.Red;

            int tmp = pointIndex;
            pointIndex = pIndex;
            script.ChangeFreeIndex(tmp);
        }

        return true;
    }

    private void OnMouseDown()
    {
        Step();
    }
}

/*****************************************************************************
// File Name :         ShapeDrawer.cs
// Author :            Kyle Grenier
// Creation Date :     04/17/2021
//
// Brief Description : Draws shapes to the screen.
*****************************************************************************/
using UnityEngine;

public class ShapeDrawer : MonoBehaviour
{
    public enum ShapeType { CIRCLE, SQUARE, CAPSULE };

    [Tooltip("0 = Circle, 1 = Square, 2 = Capsule")]
    [SerializeField] private IShape[] shapes;

    public void DrawShape(ShapeType shapeType, Vector3 pos)
    {
        switch(shapeType)
        {
            case ShapeType.CIRCLE:
                DrawCircle(pos);
                break;
            case ShapeType.SQUARE:
                DrawSquare(pos);
                break;
            case ShapeType.CAPSULE:
                DrawCapsule(pos);
                break;
        }
    }

    public void DrawCircle(Vector3 pos)
    {
        IShape circle = Instantiate(shapes[0], pos, Quaternion.identity);
        circle.Draw();
    }

    public void DrawSquare(Vector3 pos)
    {
        IShape square = Instantiate(shapes[1], pos, Quaternion.identity);
        square.Draw();
    }

    public void DrawCapsule(Vector3 pos)
    {
        IShape capsule = Instantiate(shapes[2], pos, Quaternion.identity);
        capsule.Draw();
    }
}
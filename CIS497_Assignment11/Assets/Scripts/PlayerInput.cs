/*****************************************************************************
// File Name :         PlayerInput.cs
// Author :            Kyle Grenier
// Creation Date :     04/17/2021
//
// Brief Description : A class to handle gathering input from the player and performing the appropriate action.
*****************************************************************************/
using UnityEngine;
using TMPro;

[RequireComponent(typeof(ShapeDrawer))]
public class PlayerInput : MonoBehaviour
{
    private ShapeDrawer shapeDrawer;
    private ShapeDrawer.ShapeType shapeType;

    [SerializeField] private TextMeshProUGUI currentShapeText;

    private void Awake()
    {
        shapeDrawer = GetComponent<ShapeDrawer>();
        shapeType = ShapeDrawer.ShapeType.CIRCLE;
        currentShapeText.text = "Press 1-3 to change shape.\n<i>Current Shape: " + shapeType + "</i>";
    }

    public void Update()
    {
        GetShapeTypeInput();

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0f;

            shapeDrawer.DrawShape(shapeType, pos);
        }
    }

    void GetShapeTypeInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            shapeType = ShapeDrawer.ShapeType.CIRCLE;
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            shapeType = ShapeDrawer.ShapeType.SQUARE;
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            shapeType = ShapeDrawer.ShapeType.CAPSULE;
        
        if (Input.anyKeyDown)
            currentShapeText.text = "Press 1-3 to change shape.\n<i>Current Shape: " + shapeType + "</i>";
    }
}
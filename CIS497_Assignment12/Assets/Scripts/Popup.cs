/*****************************************************************************
// File Name :         Popup.cs
// Author :            Kyle Grenier
// Creation Date :     05/02/2021
//
// Brief Description : Popup text behaviour. Displays the character's stat change.
*****************************************************************************/
using UnityEngine;
using TMPro;

public class Popup : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txt;
    [SerializeField] private float speed;

    private void Start()
    {
        Vector2 minPos = Camera.main.ViewportToWorldPoint(Vector2.zero);

        Vector2 maxPos = Camera.main.ViewportToWorldPoint(new Vector2(1f, 0.5f));

        Vector2 randPos = new Vector2
            (
            Random.Range(minPos.x, maxPos.x), 
            Random.Range(minPos.y, maxPos.y)
            );

        transform.position = randPos;

        Destroy(gameObject, 1.5f);
    }

    private void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

    public void Display(string text)
    {
        txt.text = text;
    }
}

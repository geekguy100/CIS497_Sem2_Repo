/*****************************************************************************
// File Name :         FlyingShape.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class FlyingShape : MonoBehaviour, IPooledObject
{
    private IShapeBehaviour shapeBehaviour;
    private Rigidbody2D rb;

    [SerializeField] private float minForce;
    [SerializeField] private float maxForce;

    [SerializeField] private string poolTag;

    [Header("DEBUG")]
    [Tooltip("Anything below 0 will ignore this field.")]
    [SerializeField] private int forcedBehaviour;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        AddRandomBehaviour();
        shapeBehaviour.SetPoolTag(poolTag);
    }

    private void AddRandomBehaviour()
    {
        int num;
        if (forcedBehaviour >= 0)
            num = forcedBehaviour;
        else
            num = Random.Range(0, 3);


        switch(num)
        {
            case 0:
                shapeBehaviour = gameObject.AddComponent<BombBehaviour>();
                break;
            case 1:
                shapeBehaviour = gameObject.AddComponent<LuckyBehaviour>();
                break;
            case 2:
                shapeBehaviour = gameObject.AddComponent<RainbowBehaviour>();
                break;
            case 3:
                break;
        }
    }

    public void OnSpawn()
    {
        rb.velocity = Vector2.zero;
        float force = Random.Range(minForce, maxForce);
        rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }
}

/*****************************************************************************
// File Name :         OOBTrigger.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class OOBTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IPooledObject pooledObj = collision.GetComponent<IPooledObject>();
        if (pooledObj != null)
        {
            if (collision.GetComponent<BombBehaviour>() == null)
                --ScoreManager.Instance.Score;

            ObjectPooler.Instance.ReturnObjectToPool(pooledObj.GetPoolTag(), collision.gameObject);
        }
    }
}
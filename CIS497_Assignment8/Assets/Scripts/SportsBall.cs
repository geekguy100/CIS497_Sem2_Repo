/*****************************************************************************
// File Name :         SportsBall.cs
// Author :            Kyle Grenier
// Creation Date :     03/27/2021
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public struct KickData
{
    public KickData(string ballName, float kickForce)
    {
        this.ballName = ballName;
        this.kickForce = kickForce;
    }

    private string ballName;
    private float kickForce;
}

[RequireComponent(typeof(Rigidbody))]
public abstract class SportsBall : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Kick()
    {
        KickData data = new KickData(GetName(), GetKickForce());
        EventManager.KickOff(data);
        Launch();
    }

    protected virtual void Launch()
    {
        print("LAUNCH " + gameObject.name);
        rb.AddForce(transform.forward * GetKickForce(), ForceMode.Impulse);
    }

    protected abstract string GetName();
    protected abstract float GetKickForce();
}
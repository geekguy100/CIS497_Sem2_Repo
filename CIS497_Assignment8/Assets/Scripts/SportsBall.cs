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
    public KickData(string ballName, Vector3 kickForce)
    {
        this.ballName = ballName;
        this.kickForce = kickForce;
    }

    private string ballName;
    private Vector3 kickForce;
}

[RequireComponent(typeof(Rigidbody))]
public abstract class SportsBall : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Kick(Vector3 dir)
    {
        KickData data = new KickData(GetName(), GetKickForce() * dir);
        EventManager.KickOff(data);
        Launch(dir);
    }

    protected virtual void Launch(Vector3 dir)
    {
        print("LAUNCH " + gameObject.name);
        rb.AddForce(dir * GetKickForce(), ForceMode.Impulse);
    }

    protected abstract string GetName();
    protected abstract float GetKickForce();
}
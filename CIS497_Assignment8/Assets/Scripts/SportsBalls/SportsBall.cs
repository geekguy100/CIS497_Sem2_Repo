/*****************************************************************************
// File Name :         SportsBall.cs
// Author :            Kyle Grenier
// Creation Date :     03/27/2021
//
// Brief Description : An abstract class that defines a sports ball's behaviour.
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
    public string BallName { get { return ballName; } }

    private Vector3 kickForce;
    public Vector3 KickForce { get { return kickForce; } }
}

[RequireComponent(typeof(Rigidbody))]
public abstract class SportsBall : MonoBehaviour
{
    private Rigidbody rb;
    private bool applicationQuitting = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    #region --- Application Quitting Event ---
    private void OnEnable()
    {
        Application.quitting += () => { applicationQuitting = true; };
    }

    //private void SetApplicationQuitting()
    //{
    //    applicationQuitting = true;
    //}

    #endregion

    public void Kick(Vector3 dir)
    {
        KickData data = new KickData(GetName(), GetKickForce() * dir);
        EventManager.KickOff(data);
        Launch(dir);
    }

    protected virtual void Launch(Vector3 dir)
    {
        rb.AddForce(dir * GetKickForce(), ForceMode.Impulse);
    }

    protected abstract string GetName();
    protected abstract float GetKickForce();

    private void OnDestroy()
    {
        if (!applicationQuitting)
            EventManager.BallDestroyed();
    }
}
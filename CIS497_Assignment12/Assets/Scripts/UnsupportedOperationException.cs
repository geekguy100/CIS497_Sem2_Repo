/*****************************************************************************
// File Name :         UnsupportedOperationException.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using System;

[Serializable]
public class UnsupportedOperationException : Exception
{
    public UnsupportedOperationException() { }
    public UnsupportedOperationException(string message) : base(message) { }
    public UnsupportedOperationException(string message, Exception inner) : base(message, inner) { }
}

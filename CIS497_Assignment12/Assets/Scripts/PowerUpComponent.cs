/*****************************************************************************
// File Name :         PowerUpComponent.cs
// Author :            Kyle Grenier
// Creation Date :     05/02/2021
//
// Brief Description : A component in our composite pattern.
*****************************************************************************/

public abstract class PowerUpComponent
{
    public abstract string GetName();

    public virtual void Add(PowerUpComponent component)
    {
        throw new UnsupportedOperationException();
    }

    public virtual void Remove<T>() where T : PowerUpComponent
    {
        throw new UnsupportedOperationException();
    }

    public virtual void Activate(Character character)
    {
        throw new UnsupportedOperationException();
    }
}
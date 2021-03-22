/*****************************************************************************
// File Name :         Command.cs
// Author :            Kyle Grenier
// Creation Date :     03/21/2021
//
// Brief Description : The interface for a command.
*****************************************************************************/

public interface ICommand
{
    void Execute();
    string GetDescription();
}

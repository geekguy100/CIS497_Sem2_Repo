/*****************************************************************************
// File Name :         CommandHolder.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public static class CommandFactory
{
    private static string[] availableCommands;

    static CommandFactory()
    {
        PopulateCommands();
    }
    
    /// <summary>
    /// Returns a new instance of an ICommand with the given name and arguments. If no such command exists, returns null.
    /// </summary>
    /// <param name="commandName">The name of the command.</param>
    /// <param name="args">The command's arguments.</param>
    /// <returns>A new instance of the ICommand. Null if no command with the given name exists.</returns>
    public static ICommand GetCommand(string commandName, Object[] args)
    {
        foreach(string command in availableCommands)
        {
            // If the command is a valid command.
            if (command == commandName)
            {
                System.Type commandType = System.Type.GetType(command);
                return System.Activator.CreateInstance(commandType, args) as ICommand;
            }
        }

        Debug.LogWarning("CommandFactory: Cannot find command named '" + commandName + "'.");
        return null;
    }

    /// <summary>
    /// Returns the next command in the array of all available commands.
    /// </summary>
    /// <param name="commandIndex">The current command index.</param>
    /// <returns>The next command in the array of all available commands.</returns>
    public static string GetNextCommandName(ref int commandIndex)
    {
        commandIndex += 1;
        if (commandIndex >= availableCommands.Length && availableCommands.Length != 0)
            commandIndex = 0;
        else if (availableCommands.Length == 0)
            return string.Empty;

        return availableCommands[commandIndex];
    }

    /// <summary>
    /// Populates an array with all of the commands available for use.
    /// </summary>
    private static void PopulateCommands()
    {
        Object[] resources = Resources.LoadAll("Commands");
        availableCommands = new string[resources.Length];
   
        for (int i = 0; i < availableCommands.Length; ++i)
        {
            availableCommands[i] = resources[i].name;
        }
    }
}

using System.Collections.Generic;
using UnityEngine;
using CommandFile;
using MoveLeftCommandFile;
using MoveRightCommandFile;
using MoveDownCommandFile;
using MoveUpCommandFile;

namespace InputHandlerFile
{
    public class InputHandler
    {
        private List<Command> commands;

        public List<Command> handleInput()
        {
            commands = new List<Command>();

            if(Input.GetKey("w"))
            {
                commands.Add(new MoveUpCommand());
            }

            if(Input.GetKey("s"))
            {
                commands.Add(new MoveDownCommand());
            }

            if(Input.GetKey("a"))
            {
                commands.Add(new MoveLeftCommand());
            }

            if(Input.GetKey("d"))
            {
                commands.Add(new MoveRightCommand());
            }

            return commands;
        }
    }
}
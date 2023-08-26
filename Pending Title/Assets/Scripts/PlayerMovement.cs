using System.Collections.Generic;
using UnityEngine;
using CommandFile;
using InputHandlerFile;

public class PlayerMovement : MonoBehaviour
{
    private List<Command> commands;
    [SerializeField] private GameObject player;
    private InputHandler inputHandler;
    [SerializeField] private float movementSpeed;

    private void Start()
    {
        inputHandler = new InputHandler();
    }

    private void Update()
    {
        commands = inputHandler.handleInput();
        
        if(commands.Count != 0)
        {
            foreach(Command command in commands)
            {
                command.execute(player);
                player.GetComponent<Rigidbody>().velocity = player.GetComponent<Rigidbody>().velocity.normalized;
                player.GetComponent<Rigidbody>().velocity *= movementSpeed;
            }
        }

        else
        {
            player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
}

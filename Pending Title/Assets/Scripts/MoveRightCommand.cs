using UnityEngine;
using CommandFile;

namespace MoveRightCommandFile
{
    public class MoveRightCommand : Command
    {
        public override void execute(GameObject go)
        {
            go.GetComponent<Rigidbody>().velocity = Camera.main.transform.right;
        }
    }
}
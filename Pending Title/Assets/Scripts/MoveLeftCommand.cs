using UnityEngine;
using CommandFile;

namespace MoveLeftCommandFile
{
    public class MoveLeftCommand : Command
    {
        public override void execute(GameObject go)
        {
            go.GetComponent<Rigidbody>().velocity = Camera.main.transform.right * -1f;
        }
    }
}

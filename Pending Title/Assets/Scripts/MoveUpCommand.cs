using UnityEngine;
using CommandFile;

namespace MoveUpCommandFile
{
    public class MoveUpCommand : Command
    {
        public override void execute(GameObject go)
        {
            Vector3 velocity = Camera.main.transform.forward;
            velocity.y = 0;
            velocity = velocity.normalized;
            go.GetComponent<Rigidbody>().velocity = velocity;
        }
    }
}
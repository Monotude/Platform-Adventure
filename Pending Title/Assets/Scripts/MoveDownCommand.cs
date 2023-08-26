using UnityEngine;
using CommandFile;

namespace MoveDownCommandFile
{
    public class MoveDownCommand : Command
    {
        public override void execute(GameObject go)
        {
            Vector3 velocity = Camera.main.transform.forward * -1f;
            velocity.y = 0;
            velocity = velocity.normalized;
            go.GetComponent<Rigidbody>().velocity = velocity;
        }
    }
}
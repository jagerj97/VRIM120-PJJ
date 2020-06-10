using UnityEngine;

public class floorCollision : MonoBehaviour
{
	 Vector3 originalPos;
	 Quaternion originalRot;
	 
	 void Start()
	{
		originalPos = gameObject.transform.position;
		originalRot = gameObject.transform.rotation;
	}
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Floor")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            transform.position = originalPos;
			transform.rotation = originalRot;
        }
    }
}
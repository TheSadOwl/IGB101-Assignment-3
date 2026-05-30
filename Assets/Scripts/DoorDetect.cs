using UnityEngine;

public class DoorDetect : MonoBehaviour
{
    public Door door;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            PlayerController controller = otherObject.GetComponent<PlayerController>();

            if (controller != null)
            {
                if (door.Opened)
                {
                    controller.InteractionStr = "Press [E] to Close";
                }
                else
                {
                    controller.InteractionStr = "Press [E] to Open";
                }

                if (controller.interacting)
                {
                    door.OpenDoor();
                }
            }
        }
    }

    private void OnTriggerExit(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            PlayerController controller = otherObject.GetComponent<PlayerController>();

            if (controller != null)
            {
                controller.InteractionStr = "";
                
            }
        }
    }
}

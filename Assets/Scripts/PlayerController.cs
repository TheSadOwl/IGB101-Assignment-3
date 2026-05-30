using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool interacting;

    public Animator anim;

    public float rotSpeed = 10;

    [Header("Interaction Cooldown")]
    public float interactionCooldown = 1f;

    private float nextInteractionTime;

    public string InteractionStr;

    void Start()
    {
        InteractionStr = "";
    }

    void Update()
    {
        ForwardMovement();

        Turning();

        Actions();
    }

    private void ForwardMovement()
    {
        if (Input.GetKey("w"))
        {
            anim.SetBool("Walking", true);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("Running", true);
            }
            else
            {
                anim.SetBool("Running", false);
            }
        }
        else if (Input.GetKeyUp("w"))
        {
            anim.SetBool("Walking", false);
            anim.SetBool("Running", false);
        }
    }

    private void Turning()
    {
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, -rotSpeed * 15 * Time.deltaTime, 0, Space.World);
            anim.SetBool("Turn Left", true);
        }
        else if (Input.GetKey("d"))
        {
            transform.Rotate(0, rotSpeed * 15 * Time.deltaTime, 0, Space.World);
            anim.SetBool("Turn Right", true);
        }
        else
        {
            anim.SetBool("Turn Left", false);
            anim.SetBool("Turn Right", false);
        }
    }

    private void Actions()
    {
        if (Input.GetKeyDown(KeyCode.E) && Time.time >= nextInteractionTime)
        {
            interacting = true;

            nextInteractionTime = Time.time + interactionCooldown;

            Debug.Log("Interacted");
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            interacting = false;
        }
    }
}
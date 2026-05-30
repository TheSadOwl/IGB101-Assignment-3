using UnityEngine;

public class Door : MonoBehaviour
{
    Animator DoorAnim;

    public bool Opened;

    [Header("Door Cooldown")]
    public float cooldownTime = 1f;

    private bool canInteract = true;

    public AudioSource OpenSound;

    public AudioSource CloseSound;

    void Start()
    {
        DoorAnim = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        if (!canInteract)
        {
            return;
        }

        canInteract = false;

        Opened = !Opened;

        DoorAnim.SetBool("Open", Opened);

        Invoke(nameof(ResetCooldown), cooldownTime);
    }

    private void ResetCooldown()
    {
        canInteract = true;
    }

    public void OpenDoorSound()
    {
        OpenSound.Play();
    }
    public void CloseDoorSound()
    {
        CloseSound.Play();
    }
}

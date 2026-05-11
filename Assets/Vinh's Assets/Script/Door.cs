using UnityEngine;

public class Door : MonoBehaviour
{
    Animator DoorAnim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DoorAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (DoorAnim.GetBool("Open"))
            {
                DoorAnim.SetBool("Open", false);
            }
            else
            {
                DoorAnim.SetBool("Open", true);
            }
        }
    }
}

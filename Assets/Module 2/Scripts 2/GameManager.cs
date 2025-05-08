using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public BoxController box;
    public Button jumpButton;

    private void Start()
    {
        box.SetJumpForce(7f);

        jumpButton.onClick.AddListener(() => box.Jump());
    }
}

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Player player;
    private Rigidbody rb;

    void Start()
    {
        player = new Player("Hero", 100, 50);

        rb = GetComponent<Rigidbody>();

        player.DisplayInfo();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Jump(rb);
        }
    }
}

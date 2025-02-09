using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public int health;
    public int strength;
    public float jumpForce = 5f; 

    
    public Player(string name, int hp, int str)
    {
        playerName = name;
        health = hp;
        strength = str;
    }

    
    public void DisplayInfo()
    {
        Debug.Log("Player: " + playerName + " | Health: " + health + " | Strength: " + strength);
    }

    
    public void Jump(Rigidbody rb)
    {
        
        if (IsGrounded(rb))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
        }
    }

    private bool IsGrounded(Rigidbody rb)
    {
        return Physics.Raycast(rb.position, Vector3.down, 1.1f); 
    }
}

using UnityEngine;

public class PlayerDamageHandler : MonoBehaviour, IDamageable
{
    public float health = 100f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        Debug.Log($"Player took {amount} damage. Remaining: {health}");
    }
}

using UnityEngine;

public class EnemyDamageHandler : MonoBehaviour, IDamageable
{
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        Debug.Log($"Enemy took {amount} damage. Remaining: {health}");
    }
}

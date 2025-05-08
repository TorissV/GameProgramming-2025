using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
    public string characterName;
    public float health = 100f;

    public virtual void Move()
    {
        Debug.Log($"{characterName} is moving.");
    }

    public abstract void Attack();
}

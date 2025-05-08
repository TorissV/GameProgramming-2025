using UnityEngine;

public class PlayerCharacter : CharacterBase
{
    public override void Move()
    {
        base.Move(); // сохраняем базовое поведение
        Debug.Log($"{characterName} (Player) is running with WASD.");
    }

    public override void Attack()
    {
        Debug.Log($"{characterName} (Player) attacks with a sword!");
    }
}

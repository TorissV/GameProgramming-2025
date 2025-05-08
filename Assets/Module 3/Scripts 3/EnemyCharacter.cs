using UnityEngine;

public class EnemyCharacter : CharacterBase
{
    public override void Attack()
    {
        Debug.Log($"{characterName} (Enemy) attacks with a claw!");
    }
}

using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    void Start()
    {
        GameObject player = Instantiate(playerPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        CharacterBase playerChar = player.GetComponent<CharacterBase>();
        playerChar.characterName = "Hero";
        playerChar.Move();
        playerChar.Attack();

        GameObject enemy = Instantiate(enemyPrefab, new Vector3(2, 0, 0), Quaternion.identity);
        CharacterBase enemyChar = enemy.GetComponent<CharacterBase>();
        enemyChar.characterName = "Goblin";
        enemyChar.Move();
        enemyChar.Attack();
    }
}

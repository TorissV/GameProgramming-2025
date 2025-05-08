using UnityEngine;

public class SimpleMover : MonoBehaviour, IMovable
{
    public void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
        Debug.Log("SimpleMover: Moving forward.");
    }
}

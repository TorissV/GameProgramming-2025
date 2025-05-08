using UnityEngine;

public class MoveToObject : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject Cube;
    public float speed;

    void Update()
    {
        Sphere.transform.position = Vector3.MoveTowards(Sphere.transform.position, Cube.transform.position, speed);
    }
}

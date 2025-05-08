using UnityEngine;

public class ObjectSpawnerB : MonoBehaviour
{
 public class MyObject
    {
        public string name;
        public int value;
    }

    void Start()
    {
        MyObject obj2 = new MyObject();
        obj2.name = "Banana";
        obj2.value = 20;

        Debug.Log("ObjectSpawnerB Creataed: " + obj2.name + " with value " + obj2.value);
    }
}

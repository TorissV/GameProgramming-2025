using UnityEngine;

public class ObjectSpawnerA : MonoBehaviour
{
    public class MyObject
    {
        public string name;
        public int value;

        public MyObject(string name, int value)
        {
            this.name = name;
            this.value = value;
        }
    }

    void Start()
    {
        MyObject obj1 = new MyObject("Apple", 10);
        Debug.Log("ObjectSpawnerA Created: " + obj1.name + " with value " + obj1.value);
    }
}

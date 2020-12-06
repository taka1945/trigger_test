using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : MonoBehaviour
{
    public string Subject;
    public string Name;
    public int Age;

    // Start is called before the first frame update
    void Start()
    {
        TeacherSet("huwei", "P40", 2020);
        Debug.Log("subject: " + this.Subject + ", name: " + this.Name + ", age: " + this.Age);
    }

    public void TeacherSet (string Subject , string Name , int Age)
    {
        this.Subject = Subject;
        this.Name = Name;
        this.Age = Age;        
    } 

}

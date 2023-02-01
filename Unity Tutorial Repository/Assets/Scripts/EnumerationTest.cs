using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumerationTest : MonoBehaviour
{
    
    public enum Directions{
        North, South, East,West
    }

    public Directions MyDirection;

    // Start is called before the first frame update
    void Start()
    {
        switch (MyDirection)
        {
            case Directions.North:
                DirectionSelected("North Selected");
                break;
            case Directions.South:
                DirectionSelected("South Selected");
                break;
            case Directions.East:
                DirectionSelected("East Selected");
                break;
            case Directions.West:
                DirectionSelected("West Selected");
                break;
        }
    }

    // Update is called once per frame
    void DirectionSelected(string text)
    {
        Debug.Log(text);
    }
}

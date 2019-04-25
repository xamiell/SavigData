using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    private float[] _position;
    
    public float[] Position
    {
        get
        {
            return _position;
        }
    }

    public PlayerData(PlayerController player)
    {
        _position = new float[2];

        _position[0] = player.transform.position.x;
        _position[1] = player.transform.position.y;
    }
}

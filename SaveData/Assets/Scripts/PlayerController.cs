using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(5f, 13f)]
    [SerializeField] float moveSpeed = 12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var deltaX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        var deltaY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + deltaX, transform.position.y + deltaY);
    }

    public void SavePlayerData()
    {
        DataManager.SaveData(this);
    }

    public void LoadPlayerData()
    {
        var data = DataManager.LoadData();

        if (data != null)
        {
            transform.position = new Vector2(data.Position[0], data.Position[1]);
        }
        else
        {
            Debug.Log("Player not saved data before.");
        }
    }
}

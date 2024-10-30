using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMap : MonoBehaviour
{
    public Tilemap MyTileMap;
    public Camera myCam;
    public TileBase testTilebase;

    void Start()
    {
        myCam = Camera.main;
        TryGetComponent<Tilemap>(out MyTileMap);

        //Right now X = 0 and Y doesn't exist
        for (int x = 0; x < 30; x++)
        {
            for (int y = 0; y < 30; y++)
            {
                // X = 0, Y = 99
                Debug.Log($"X {x} Y {y}");
            }
            // ...loop again
        }


        MyTileMap.SetTile(new Vector3Int(-6, -4, 0), null);
    }
    public void OnGUI()
    {
        Vector3 mouseWorldPosition = myCam.ScreenToWorldPoint(Input.mousePosition);
        GUI.Label(new Rect(50, 50, 600, 30),
            $"Mouse {Input.mousePosition} In cell space: {MyTileMap.WorldToCell(mouseWorldPosition)}");
    }
    void Update()
    {
        
    }
}

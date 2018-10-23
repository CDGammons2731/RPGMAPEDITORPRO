using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainEditor : MonoBehaviour {
    [Header("Terrain to edit")]
    public Terrain terrain;
    [Header("Terrain width, height, and length")]
    public int width = 500;
    public int height = 1;
    public int length = 500;
    [Header("Raise or Lower Terrain")]
    public bool RaiseLowerTerrain = false;
    [Header("Height to raise and/or lower")]
    public int Height = 1;
    public Vector3 Mouse;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Mou();
        TerrainSizeCheck();

        TerrainRaiseOrLower();
	}

    void Mou()
    {
        Mouse = Input.mousePosition;
    }

    void TerrainSizeCheck()
    {
        terrain.terrainData.size = new Vector3(width, height, length);
    }

    void TerrainRaiseOrLower()
    {
        
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainEditor : MonoBehaviour {
    [Header("Terrain to edit")]
    public Terrain terrain;
    [Header("Terrain width, height, and length")]
    public int x = 500;
    public int y = 1;
    public int z = 500;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TerrainSizeCheck();
	}

    void TerrainSizeCheck()
    {
        terrain.terrainData.size = new Vector3(x, y, z);
    }

}

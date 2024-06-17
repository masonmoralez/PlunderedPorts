using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PerlinNoiseGenerator
{
    // Start is called before the first frame update
    // Can be initializd with many different values and scaled 
    public static float[,] NoiseMapGenerator(int mapWidth, int mapHeight, float mapScale)
    {
        //creating a 2D array, containing the float values of all the Perlin Noise
        float[,] PerlinNoiseMap = new float[mapWidth, mapHeight];
        //clamps the scale value to a value that is not 0, so that we can divide by the scale
        if (mapScale == 0) 
        {
            mapScale = 0.0001f;
        }

        for (int width = 0; width < mapWidth; width++)
        {
            for (int height = 0; height < mapWidth; height++)
            {
                float PointX = width / mapScale;
                float PointY = height / mapScale;
                float PerlinNoiseValue = Mathf.PerlinNoise(PointX, PointY);
                PerlinNoiseMap[width, height] = PerlinNoiseValue;
            }
        }
        return PerlinNoiseMap;
    }
}


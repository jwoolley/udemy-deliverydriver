using System;
using System.Collections.Generic;
using System.Data;

public class TerrainTypeSpeeds {
  private Dictionary<TerrainTypeEnum, float> values = new Dictionary<TerrainTypeEnum, float>() {
    {  TerrainTypeEnum.OFFROAD, 0.75f },
    {  TerrainTypeEnum.PAVED, 1.00f },
    {  TerrainTypeEnum.GRASS, 0.5f }
  };
  public float getSpeed(TerrainTypeEnum type) {
    return values[type];
  }
}
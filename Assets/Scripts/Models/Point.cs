﻿using System.Collections.Generic;

public class GridPos {
    public int x;
    public int y;
}

public class Point
{
    public int id = -1;
    public Vector pos = new Vector();
    public GridPos gridPos = new GridPos();
    public List<Color> colors = new List<Color>(); 
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyData  {
    private int _Level = 0;

    public void Level(int lv) {
        this._Level = lv;
    }

    public int getLevel()
    {
        return this._Level;
    }
}

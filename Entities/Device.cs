﻿namespace FirstApi.Entities;

public abstract class Device
{
    protected bool IsConnected() => true;

    public abstract string GetBrand();
}

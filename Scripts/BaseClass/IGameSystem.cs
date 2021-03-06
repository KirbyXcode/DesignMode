﻿using System;
using System.Collections.Generic;
using System.Text;


public abstract class IGameSystem
{
    protected GameFacade mFacade;
    public virtual void Init() {
        mFacade = GameFacade.Insance;
    }
    public virtual void Update() { }
    public virtual void Release() { }
}

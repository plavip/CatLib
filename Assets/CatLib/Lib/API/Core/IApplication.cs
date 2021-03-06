﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */
 
using System.Collections;
using CatLib.API.Container;
using CatLib.API.Event;
using System;
using CatLib.API.Time;

namespace CatLib.API
{

    public interface IApplication : IContainer, IEventAchieve , IDriver , IEvent
    {

        IApplication Bootstrap(Type[] bootstraps);

        void Init();

        void Register(Type t);

        long GetGuid();

        ITime Time { get; }

    }

}

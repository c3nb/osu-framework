﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using osu.Framework.Allocation;
using System.Collections.Generic;

namespace osu.Framework.Graphics.Transforms
{
    public interface ITransformable
    {
        InvokeOnDisposal BeginDelayedSequence(double delay, bool recursive = false);

        double TransformStartTime { get; }

        void AddTransform(Transform transform);

        void RemoveTransforms(IEnumerable<Transform> toRemove);
    }
}

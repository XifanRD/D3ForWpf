﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Research.DynamicDataDisplay.ViewportConstraints;
using Microsoft.Research.DynamicDataDisplay;

namespace Microsoft.Research.DynamicDataDisplay.Controls
{
	internal sealed class FixedXConstraint : ViewportConstraint
	{
		public override DataRect Apply(DataRect previousDataRect, DataRect proposedDataRect, Viewport2D viewport)
		{
			return DataRect.Create(proposedDataRect.XMin, 0, proposedDataRect.XMax, 1);
		}
	}
}

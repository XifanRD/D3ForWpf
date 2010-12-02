﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Research.DynamicDataDisplay.Markers2;

namespace Microsoft.Research.DynamicDataDisplay
{
	/// <summary>
	/// Contains useful extension methods of PointChartBase class.
	/// </summary>
	public static class PointChartBaseExtensions
	{
		/// <summary>
		/// Sets the description of chart in the legend.
		/// </summary>
		/// <param name="chart">The chart.</param>
		/// <param name="description">The description.</param>
		/// <returns></returns>
		public static PointChartBase WithDescription(this PointChartBase chart, string description)
		{
			if (chart == null)
				throw new ArgumentNullException("chart");

			chart.Description = description;

			return chart;
		}

		/// <summary>
		/// Stes the detailed description of chart in the legend.
		/// </summary>
		/// <param name="chart">The chart.</param>
		/// <param name="detailedDescription">The detailed description.</param>
		/// <returns></returns>
		public static PointChartBase WithDetailedDescription(this PointChartBase chart, string detailedDescription)
		{
			if (chart == null)
				throw new ArgumentNullException("chart");

			chart.DetailedDescription = detailedDescription;
			
			return chart;
		}
	}
}

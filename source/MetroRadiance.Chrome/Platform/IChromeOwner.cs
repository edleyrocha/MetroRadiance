﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MetroRadiance.Chrome;

namespace MetroRadiance.Platform
{
	public interface IChromeOwner
	{
		IntPtr Handle { get; }

		double Left { get; }
		double Top { get; }
		double ActualWidth { get; }
		double ActualHeight { get; }
		bool IsActive { get; }
		WindowState WindowState { get; }
		ResizeMode ResizeMode { get; }
		Visibility Visibility { get; }

		event EventHandler ContentRendered;
		event EventHandler LocationChanged;
		event EventHandler SizeChanged;
		event EventHandler StateChanged;
		event EventHandler Activated;
		event EventHandler Deactivated;
		event EventHandler Closed;

		bool Activate();

		void Resize(SizingMode sizingMode);
	}
}

﻿namespace Mapbox.Unity.Map
{
	public abstract class MapboxDataProperty
	{
		public event System.EventHandler PropertyHasChanged;
		protected virtual void OnPropertyHasChanged(System.EventArgs e)
		{
			System.EventHandler handler = PropertyHasChanged;
			if (handler != null)
			{
				handler(this, e);
			}
		}
		public bool HasChanged
		{
			set
			{
				if (value == true)
				{
					OnPropertyHasChanged(null /*Pass args here */);
				}
			}
		}
	}
}

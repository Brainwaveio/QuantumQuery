﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace QuantumQuery.WPF.Extensions
{
	internal class ObservableObject : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
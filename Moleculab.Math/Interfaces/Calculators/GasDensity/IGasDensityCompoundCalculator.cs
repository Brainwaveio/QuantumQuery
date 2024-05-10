﻿using Moleculab.Core.SQLite.DTOs;

namespace Moleculab.Math.Interfaces.Calculators.GasDensity
{
	public interface IGasDensityCompoundCalculator
	{
		void AddOfCompound(Compound compound, int quantity);
		float GetEquals(Compound compound);
		Task<ElementDto> GetElementAsync();
	}
}
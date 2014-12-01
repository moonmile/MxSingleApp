using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalc.Core.Services
{
	public interface ICalculation
	{
		double TipAmount(double subTotal, int generosity);
	}
}
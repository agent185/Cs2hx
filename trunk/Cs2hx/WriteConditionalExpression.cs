﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Cs2hx
{
	static class WriteConditionalExpression
	{
		public static void Go(HaxeWriter writer, ConditionalExpressionSyntax expression)
		{
			Core.Write(writer, expression.Condition);
			writer.Write(" ? ");
			Core.Write(writer, expression.WhenTrue);
			writer.Write(" : ");
			Core.Write(writer, expression.WhenFalse);
		}
	}
}

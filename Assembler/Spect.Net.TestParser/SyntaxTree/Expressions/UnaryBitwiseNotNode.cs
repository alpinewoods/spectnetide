﻿using Antlr4.Runtime;

namespace Spect.Net.TestParser.SyntaxTree.Expressions
{
    /// <summary>
    /// This class represents an UNARY bitwise NOT operation
    /// </summary>
    public sealed class UnaryBitwiseNotNode : UnaryExpressionNode
    {
        /// <summary>
        /// Retrieves the value of the expression
        /// </summary>
        /// <param name="evalContext">Evaluation context</param>
        /// <returns>Evaluated expression value</returns>
        public override ExpressionValue Evaluate(IExpressionEvaluationContext evalContext)
        {
            // --- Check operand error
            var operandValue = Operand.Evaluate(evalContext);
            if (operandValue.Type == ExpressionValueType.Error)
            {
                EvaluationError = Operand.EvaluationError;
                return ExpressionValue.Error;
            }
    
            // --- Carry out operation
            switch (operandValue.Type)
            {
                case ExpressionValueType.ByteArray:
                    EvaluationError = "Bitwise NOT operator cannot be applied on a byte array";
                    return ExpressionValue.Error;
                case ExpressionValueType.Bool:
                case ExpressionValueType.Number:
                    return new ExpressionValue((ushort)~operandValue.AsNumber());
                default:
                    return ExpressionValue.Error;
            }
        }

        public UnaryBitwiseNotNode(ParserRuleContext context) : base(context)
        {
        }
    }
}
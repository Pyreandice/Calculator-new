﻿using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class CalculatorClass
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatorClass"/> class.
        /// </summary>
        /// <param name="valueAlpha">The value alpha.</param>
        /// <param name="firstOperand1">The first operand1.</param>
        /// <param name="secondOperand2">The second operand2.</param>
        /// <param name="passedOperators">The passed operators.</param>
        public CalculatorClass
        (
            double valueAlpha = 0.0,
            double firstOperand1 = 0.0,
            double secondOperand2 = 0.0,
            Operators passedOperators = Operators.None
        )
        {
            this.Op = passedOperators;
            this.CurrentValue = valueAlpha;
            this.Operand1 = firstOperand1;
            this.Operand2 = secondOperand2;
        }

        /// <summary>
        /// Instantiate public enum Operators.
        /// Contains a list of the operators used in basic arithmetic. 
        /// </summary>
        public enum Operators
        {
            AdditionOp = '+',
            SubtractionOp = '-',
            MultiplicationOp = '*',
            DivisionOp = '/',
            None = 'n'
        };

        /// <summary>
        /// Gets or sets the current value.
        /// </summary>
        /// <value>
        /// The current value.
        /// </value>
        public double CurrentValue { get; set; }

        /// <summary>
        /// Gets or sets the operand1.
        /// </summary>
        /// <value>
        /// The operand1.
        /// </value>
        public double Operand1 { get; set; }

        /// <summary>
        /// Gets or sets the operand2.
        /// </summary>
        /// <value>
        /// The operand2.
        /// </value>
        public double Operand2 { get; set; }

        /// <summary>
        /// Gets or sets the Op.
        /// </summary>
        /// <value>
        /// The op.
        /// </value>
        public Operators Op { get; set; }

        /// <summary>
        /// Adds Operand1 and Operand2 and returns CurrentValue.
        /// </summary>
        public void Addition()
        {
            CurrentValue = Operand1 + Operand2;
        }

        /// <summary>
        /// Subtracts Operand1 and Operand2 and returns CurrentValue.
        /// </summary>
        public void Subtraction()
        {
            CurrentValue = Operand1 - Operand2;
        }

        /// <summary>
        /// Multiplies Operand1 and Operand2 and returns CurrentValue.
        /// </summary>
        public void Multiplication()
        {
            CurrentValue = Operand1 * Operand2;
        }

        /// <summary>
        /// Divides Operand1 and Operand2 and returns CurrentValue.
        /// </summary>
        public void Division()
        {
            CurrentValue = Operand1 / Operand2;
        }

        /// <summary>
        /// Perform the required operation on the Operand1 and Operand2
        /// and return the result as the CurrentValue.
        /// Throw ArgumentOutOfRangeException(); if none of the operators
        /// are present for the switch case.
        /// </summary>
        public void Equals()
        {
            switch (Op)
            {
                case Operators.AdditionOp:
                   Addition();
                    break;
                case Operators.DivisionOp:
                    Division();
                    break;
                case Operators.SubtractionOp:
                    Subtraction();
                    break;
                case Operators.MultiplicationOp:
                    Multiplication();
                    break;
                case Operators.None:
                    break;
                default:
                    // If this gets hit... Something went horribly wrong...
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Converts the CurrentValue to its reciprocal. If the current value is
        /// equal to zero. Take the passedVar and divide it by one to get the inverse of it.
        /// If it is not equal to zero, process the operation and call the Equals method to
        /// keep performing operations.
        /// </summary>
        /// <param name="passedVar">The passed variable.</param>
        public void ToReciprocal(double passedVar)
        {
            if (CurrentValue.CompareTo(passedVar) == 0)
            {
                CurrentValue = 1 / CurrentValue;
            }
            else
            {
                Operand2 = 1 / CurrentValue;
                Equals();
            }
        }

        /// <summary>
        /// Converts the CurrentValue to a negative number if the number is
        /// equal to zero. If the number is equal to zero make it (number 0) equal
        /// to the second operand and call the Equals method to keep performing operations.
        /// </summary>
        /// <param name="passedVar">The passed variable.</param>
        public void ToNegativeNumber(double passedVar)
        {
            if (CurrentValue.CompareTo(passedVar) == 0)
            {
                CurrentValue = CurrentValue * -1;
            }
            else
            {
                Operand2 = passedVar * -1;
                Equals();
            }
        }

        /// <summary>
        /// Squares the root if the value being square rooted is equal to zero.
        /// If the value is equal to zero. Process the operation and call the
        /// equals method to keep performing operations.
        /// </summary>
        /// <param name="passedVar">The passed variable.</param>
        public void SquareRoot(double passedVar)
        {
            if (CurrentValue.CompareTo(passedVar) == 0)
            {
                CurrentValue = Math.Sqrt(CurrentValue);
            }
            else
            {
                Operand2 = Math.Sqrt(passedVar);
                Equals();
            }
        }

        /// <summary>
        /// Clears the properties of any held values.
        /// </summary>
        public void Clear()
        {
            this.CurrentValue = 0.0;
            this.Operand1 = 0.0;
            this.Operand2 = 0.0;
            this.Op = Operators.None;
        }
    }
}
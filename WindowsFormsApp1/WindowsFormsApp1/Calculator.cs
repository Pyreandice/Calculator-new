using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        #region Constants
        /// <summary>
        /// The number zero.
        /// </summary>
        private const double NumberZero = 0;

        /// <summary>
        /// The number one.
        /// </summary>
        private const double NumberOne = 1;

        /// <summary>
        /// The number two.
        /// </summary>
        private const double NumberTwo = 2;

        /// <summary>
        /// The number three.
        /// </summary>
        private const double NumberThree = 3;

        /// <summary>
        /// The number four.
        /// </summary>
        private const double NumberFour = 4;

        /// <summary>
        /// The number five.
        /// </summary>
        private const double NumberFive = 5;

        /// <summary>
        /// The number six.
        /// </summary>
        private const double NumberSix = 6;

        /// <summary>
        /// The number seven.
        /// </summary>
        private const double NumberSeven = 7;

        /// <summary>
        /// The number eight.
        /// </summary>
        private const double NumberEight = 8;

        /// <summary>
        /// The number nine.
        /// </summary>
        private const double NumberNine = 9;

        /// <summary>
        /// The division character.
        /// </summary>
        private const char DivisionChar = '/';

        /// <summary>
        /// The multiplication character.
        /// </summary>
        private const char MultiplicationChar = '*';

        /// <summary>
        /// The subtraction character.
        /// </summary>
        private const char SubtractionChar = '-';

        /// <summary>
        /// The addition character.
        /// </summary>
        private const char AdditionChar = '+';

        /// <summary>
        /// The negative character.
        /// </summary>
        private const char NegativeChar = '-';

        /// <summary>
        /// The decimal character.
        /// </summary>
        private const char DecimalChar = '.';
        #endregion

        /// <summary>
        /// Holds the last value the user entered.
        /// </summary>
        private double SecondCurrentValue;

        /// <summary>
        /// Holds the result of the last operation.
        /// </summary>
        public double HoldLastResult;
        
        /// <summary>
        /// Keeps track of the number of times the user has
        /// clicked a number or the decimal / ToNegative button.
        /// </summary>
        private int Counter;

        /// <summary>
        /// Variable of type Calculator for passing values and operators to
        /// the Calculator class for future manipulation.
        /// </summary>
        public CalculatorClass VarCalculator { get; set; } = new CalculatorClass();

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:WindowsFormsApp1.Calculator" /> class.
        /// </summary>
        public Calculator()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Enters the number '1' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumOneButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberOne.ToString(CultureInfo.InvariantCulture);
            this.SecondCurrentValue = NumberOne;
            this.VarCalculator.Operand1 = NumberOne;
            if (this.SecondCurrentValue.CompareTo(0.0) != 0)
            {
                this.VarCalculator.Operand2 = this.SecondCurrentValue;
            }
            else
            {
                this.VarCalculator.Operand1 = this.VarCalculator.CurrentValue;
            }
        }

        /// <summary>
        /// Enters the number '2' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumTwoButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberTwo.ToString(CultureInfo.InvariantCulture);
            this.SecondCurrentValue = NumberTwo;
            this.VarCalculator.Operand1 = NumberTwo;
            if (this.SecondCurrentValue.CompareTo(0.0) != 0)
            {
                this.VarCalculator.Operand2 = this.SecondCurrentValue;
            }
            else
            {
                this.VarCalculator.Operand1 = this.VarCalculator.CurrentValue;
            }
        }

        /// <summary>
        /// Enters the number '3' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumThreeButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberThree.ToString(CultureInfo.InvariantCulture);
            this.SecondCurrentValue = NumberThree;
            this.VarCalculator.Operand1 = NumberThree;
            if (this.SecondCurrentValue.CompareTo(0.0) != 0)
            {
                this.VarCalculator.Operand2 = this.SecondCurrentValue;
            }
            else
            {
                this.VarCalculator.Operand1 = this.VarCalculator.CurrentValue;
            }
        }

        /// <summary>
        /// Enters the number '4' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumFourButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberFour.ToString(CultureInfo.InvariantCulture);
            this.SecondCurrentValue = NumberFour;
            this.VarCalculator.Operand1 = NumberFour;
            if (this.SecondCurrentValue.CompareTo(0.0) != 0)
            {
                this.VarCalculator.Operand2 = this.SecondCurrentValue;
            }
            else
            {
                this.VarCalculator.Operand1 = this.VarCalculator.CurrentValue;
            }
        }

        /// <summary>
        /// Enters the number '5' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumFiveButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberFive.ToString(CultureInfo.InvariantCulture);
            this.SecondCurrentValue = NumberFive;
            this.VarCalculator.Operand1 = NumberFive;
            if (this.SecondCurrentValue.CompareTo(0.0) != 0)
            {
                this.VarCalculator.Operand2 = this.SecondCurrentValue;
            }
            else
            {
                this.VarCalculator.Operand1 = this.VarCalculator.CurrentValue;
            }
        }

        /// <summary>
        /// Enters the number '6' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumSixButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberSix.ToString(CultureInfo.InvariantCulture);
            this.SecondCurrentValue = NumberSix;
            this.VarCalculator.Operand1 = NumberSix;
            if (this.SecondCurrentValue.CompareTo(0.0) != 0)
            {
                this.VarCalculator.Operand2 = this.SecondCurrentValue;
            }
            else
            {
                this.VarCalculator.Operand1 = this.VarCalculator.CurrentValue;
            }
        }

        /// <summary>
        /// Enters the number '7' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumSevenButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberSeven.ToString(CultureInfo.InvariantCulture);
            this.SecondCurrentValue = NumberSeven;
            this.VarCalculator.Operand1 = NumberSeven;
            if (this.SecondCurrentValue.CompareTo(0.0) != 0)
            {
                this.VarCalculator.Operand2 = this.SecondCurrentValue;
            }
            else
            {
                this.VarCalculator.Operand1 = this.VarCalculator.CurrentValue;
            }
        }

        /// <summary>
        /// Enter the number '8' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumEightButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberEight.ToString(CultureInfo.InvariantCulture);
            this.SecondCurrentValue = NumberEight;
            this.VarCalculator.Operand1 = NumberEight;
            if (this.SecondCurrentValue.CompareTo(0.0) != 0)
            {
                this.VarCalculator.Operand2 = this.SecondCurrentValue;
            }
            else
            {
                this.VarCalculator.Operand1 = this.VarCalculator.CurrentValue;
            }
        }

        /// <summary>
        /// Enter the number '9' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumNineButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberNine.ToString(CultureInfo.InvariantCulture);
            this.SecondCurrentValue = NumberNine;
            this.VarCalculator.Operand1 = NumberNine;
            if (this.SecondCurrentValue.CompareTo(0.0) != 0)
            {
                this.VarCalculator.Operand2 = this.SecondCurrentValue;
            }
            else
            {
                this.VarCalculator.Operand1 = this.VarCalculator.CurrentValue;
            }
            this.Counter += 1;
        }

        /// <summary>
        /// Enter the number '0' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NumZeroButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += NumberZero.ToString(CultureInfo.InvariantCulture);
            this.SecondCurrentValue = NumberZero;
            if (this.SecondCurrentValue.CompareTo(0.0) != 0)
            {
                this.VarCalculator.Operand2 = this.SecondCurrentValue;
            }
            else
            {
                this.VarCalculator.Operand1 = this.VarCalculator.CurrentValue;
            }
            this.Counter += 1;
        }

        /// <summary>
        /// Enter the operator '/' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DivisonButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += DivisionChar.ToString();
            this.VarCalculator.Op = CalculatorClass.Operators.DivisionOp;
            if (this.VarCalculator.Operand1.CompareTo(0.0) != 0 && this.VarCalculator.Operand2.CompareTo(0.0) != 0)
            {
                this.VarCalculator.Division();
                this.HoldLastResult = this.VarCalculator.CurrentValue;
                this.VarCalculator.Operand2 = 0.0;
            }
        }

        /// <summary>
        /// Enter the operator '*' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += MultiplicationChar.ToString();
            this.VarCalculator.Op = CalculatorClass.Operators.MultiplicationOp;
            if (this.VarCalculator.Operand1.CompareTo(0.0) != 0 && this.VarCalculator.Operand2.CompareTo(0.0) != 0)
            {
                this.VarCalculator.Multiplication();
                this.HoldLastResult = this.VarCalculator.CurrentValue;
                this.VarCalculator.Operand2 = 0.0;
            }
        }

        /// <summary>
        /// Enter the operator '-' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += SubtractionChar.ToString();
            this.VarCalculator.Op = CalculatorClass.Operators.SubtractionOp;
            if (this.VarCalculator.Operand1.CompareTo(0.0) != 0 && this.VarCalculator.Operand2.CompareTo(0.0) != 0)
            {
                this.VarCalculator.Subtraction();
                this.HoldLastResult = this.VarCalculator.CurrentValue;
                this.VarCalculator.Operand2 = 0.0;
            }
        }

        /// <summary>
        /// Enter the operator '+' to the text box and stack for later calculation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AdditionButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += AdditionChar.ToString();
            this.VarCalculator.Op = CalculatorClass.Operators.AdditionOp;
            if (this.VarCalculator.Operand1.CompareTo(0.0) != 0 && this.VarCalculator.Operand2.CompareTo(0.0) != 0)
            {
                this.VarCalculator.Addition();
                this.HoldLastResult = this.VarCalculator.CurrentValue;
                this.VarCalculator.Operand2 = 0.0;
            }
        }

        /// <summary>
        /// Remove one value from the text box and reset the current value and or
        /// operator1 or operator2 for later manipulation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.VarCalculator.CurrentValue = NumberZero;
            if (this.OutputTextBox.Text.Length > 0)
            {
                this.OutputTextBox.Text = this.OutputTextBox.Text.Remove(this.OutputTextBox.Text.Length - 1);
                if (this.Counter > 0)
                {
                    this.Counter--;
                }
                else if (Counter < 0)
                {
                    this.Counter = 0;
                }// else Counter is equal to 0 doNothing();
            } // else OutputTextBox.Text.Length is equal to zero. Nothing in text Box. doNothing();
        }

        /// <summary>
        /// Clears the instance of the calculator class
        /// and resets the program GUI environment to allow a clean start.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Clear();
            this.VarCalculator.Clear();
            this.Counter = 0;
            this.SecondCurrentValue = 0.0;
            this.HoldLastResult = 0.0;
        }

        /// <summary>
        /// Take the current formula and process all of the operations.
        /// Return the result of the operations as CurrentValue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            this.VarCalculator.Equals();
            this.OutputTextBox.Text = this.VarCalculator.CurrentValue.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Take the current number and return the reciprocal of that value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneOverXButton_Click(object sender, EventArgs e)
        {
            this.VarCalculator.ToReciprocal(this.VarCalculator.CurrentValue);
            this.OutputTextBox.Text = this.VarCalculator.CurrentValue.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Take the current value and return the square root of that value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SqareRootButton_Click(object sender, EventArgs e)
        {
            this.VarCalculator.SquareRoot(this.VarCalculator.CurrentValue);
            this.OutputTextBox.Text = this.VarCalculator.CurrentValue.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Take the current value and return the negative variant of that value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NegativePositiveButton_Click(object sender, EventArgs e)
        {
            this.VarCalculator.ToNegativeNumber(this.VarCalculator.CurrentValue);
            this.OutputTextBox.Text = this.VarCalculator.CurrentValue.ToString(CultureInfo.InvariantCulture);
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text += '.';
        }
    }
}

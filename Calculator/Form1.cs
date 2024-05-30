using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        private Rectangle num1BtnRectangle;
        private Rectangle num2BtnRectangle;
        private Rectangle num3BtnRectangle;
        private Rectangle num4BtnRectangle;
        private Rectangle num5BtnRectangle;
        private Rectangle num6BtnRectangle;
        private Rectangle num7BtnRectangle;
        private Rectangle num8BtnRectangle;
        private Rectangle num9BtnRectangle;
        private Rectangle zeroBtnRectangle;

        private Rectangle plusBtnRectangle;
        private Rectangle minusBtnRectangle;
        private Rectangle multiplyBtnRectangle;
        private Rectangle divideBtnRectangle;

        private Rectangle decimalBtnRectangle;
        private Rectangle plusMinusBtnRectangle;

        private Rectangle equalBtnRectangle;
        private Rectangle clearBtnRectangle;

        private Rectangle displayLabelRectangle;

        private Size originalFormSize;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            num1BtnRectangle = new Rectangle(num1.Location.X, num1.Location.Y, num1.Width, num1.Height);
            num2BtnRectangle = new Rectangle(num2.Location.X, num2.Location.Y, num2.Width, num2.Height);
            num3BtnRectangle = new Rectangle(num3.Location.X, num3.Location.Y, num3.Width, num3.Height);
            num4BtnRectangle = new Rectangle(num4.Location.X, num4.Location.Y, num4.Width, num4.Height);
            num5BtnRectangle = new Rectangle(num5.Location.X, num5.Location.Y, num5.Width, num5.Height);
            num6BtnRectangle = new Rectangle(num6.Location.X, num6.Location.Y, num6.Width, num6.Height);
            num7BtnRectangle = new Rectangle(num7.Location.X, num7.Location.Y, num7.Width, num7.Height);
            num8BtnRectangle = new Rectangle(num8.Location.X, num8.Location.Y, num8.Width, num8.Height);
            num9BtnRectangle = new Rectangle(num9.Location.X, num9.Location.Y, num9.Width, num9.Height);
            zeroBtnRectangle = new Rectangle(zeroBtn.Location.X, zeroBtn.Location.Y, zeroBtn.Width, zeroBtn.Height);

            plusBtnRectangle = new Rectangle(plusBtn.Location.X, plusBtn.Location.Y, plusBtn.Width, plusBtn.Height);
            minusBtnRectangle = new Rectangle(minusBtn.Location.X, minusBtn.Location.Y, minusBtn.Width, minusBtn.Height);
            multiplyBtnRectangle = new Rectangle(multiplyBtn.Location.X, multiplyBtn.Location.Y, multiplyBtn.Width, multiplyBtn.Height);
            divideBtnRectangle = new Rectangle(divideBtn.Location.X, divideBtn.Location.Y, divideBtn.Width, divideBtn.Height);

            decimalBtnRectangle = new Rectangle(decimalBtn.Location.X, decimalBtn.Location.Y, decimalBtn.Width, decimalBtn.Height);
            plusMinusBtnRectangle = new Rectangle(plusMinusBtn.Location.X, plusMinusBtn.Location.Y, plusMinusBtn.Width, plusMinusBtn.Height);

            equalBtnRectangle = new Rectangle(equalBtn.Location.X, equalBtn.Location.Y, equalBtn.Width, equalBtn.Height);
            clearBtnRectangle = new Rectangle(clearBtn.Location.X, clearBtn.Location.Y, clearBtn.Width, clearBtn.Height);

            displayLabelRectangle = new Rectangle(displayLabel.Location.X, displayLabel.Location.Y, displayLabel.Width, displayLabel.Height);

        }

        private void Calculator_Resize(object sender, EventArgs e)
        {
            resizeControl(num1BtnRectangle, num1);
            resizeControl(num2BtnRectangle, num2);
            resizeControl(num3BtnRectangle, num3);
            resizeControl(num4BtnRectangle, num4);
            resizeControl(num5BtnRectangle, num5);
            resizeControl(num6BtnRectangle, num6);
            resizeControl(num7BtnRectangle, num7);
            resizeControl(num8BtnRectangle, num8);
            resizeControl(num9BtnRectangle, num9);
            resizeControl(zeroBtnRectangle, zeroBtn);

            resizeControl(plusBtnRectangle, plusBtn);
            resizeControl(minusBtnRectangle, minusBtn);
            resizeControl(multiplyBtnRectangle, multiplyBtn);
            resizeControl(divideBtnRectangle, divideBtn);

            resizeControl(decimalBtnRectangle, decimalBtn);
            resizeControl(plusMinusBtnRectangle, plusMinusBtn);

            resizeControl(equalBtnRectangle, equalBtn);
            resizeControl(clearBtnRectangle, clearBtn);

            resizeControl(displayLabelRectangle, displayLabel);
        }

        private void resizeControl(Rectangle OriginalControlRectangle, Control control)
        {
            float xAxis = (float)(this.Width) / (float)(originalFormSize.Width);
            float yAxis = (float)(this.Height) / (float)(originalFormSize.Height);

            int newXPosition = (int)(OriginalControlRectangle.X * xAxis);
            int newYPosition = (int)(OriginalControlRectangle.Y * yAxis);

            int newWidth = (int)(originalFormSize.Width * xAxis);
            int newHeight = (int)(originalFormSize.Height * yAxis);

            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHeight);
        }

        private void num1_Click(object sender, EventArgs e)
        {

        }

        private void num2_Click(object sender, EventArgs e)
        {

        }

        private void num3_Click(object sender, EventArgs e)
        {

        }

        private void num4_Click(object sender, EventArgs e)
        {

        }

        private void num5_Click(object sender, EventArgs e)
        {

        }

        private void num6_Click(object sender, EventArgs e)
        {

        }

        private void num7_Click(object sender, EventArgs e)
        {

        }

        private void num8_Click(object sender, EventArgs e)
        {

        }

        private void num9_Click(object sender, EventArgs e)
        {

        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }

        private void equalBtn_Click(object sender, EventArgs e)
        {

        }

        private void plusBtn_Click(object sender, EventArgs e)
        {

        }

        private void minusBtn_Click(object sender, EventArgs e)
        {

        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {

        }

        private void devideBtn_Click(object sender, EventArgs e)
        {

        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {

        }

        private void plusMinusBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

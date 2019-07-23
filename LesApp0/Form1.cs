using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesApp0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BDecimal_Click(object sender, EventArgs e)
        {
            // Діапазон допустимих значень
            MessageBox.Show($"Мінімальне значення: {decimal.MinValue};\n" +
                $"Максимальне значення: {decimal.MaxValue}.",$"{typeof(decimal).Name}");
        }

        private void BFloat_Click(object sender, EventArgs e)
        {
            // Діапазон допустимих значень і точність
            MessageBox.Show($"Мінімальне значення: {float.MinValue};\n" +
                $"Максимальне значення: {float.MaxValue};\n" +
                $"Точність: {float.Epsilon}.", $"{typeof(float).Name}");
        }

        private void BDouble_Click(object sender, EventArgs e)
        {
            // Діапазон допустимих значень і точність
            MessageBox.Show($"Мінімальне значення: {double.MinValue};\n" +
                $"Максимальне значення: {double.MaxValue};\n" +
                $"Точність: {double.Epsilon}.", $"{typeof(double).Name}");
        }

        private void BSbyte_Click(object sender, EventArgs e)
        {
            // Діапазон допустимих значень
            MessageBox.Show($"Мінімальне значення: {sbyte.MinValue};\n" +
                $"Максимальне значення: {sbyte.MaxValue}.", $"{typeof(sbyte).Name}");
        }

        private void BByte_Click(object sender, EventArgs e)
        {
            // Діапазон допустимих значень
            MessageBox.Show($"Мінімальне значення: {byte.MinValue};\n" +
                $"Максимальне значення: {byte.MaxValue}.", $"{typeof(byte).Name}");
        }

        private void BShort_Click(object sender, EventArgs e)
        {
            // Діапазон допустимих значень
            MessageBox.Show($"Мінімальне значення: {short.MinValue};\n" +
                $"Максимальне значення: {short.MaxValue}.", $"{typeof(short).Name}");
        }

        private void BUshort_Click(object sender, EventArgs e)
        {
            // Діапазон допустимих значень
            MessageBox.Show($"Мінімальне значення: {ushort.MinValue};\n" +
                $"Максимальне значення: {ushort.MaxValue}.", $"{typeof(ushort).Name}");
        }

        private void BInt_Click(object sender, EventArgs e)
        {
            // Діапазон допустимих значень
            MessageBox.Show($"Мінімальне значення: {int.MinValue};\n" +
                $"Максимальне значення: {int.MaxValue}.", $"{typeof(int).Name}");
        }

        private void BUint_Click(object sender, EventArgs e)
        {
            // Діапазон допустимих значень
            MessageBox.Show($"Мінімальне значення: {uint.MinValue};\n" +
                $"Максимальне значення: {uint.MaxValue}.", $"{typeof(uint).Name}");
        }

        private void BLong_Click(object sender, EventArgs e)
        {
            // Діапазон допустимих значень
            MessageBox.Show($"Мінімальне значення: {long.MinValue};\n" +
                $"Максимальне значення: {long.MaxValue}.", $"{typeof(long).Name}");
        }

        private void BUlong_Click(object sender, EventArgs e)
        {
            // Діапазон допустимих значень
            MessageBox.Show($"Мінімальне значення: {ulong.MinValue};\n" +
                $"Максимальне значення: {ulong.MaxValue}.", $"{typeof(ulong).Name}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MillersDeterminateAlgorythm;

namespace PrimeNumbersList
{
    public partial class MainForm : Form
    {
        public List<BigInteger> list { get; set; }
        public const int ColumnsCount = 10;
        public const int RowsCount = 10;

        public BigInteger NValue {
            get => (BigInteger.TryParse(paramTbx.Text, out BigInteger value) || value > BigInteger.Pow(10, 36)) ? value : -1;
            set => paramTbx.Text = value.ToString();
        }

        public MainForm()
        {
            InitializeComponent();

            InitTable();

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            SetCellValue(0, 0, NValue.ToString());
            BigInteger N = NValue;
            if (N == -1 || N > BigInteger.Pow(10, 36))
            {
                MessageBox.Show("Необходимо ввести натуральное число, не превосходящее 10^36");
                return;
            }
            list = Algorythm.PrimeNumbersPage(N, ColumnsCount * RowsCount);
            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j < ColumnsCount; j++)
                {
                    if (j % 2 == 1) SetCellValue(i, j, list[10 * j + 9 - i].ToString());
                    else SetCellValue(i, j, list[10 * j + i].ToString());
                    // SetCellValue(i, j, list[10 * j + i].ToString());
                }
            }
        }

        public void LeftClicked()
        {
            if (list == null) MessageBox.Show("Сначала введите число и нажмите кнопку Start");
            else
            {
                try
                {
                    List<BigInteger> listLeft = Algorythm.PrimeNumbersLeft(RowsCount, list);
                    if (listLeft[0] != 2)
                    {
                        for (int i = 0; i < RowsCount; i++)
                        {
                            for (int j = 0; j < ColumnsCount; j++)
                            {
                                if (j % 2 == 1) SetCellValue(i, j, list[10 * j + 9 - i].ToString());
                                else SetCellValue(i, j, list[10 * j + i].ToString());
                                //SetCellValue(i, j, listLeft[10 * j + i].ToString());
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Дождитесь завершения комнады");
                }
            }
        }

        public void RightClicked()
        {
            if (list == null) MessageBox.Show("Сначала введите число и нажмите кнопку Start");
            else
            {
                try
                {
                    if (list[list.Count() - 1] > BigInteger.Pow(10, 36))
                        MessageBox.Show("Алгоритм работает не более, чем для тридцатишестизначныхх чисел");
                    else
                    {
                        List<BigInteger> listRight = Algorythm.PrimeNumbersRight(RowsCount, list);
                        for (int i = 0; i < RowsCount; i++)
                        {
                            for (int j = 0; j < ColumnsCount; j++)
                            {
                                if (j % 2 == 1) SetCellValue(i, j, list[10 * j + 9 - i].ToString());
                                else SetCellValue(i, j, list[10 * j + i].ToString());
                                // SetCellValue(i, j, listRight[10 * j + i].ToString());
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Дождитесь завершения команды");
                }
            }
        }

        public void SetCellValue(int row, int column, string value)
        {
            try
            {
                tableDgv.Rows[row].Cells[column].Value = value;
            }
            catch (Exception e)
            { MessageBox.Show("Меньше 2 простых чисел нет"); }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            switch (e.NewValue)
            {
                case 0:
                    LeftClicked();
                    break;
                case 1:
                    // не меняется
                    break;
                case 2:
                    RightClicked();
                    break;
            }

            ScrollToDefault();
        }

        public async Task ScrollToDefault()
        {
            await Task.Delay(100);
            hScrollBar1.Value = 1;
        }

        private void paramTbx_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));

        private void InitTable()
        {
            for (var column = 0; column < ColumnsCount; ++column)
                tableDgv.Columns.Add(new DataGridViewColumn(new ScrollableTextBoxCell()));
            tableDgv.RowCount = RowsCount;
        }

        private void paramTbx_TextChanged(object sender, EventArgs e)
        {
        }
    }

    public class ScrollableTextBoxCell : DataGridViewTextBoxCell
    {

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            if (DataGridView.EditingControl is DataGridViewTextBoxEditingControl textBox)
            {
                textBox.ReadOnly = true;
                textBox.ScrollBars = ScrollBars.Horizontal;
            }
        }

    }
}

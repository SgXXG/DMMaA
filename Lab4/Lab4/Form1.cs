using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Function[] functions;

        Persiptron persiptron;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void teachingButton_Click(object sender, EventArgs e)
        {
            var classCount = (int) classesCountNnumericUpDown.Value;
            var vectorsSize = (int) elementsCountNumericUpDown3.Value;
            dataGridView1.ColumnCount = vectorsSize;
            dataGridView1.RowCount = 1;
            var vectorsCount = (int) vectorsCountNumericUpDown.Value;
         
            persiptron = new Persiptron(classCount, vectorsSize+1);
            Vector[][] vectors = GetRandomVectors(classCount, vectorsCount, vectorsSize);
            functions = persiptron.GetSepareteFunctions(vectors);
            if (persiptron.Warning)
                MessageBox.Show("Итерационный процесс не сошёлся. Возможны неверные результаты",
                    "Lab4", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            PrintResult(classCount, vectorsCount, vectorsSize, vectors);
            getClassButton.Enabled = true;
        }

        private void PrintResult(int classCount, int vectorsCount, int vectorsSize, Vector[][] vectors)
        {
            teachingResultTextBox.Text = "";
            PrintTeachingResult(classCount, vectorsCount, vectorsSize, vectors);
            teachingResultTextBox.Text += "\r\n\r\nРАЗРЕШАЮЩИЕ ФУНКЦИИ:\r\n";
            PrintFunctions(classCount, vectorsSize);
        }

        private void PrintFunctions(int classCount, int vectorsSize)
        {
            for (int i = 0; i < classCount; i++)
            {
                teachingResultTextBox.Text += "d(" + (i + 1) + ")  = ";
                for (int j = 0; j < vectorsSize; j++)
                {
                    if (j != 0 && functions[i].Elements[j] >= 0)
                    {
                        teachingResultTextBox.Text += "+";
                    }
                    teachingResultTextBox.Text += functions[i].Elements[j] + "*x" + (j + 1);
                }
                if (functions[i].Elements[vectorsSize] >= 0)
                {
                    teachingResultTextBox.Text += "+";
                }
                teachingResultTextBox.Text += functions[i].Elements[vectorsSize];
                teachingResultTextBox.Text += "\r\n";
            }
        }

        private void PrintTeachingResult(int classCount, int vectorsCount, int vectorsSize,
            Vector[][] vectors)
        {
            for (int i = 0; i < classCount; i++)
            {
                teachingResultTextBox.Text += (i + 1) + " КЛАСС:\r\n";
                for (int j = 0; j < vectorsCount; j++)
                {
                    teachingResultTextBox.Text += "(";
                    for (int k = 0; k < vectorsSize; k++)
                    {
                        teachingResultTextBox.Text += vectors[i][j].Elements[k] + "; ";
                    }
                    teachingResultTextBox.Text += ")\r\n";
                }
            }
        }

        private static Vector[][] GetRandomVectors(int classCount, int vectorsCount, int vectorsSize)
        {
            var rnd = new Random();
            var vectors = new Vector[classCount][];
            for (int i = 0; i < classCount; i++)
            {
                vectors[i] = new Vector[vectorsCount];
                for (int j = 0; j < vectorsCount; j++)
                {
                    vectors[i][j] = new Vector(vectorsSize+1);
                    for (int k = 0; k < vectorsSize; k++)
                    {
                        vectors[i][j].Elements[k] = rnd.Next(-10, 10);
                    }
                    vectors[i][j].Elements[vectorsSize] = 1;
                }
            }
            return vectors;
        }

        private Vector GetElementsFormGridView()
        {
            var matrix = new Vector((int)elementsCountNumericUpDown3.Value+1);
            for (int i = 0; i < (int)elementsCountNumericUpDown3.Value; i++)
            {
                matrix.Elements[i] = Int32.Parse((dataGridView1[i, 0].Value ?? 0).ToString());
            }
            matrix.Elements[(int)elementsCountNumericUpDown3.Value] = 1;
            return matrix;
        }

        private void getClassButton_Click(object sender, EventArgs e)
        {
            classTextBox.Text = "Данный вектор принадлежит " +
                                (persiptron.GetMaxVectorClass(functions, GetElementsFormGridView()) +
                                 1) + " классу";
        }

        private void classesCountNnumericUpDown_ValueChanged ( object sender, EventArgs e )
        {

        }
    }
}

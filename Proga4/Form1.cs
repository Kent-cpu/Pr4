using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Google.Apis.Sheets.v4;
using Google.Apis.Auth.OAuth2;
using System.IO;
using Google.Apis.Services;
using System.Diagnostics;
using ZedGraph;

namespace Proga4
{
    public partial class Form1 : Form
    {

        static SheetsService service;
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        private List<string> sortList = new List<string>();
        Stopwatch sortQuickTime = new Stopwatch();
        int timeWork;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }


        static void Swap(double[] array, int i, int j)
        {
            double temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }



        private void draw(ZedGraphControl zgc, List<Index> indexSort, double[] arrayForDraw)
        {
            new Thread(async () =>
            {
                GraphPane pane = zgc.GraphPane;
                Invoke((System.Action)(() =>
                {

                    pane.CurveList.Clear();
                    pane.Title.Text = "Sorting";
                    pane.BarSettings.MinClusterGap = 0.0F;

                    BarItem curve = pane.AddBar("Elements", null, arrayForDraw, Color.Blue);
                    zgc.AxisChange();

                    // update graph
                    zgc.Invalidate();
                }));


                for (int i = 0; i < indexSort.Count; ++i)
                {

                    await Task.Delay(timeWork);

                    Invoke((System.Action)(() =>
                    {
                        pane.CurveList.Clear();
                    }));

                    arrayForDraw[indexSort[i].startIndex] = indexSort[i].value1;
                    arrayForDraw[indexSort[i].newIndex] = indexSort[i].value2;
                    BarItem bar = pane.AddBar("Elements", null, arrayForDraw, Color.Blue);


                    Invoke((System.Action)(() =>
                    {
                        zgc.AxisChange();

                        zgc.Invalidate();
                    }));

                }

            }).Start();

        }



        private void getInfoSort(RichTextBox richTextBox, string time, double[] sortedData)
        {
            new Thread(() =>

               Invoke((System.Action)(() =>
                {
                       richTextBox.Text = "";
                       richTextBox.Text = "Время сортировки: " + time + "\n";
                       for (int i = 0; i < sortedData.Length; ++i)
                       {
                           richTextBox.Text += sortedData[i].ToString() + " ";
                       }
                   }))
               ).Start();
        }



        private void insertSort(double[] dataSort)
        {
            new Thread(() =>
            {
                double[] arrayForDraw = (double[])dataSort.Clone();
                List<Index> indexSort = new List<Index>();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                for (int i = 1; i < dataSort.Length; ++i)
                {
                    double x = dataSort[i];
                    int j = i;
                    while (j > 0 && (descendingSort.Checked ? dataSort[j - 1] < x : dataSort[j - 1] > x))
                    {
                        Index index = new Index(j, dataSort[j - 1], j - 1, dataSort[j]);
                        indexSort.Add(index);
                        Swap(dataSort, j, j - 1);
                        j--;
                    }
                    dataSort[j] = x;
                }
                stopwatch.Stop();
                getInfoSort(insertSortInfo, stopwatch.Elapsed.ToString(), dataSort);
                draw(insertSortSchedule, indexSort, arrayForDraw);
            }).Start();

        }

        private void bubbleSort(double[] dataSort) // дефолт по возрастанию
        {
            new Thread(() =>
            {
                double[] arrayForDraw = (double[])dataSort.Clone();
                List<Index> indexSort = new List<Index>();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();


                for (int i = 0; i < dataSort.Length; ++i)
                {
                    for (int j = 0; j < dataSort.Length - 1; ++j)
                    {
                        if (descendingSort.Checked ? dataSort[j] < dataSort[j + 1] : dataSort[j] > dataSort[j + 1])
                        {
                            Index index = new Index(j, dataSort[j + 1], j + 1, dataSort[j]);
                            indexSort.Add(index);
                            double dop = dataSort[j];
                            dataSort[j] = dataSort[j + 1];
                            dataSort[j + 1] = dop;
                        }
                    }
                }

                stopwatch.Stop();

                getInfoSort(bubbleSortInfo, stopwatch.Elapsed.ToString(), dataSort);
                draw(bubbleSortSchedule, indexSort, arrayForDraw);
            }).Start();

        }

        private void shakerSort(double[] dataSort)
        {
            new Thread(() =>
           {
               double[] arrayForDraw = (double[])dataSort.Clone();
               List<Index> indexSort = new List<Index>();
               Stopwatch stopwatch = new Stopwatch();
               stopwatch.Start();


               for (var i = 0; i < dataSort.Length / 2; ++i)
               {
                   var swapFlag = false;
                   //проход слева направо
                   for (var j = i; j < dataSort.Length - i - 1; ++j)
                   {
                       if (descendingSort.Checked ? dataSort[j] < dataSort[j + 1] : dataSort[j] > dataSort[j + 1])
                       {
                           Index index = new Index(j, dataSort[j + 1], j + 1, dataSort[j]);
                           indexSort.Add(index);
                           Swap(dataSort, j, j + 1);
                           swapFlag = true;
                       }
                   }

                   //проход справа налево
                   for (var j = dataSort.Length - 2 - i; j > i; --j)
                   {
                       if (descendingSort.Checked ? dataSort[j - 1] < dataSort[j] : dataSort[j - 1] > dataSort[j])
                       {
                           Index index = new Index(j - 1, dataSort[j], j, dataSort[j - 1]);
                           indexSort.Add(index);
                           Swap(dataSort, j - 1, j);
                           swapFlag = true;
                       }

                   }


                   //если обменов не было выходим
                   if (!swapFlag)
                   {
                       break;
                   }
               }

               stopwatch.Stop();

               getInfoSort(shakerSortInfo, stopwatch.Elapsed.ToString(), dataSort);
               draw(shakerSortSchedule, indexSort, arrayForDraw);


           }).Start();

        }

        int partition(double[] array, int start, int end, List<Index> indexPermutations)
        {
            double temp;
            int marker = start;
            for (int i = start; i < end; i++)
            {
                if (descendingSort.Checked ? array[i] > array[end] : array[i] < array[end])
                {
                    Index ind = new Index(marker, array[i], marker, array[i]);
                    indexPermutations.Add(ind);
                    temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }

            Index index = new Index(marker, array[end], end, array[marker]);
            indexPermutations.Add(index);
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }


        public double[] quickSort(double[] dataSort, int start, int end, List<Index> indexPermutations)
        {

            if (start >= end)
            {
                return dataSort;
            }
            int pivot = partition(dataSort, start, end, indexPermutations);
            quickSort(dataSort, start, pivot - 1, indexPermutations);
            quickSort(dataSort, pivot + 1, end, indexPermutations);

            return dataSort;
        }


        private bool IsSorted(double[] array) // Метод для проверки упорядоченности массива
        {
            for (int i = 0; i < array.Length - 1; ++i)
            {
                if (descendingSort.Checked ? array[i] < array[i + 1] : array[i] > array[i + 1])
                {
                    return false;
                }

            }
            return true;
        }
        private double[] Random(double[] array) // Метод для перемешивания элементов массива
        {
            Random random = new Random();
            for (int i = array.Length - 1; i >= 0; --i)
            {
                int j = random.Next(i); // Возвращение случайного числа
                double dop = array[i];
                array[i] = array[j];
                array[j] = dop;
            }
            return array;
        }
        private void BogoSort(double[] dataSort) // Сама сортировка
        {
            new Thread(async () =>
            {
                GraphPane pane = bogoSortShedule.GraphPane;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                while (!IsSorted(dataSort)) // Пока массив не упорядочен
                {
                    dataSort = Random(dataSort); // Меняем местами дальше

                    await Task.Run(() =>
                    {
                        Thread.Sleep(timeWork);


                        pane.CurveList.Clear();

                        pane.Title.Text = "Sorting";

                        pane.BarSettings.MinClusterGap = 0.0F; //set columns references

                        BarItem curve = pane.AddBar("Elements", null, dataSort, Color.Blue);
                        bogoSortShedule.AxisChange();

                        bogoSortShedule.Invalidate();
                    });

                }

                stopwatch.Stop();

                getInfoSort(bogoSortInfo, stopwatch.Elapsed.ToString(), dataSort);
            }).Start();

        }

        private void excelReadData_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Excel.Application ObjExcel = new Excel.Application();
                Workbook ObjWorkBook = null;
                string path = "";
                try
                {
                    Invoke((System.Action)(() =>
                    {
                        dataGridView1.Rows.Clear();
                        openFileDialog1.ShowDialog();
                    }));


                    path = openFileDialog1.FileName;

                    if (path != "")
                    {
                        ObjWorkBook = ObjExcel.Workbooks.Open(path);
                        Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[1];

                        Range xRange = ObjWorkSheet.UsedRange.Columns[1];

                        Array xCells = (Array)xRange.Cells.Value2;


                        string[] xColumn = xCells.OfType<object>().Select(o => o.ToString()).ToArray();


                        for (int i = 0; i < xColumn.Length; ++i)
                        {
                            Invoke((System.Action)(() =>
                            {
                                dataGridView1.Rows.Add(xColumn[i]);
                            }));

                        }
                        ObjWorkBook.Close(false, Type.Missing, Type.Missing);
                        ObjExcel.Quit();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ошибка при считывания данных");
                    if (ObjWorkBook != null)
                    {
                        ObjWorkBook.Close(false, Type.Missing, Type.Missing);
                    }

                    ObjExcel.Quit();
                }
            }).Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void googleSheetsReadData_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    if (linkGoogleTable.Text.Length > 0 && nameSheet.Text.Length > 0)
                    {
                        string SpreadsheetId = linkGoogleTable.Text.Substring(39, 44);
                        string nameCurrentSheet = nameSheet.Text;


                        Invoke((System.Action)(() =>
                        {
                            dataGridView1.Rows.Clear();
                        }));

                        GoogleCredential credential;
                        using (var stream = new FileStream("creds.json", FileMode.Open, FileAccess.Read))
                        {
                            credential = GoogleCredential.FromStream(stream)
                                .CreateScoped(Scopes);
                        }

                        service = new SheetsService(new BaseClientService.Initializer()
                        {
                            HttpClientInitializer = credential,
                        });

                        var range = $"{nameCurrentSheet}!A:A";
                        SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(SpreadsheetId, range);

                        var response = request.Execute();
                        IList<IList<object>> values = response.Values;

                        if (values != null && values.Count > 0)
                        {
                            foreach (var row in values)
                            {
                                Invoke((System.Action)(() =>
                                {
                                    dataGridView1.Rows.Add(row[0]);
                                }));
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите ссылку и названия листа");
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ошибка при считывании данных, проверьте ссылку и название листа");
                }
            }).Start();
        }

        private void addSortList(bool CheckElement, string nameSort)
        {
            if (CheckElement)
            {
                sortList.Add(nameSort);
            }
            else
            {
                sortList.Remove(nameSort);
            }
        }

        private void bubbleSortCheck_CheckedChanged(object sender, EventArgs e)
        {
            addSortList(bubbleSortCheck.Checked, "bubbleSort");
        }

        private void insertSortCheck_CheckedChanged(object sender, EventArgs e)
        {
            addSortList(insertSortCheck.Checked, "insertSort");
        }

        private void shakerSortCheck_CheckedChanged(object sender, EventArgs e)
        {
            addSortList(shakerSortCheck.Checked, "shakerSort");
        }

        private void quickSortCheck_CheckedChanged(object sender, EventArgs e)
        {
            addSortList(quickSortCheck.Checked, "quickSort");
        }

        private void bogoSortCheck_CheckedChanged(object sender, EventArgs e)
        {
            addSortList(bogoSortCheck.Checked, "bogoSort");
        }

        private bool validation()
        {

            if (sortList.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну сортировку");
                return false;
            }


            if (dataGridView1.Rows.Count <= 2)
            {
                MessageBox.Show("Отсутсвуют данные или их не достаточно");
                return false;
            }

            if (time.Text.Length == 0 || !int.TryParse(time.Text, out timeWork))
            {
                MessageBox.Show("Введите время или проверьте вводимые данные ");
                return false;
            }

            
            if (timeWork <= 0)
            {
                MessageBox.Show("Время должно быть больше нуля");
                return false;
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
            {
                double number = 0;
                if (!double.TryParse(dataGridView1[0, i].Value.ToString(), out number))
                {
                    MessageBox.Show("Некорректные данные");
                    return false;
                }
            }

            return true;
        }


        private double[] readData()
        {
            double[] data = new double[dataGridView1.Rows.Count - 1];


            for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
            {
                data[i] = Convert.ToDouble(dataGridView1[0, i].Value);
            }


            return data;
        }

        private void launchSort_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                if (validation())
                {
                    double[] data = readData();

                    for (int i = 0; i < sortList.Count; ++i)
                    {
                        if (sortList[i] == "insertSort")
                        {
                            insertSort((double[])data.Clone());
                        }

                        if (sortList[i] == "bubbleSort")
                        {
                            bubbleSort((double[])data.Clone());
                        }

                        if (sortList[i] == "shakerSort")
                        {
                            shakerSort((double[])data.Clone());
                        }

                        if (sortList[i] == "quickSort")
                        {
                            List<Index> indexSort = new List<Index>();
                            double[] cloneData = (double[])data.Clone();
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();
                            double[] x = quickSort(cloneData, 0, data.Length - 1, indexSort);
                            stopwatch.Stop();
                            getInfoSort(quickSortInfo, stopwatch.Elapsed.ToString(), x);
                            draw(quickSortShedule, indexSort, (double[])data.Clone());
                        }

                        if (sortList[i] == "bogoSort")
                        {
                            BogoSort((double[])data.Clone());
                        }
                    }

                }
            }).Start();

        }

        private void generateData_Click(object sender, EventArgs e)
        {
            int rowsGenerate = 0;
            dataGridView1.Rows.Clear();
            if (rowGenerateData.Text.Length != 0 && int.TryParse(rowGenerateData.Text, out rowsGenerate))
            {
                Random rnd = new Random();

                for (int i = 0; i < rowsGenerate; ++i)
                {
                    int value = rnd.Next();
                    dataGridView1.Rows.Add(value.ToString());
                }

            }
            else
            {
                MessageBox.Show("Введите количество строк для создания данных");
            }
        }

        private void exitApplication_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

public class Index
{
    public int startIndex;
    public int newIndex;
    public double value1;
    public double value2;

    public Index(int stIndex, double vl1, int nwIndex, double vl2)
    {
        startIndex = stIndex;
        newIndex = nwIndex;
        value1 = vl1;
        value2 = vl2;
    }
}

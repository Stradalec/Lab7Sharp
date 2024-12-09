using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;
using Flee.PublicTypes;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using MathNet.Numerics.LinearAlgebra.Solvers;
using System.Diagnostics;
using NPOI.SS.Formula.Functions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Sockets;
using NPOI.HPSF;
using System.Windows.Navigation;
using System.Windows.Media.Media3D;
using ICSharpCode.SharpZipLib.Core;
using System.Diagnostics.Metrics;
using Org.BouncyCastle.Asn1.Cmp;


namespace Lab1
{
    interface IView
    {
        string returnFunction();
        double lowLimit();
        double upLimit();
        double Interval();
        double firstSide();
        double secondSide();
        double epsilon();

        byte Choice();
        void UpdateGraph(List<double[]> inputArr);
        double iterationCount();
        bool MinimumOrMaximum();
        void ShowGraph(PlotModel plotModel);
        void ShowResult(double input, double errorCheck);

        event EventHandler<EventArgs> StartDichotomy;
        event EventHandler<EventArgs> CreateGraph;
        event EventHandler<EventArgs> StartGoldenRatio;
        event EventHandler<EventArgs> StartNewton;
        event EventHandler<EventArgs> StartDescent;
    }

    interface ISortView
    {
        byte StartInput();

        int ArraySizeToRandom();

        int leftInterval();
        int rightInterval();
        string PathToFile();

        bool IsDouble();
        bool IsActiveBubble();
        bool IsActiveInserts();
        bool IsActiveFast();
        bool IsActiveShake();

        bool IsActiveSwamp();

        double SwampsIterations();

        void UpdateProgress(int progress);
        void ChooseInput(double[] inputArray);
        void ShowSortResult(string[] methodName, int[] methodIterations, double[] methodTime, List<double[]> sortedArrays);
        bool IsIncreasing();

        double[] NumbersToSort();
        event EventHandler<EventArgs> AddData;
        event EventHandler<EventArgs> Sort;
    }

    interface IIntegralView
    {

        double Interval();
        string returnFunction();
        double lowLimit();
        double upLimit();

        double Accuracy();

        int IntegralIntervalCount();

        bool IsRectangleActive();

        bool IsTrapezoidActive();

        bool IsSimpsonActive();

        void UpdateGraph(List<double[]> inputArr, byte choice);
        void ShowGraph(PlotModel plotModel);

        void ShowResult(double[] inputArray);

        void ReverseResult(int countOfIterations);


        event EventHandler<EventArgs> CreateIntegralGraph;
        event EventHandler<EventArgs> Calculate;
        event EventHandler<EventArgs> ReverseMode;
    }

    interface IAlgebraicView 
    {
        double[,] GetMatrix();

        double[] GetVector();

        void ShowResult(double[] result);

        event EventHandler<EventArgs> StartGauss;
        event EventHandler<EventArgs> StartJordanoGauss;
        event EventHandler<EventArgs> StartCramer;
    }

    // Модель. Основная часть работы программы происходит здесь
    class Model
    {
        private int fastIterations;


        public PlotModel CreateGraph(double interval, double downLimitation, double upLimitation, string function)
        {
            double limit = Convert.ToDouble(interval);
            double functionLimit = Convert.ToDouble(downLimitation);
            double upFunctionLimit = Convert.ToDouble(upLimitation);
            List<DataPoint> dot = new List<DataPoint>();

            var plotModel = new PlotModel { Title = "График функции f(x)" };

            var dataPoints = new List<double> { 0 };


            var absicc = new LineSeries {
                Title = "Абсцисс",
                Color = OxyColor.FromRgb(255, 0, 0), // Красный цвет
                StrokeThickness = 2
            };

            absicc.Points.Add(new DataPoint(-limit, 0));
            absicc.Points.Add(new DataPoint(limit, 0));

            var ordinate = new LineSeries {
                Title = "Ординат",
                Color = OxyColor.FromRgb(255, 0, 0), // Красный цвет
                StrokeThickness = 2,
            };

            ordinate.Points.Add(new DataPoint(0, limit));
            ordinate.Points.Add(new DataPoint(0, -limit));

            // Создаем серию точек графика
            var lineSeries = new LineSeries {
                Title = "f(x)",
                Color = OxyColor.FromRgb(0, 0, 255) // Синий цвет линии
            };

            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));


            int lowIndex = Convert.ToInt32(functionLimit);
            int upIndex = Convert.ToInt32(upFunctionLimit);
            for (double counterI = -lowIndex; counterI <= upIndex; ++counterI)
            {
                context.Variables["x"] = counterI;
                var expression = context.CompileGeneric<double>(function);

                double y = expression.Evaluate();
                lineSeries.Points.Add(new DataPoint(counterI, y));


            }

            // Добавляем все точки в серию
            lineSeries.Points.AddRange(dot);

            // Добавляем серию точек к модели графика
            plotModel.Series.Add(lineSeries);
            plotModel.Series.Add(ordinate);
            plotModel.Series.Add(absicc);

            return plotModel;
        }

        public (double, double) Dichotomy(string inputFunction, double leftLimitation, double rightLimitation, double epsilon)
        {
            double result = double.NaN;
            double currentResult = 0;
            double errorCheck = 0;
            double first = 0;
            double second = 0;

            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));

            while ((rightLimitation - leftLimitation) >= epsilon)
            {
                currentResult = (leftLimitation + rightLimitation) / 2;
                context.Variables["x"] = currentResult;
                var expression = context.CompileGeneric<double>(inputFunction);
                double position = expression.Evaluate();

                context.Variables["x"] = leftLimitation;
                expression = context.CompileGeneric<double>(inputFunction);
                var leftY = expression.Evaluate();
                first = leftY;

                context.Variables["x"] = rightLimitation;
                expression = context.CompileGeneric<double>(inputFunction);
                var rightY = expression.Evaluate();
                second = rightY;

                if (Math.Abs(position) == 0) // Найден точный корень
                {
                    result = currentResult;
                    return (result, errorCheck);
                }
                else if (leftY * position < 0) // Корень в левой половине интервала
                {
                    rightLimitation = currentResult;
                }
                else // Корень в правой половине интервала
                {
                    leftLimitation = currentResult;
                }
            }

            result = currentResult;

            if (first * second > 0)
            {
                errorCheck = 1;
            }
            else
            {
                errorCheck = 0;
            }

            return (result, errorCheck);
        }

        public (double, double) GoldenRatio(string inputExpression, double leftLimitation, double rightLimitation, double epsilon, bool choice = true)
        {
            double result = double.NaN;
            double functionResult = 0;
            double goldenRatio = (Math.Sqrt(5) + 1) / 2;
            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));
            if (!choice)
            {
                inputExpression = "-(" + inputExpression + ")";
            }

            double xFirst = rightLimitation - (rightLimitation - leftLimitation) / goldenRatio;
            double xSecond = leftLimitation + (rightLimitation - leftLimitation) / goldenRatio;
            double resultFirst = 0;
            double resultSecond = 0;


            while (Math.Abs(rightLimitation - leftLimitation) > epsilon)
            {
                context.Variables["x"] = xFirst;
                var expression = context.CompileGeneric<double>(inputExpression);
                resultFirst = expression.Evaluate();

                context.Variables["x"] = xSecond;
                expression = context.CompileGeneric<double>(inputExpression);
                resultSecond = expression.Evaluate();

                if (resultFirst < resultSecond)
                {
                    rightLimitation = xSecond;
                    xSecond = xFirst;
                    xFirst = rightLimitation - (rightLimitation - leftLimitation) / goldenRatio;
                }
                else
                {
                    leftLimitation = xFirst;
                    xFirst = xSecond;
                    xSecond = leftLimitation + (rightLimitation - leftLimitation) / goldenRatio;
                }
            }
            result = (leftLimitation + rightLimitation) / 2;
            context.Variables["x"] = result;
            var resultExpression = context.CompileGeneric<double>(inputExpression);
            functionResult = resultExpression.Evaluate();

            return (result, functionResult);
        }


        public (double, double, List<double[]>) Newton(string inputFunction, double inputApproximation, double epsilon, double step, double iterationCount, byte inputChoice)
        {
            double result = 0;
            double functionResult = 0;
            double current = inputApproximation;
            double next = 0;
            double derivative = 0;
            double secondDerivative = 0;
            byte choice = 1;
            List<double[]> array = new List<double[]>();
            double leftDerivative = 0;
            double rightDerivative = 0;
            choice = inputChoice;
            int innerCount = 0;

            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));
            context.Variables["x"] = current;
            var expression = context.CompileGeneric<double>(inputFunction);
            for (int iteration = 0; iteration < iterationCount; ++iteration)
            {
                switch (choice)
                {
                    case 1:
                        context.Variables["x"] = current;
                        double function = expression.Evaluate(); //Значение функции в x
                        derivative = NumericalDerivative(context, expression, current, step); //Численная производная

                        // Проверка на ноль
                        if (Math.Abs(derivative) < 1e-10)
                        {
                            return (double.NaN, double.NaN, array);
                        }
                        next = current - function / derivative;
                        context.Variables["x"] = next;
                        array.Add(new double[] { next, expression.Evaluate() });

                        if (Math.Abs(next - current) < epsilon)
                        {
                            result = next;
                            context.Variables["x"] = result;
                            expression = context.CompileGeneric<double>(inputFunction);
                            functionResult = expression.Evaluate();
                            break;
                        }

                        current = next;
                        ++innerCount;
                        break;
                    case 2:
                        context.Variables["x"] = current;
                        derivative = NumericalDerivative(context, expression, current, step); //Численная производная
                        secondDerivative = NumericalSecondDerivative(context, expression, current, step);

                        if (Math.Abs(secondDerivative) < 1e-10)
                        {
                            iteration = Convert.ToInt32(iterationCount);
                            return (double.NaN, 0, array);
                        }

                        next = current - derivative / secondDerivative;
                        context.Variables["x"] = next;
                        array.Add(new double[] { next, expression.Evaluate() });
                        leftDerivative = NumericalDerivative(context, expression, current - step, step);
                        rightDerivative = NumericalDerivative(context, expression, current + step, step);

                        if (Math.Abs(derivative) < epsilon && leftDerivative < 0 && rightDerivative > 0)
                        {
                            result = current;
                            context.Variables["x"] = result;
                            expression = context.CompileGeneric<double>(inputFunction);
                            functionResult = expression.Evaluate();
                            break;
                        }
                        else if (Math.Abs(derivative) < epsilon)
                        {
                            return (0, double.NaN, array);
                        }

                        ++innerCount;
                        current = next;


                        break;
                    case 3:
                        context.Variables["x"] = current;
                        derivative = NumericalDerivative(context, expression, current, step); //Численная производная
                        secondDerivative = NumericalSecondDerivative(context, expression, current, step);

                        if (Math.Abs(secondDerivative) < 1e-10)
                        {
                            iteration = Convert.ToInt32(iterationCount);
                            return (double.NaN, 0, array);
                        }

                        next = current - derivative / secondDerivative;
                        context.Variables["x"] = next;
                        array.Add(new double[] { next, expression.Evaluate() });
                        leftDerivative = NumericalDerivative(context, expression, current - step, step);
                        rightDerivative = NumericalDerivative(context, expression, current + step, step);

                        if (Math.Abs(derivative) < epsilon && leftDerivative > 0 && rightDerivative < 0)
                        {
                            result = current;
                            context.Variables["x"] = result;
                            expression = context.CompileGeneric<double>(inputFunction);
                            functionResult = expression.Evaluate();
                            break;
                        }
                        else if (Math.Abs(derivative) < epsilon)
                        {
                            return (0, double.NaN, array);
                        }

                        ++innerCount;
                        current = next;


                        break;
                    default:
                        break;
                }
                if (innerCount >= iterationCount && (result == 0 && functionResult == 0))
                {
                    return (double.NaN, double.NaN, array);
                }
            }

            return (result, functionResult, array);
        }

        public (double, double) Descent(string inputFunction, double inputApproximation, double epsilon, double step, double iterationCount, byte inputChoice, bool isWideAllowed)
        {
            double result = double.NaN;
            double functionResult = double.NaN;
            double startX = inputApproximation;
            double stepSize = step;
            double descentX = 0;
            double wideStep = 1;
            double safety = 0;

            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));
            context.Variables["x"] = startX;
            var expression = context.CompileGeneric<double>(inputFunction);
            double lowWideStep = inputApproximation - wideStep;
            double upWideStep = inputApproximation + wideStep;
            double leftWideDerivative = NumericalDerivative(context, expression, startX - wideStep, step);
            double rightWideDerivative = NumericalDerivative(context, expression, startX + wideStep, step);
            if (isWideAllowed)
            {
                do
                {
                    context.Variables["x"] = startX;
                    double wideValueOfFunction = expression.Evaluate();
                    context.Variables["x"] = lowWideStep;
                    double lowWideValueOfFunction = expression.Evaluate();
                    context.Variables["x"] = upWideStep;
                    double upWideValueOfFunction = expression.Evaluate();
                    switch (inputChoice)
                    {
                        case 2:
                            if (lowWideValueOfFunction < upWideValueOfFunction)
                            {
                                startX -= wideStep;
                            }
                            else if (lowWideValueOfFunction > upWideValueOfFunction)
                            {
                                startX += wideStep;
                            }
                            lowWideStep = startX - wideStep;
                            upWideStep = startX + wideStep;
                            break;
                        case 3:
                            if (lowWideValueOfFunction > upWideValueOfFunction)
                            {
                                startX -= wideStep;
                            }
                            else if (lowWideValueOfFunction < upWideValueOfFunction)
                            {
                                startX += wideStep;
                            }
                            lowWideStep = startX - wideStep;
                            upWideStep = startX + wideStep;
                            break;
                    }
                    leftWideDerivative = NumericalDerivative(context, expression, startX - wideStep, step);
                    rightWideDerivative = NumericalDerivative(context, expression, startX + wideStep, step);
                    ++safety;
                } while (leftWideDerivative * rightWideDerivative > 0 && safety < iterationCount);
            }


            if (safety == iterationCount)
            {
                startX = inputApproximation;
            }

            for (int iterationIndex = 0; iterationIndex < iterationCount; ++iterationIndex)
            {
                double currentX = startX;

                context.Variables["x"] = currentX;
                expression = context.CompileGeneric<double>(inputFunction);
                double valueOfFunction = expression.Evaluate();
                descentX = startX - stepSize;
                context.Variables["x"] = descentX;
                expression = context.CompileGeneric<double>(inputFunction);
                double valueOfLowerX = expression.Evaluate();
                descentX = startX + stepSize;
                context.Variables["x"] = descentX;
                expression = context.CompileGeneric<double>(inputFunction);
                double valueOfUpperX = expression.Evaluate();

                context.Variables["x"] = descentX;
                double innerValueOfFunction = expression.Evaluate();

                switch (inputChoice)
                {
                    case 2:
                        if (valueOfLowerX < valueOfUpperX)
                        {
                            currentX -= stepSize;
                        }
                        else if (valueOfLowerX > valueOfUpperX)
                        {
                            currentX += stepSize;
                        }

                        break;
                    case 3:
                        if (valueOfLowerX > valueOfUpperX)
                        {
                            currentX -= stepSize;
                        }
                        else if (valueOfLowerX < valueOfUpperX)
                        {
                            currentX += stepSize;
                        }

                        break;
                }


                startX = currentX;
                double leftDerivative = NumericalDerivative(context, expression, currentX - step, step);
                double rightDerivative = NumericalDerivative(context, expression, currentX + step, step);
                if ((Math.Abs(valueOfLowerX - valueOfFunction) < epsilon || Math.Abs(valueOfUpperX - valueOfFunction) < epsilon) && (leftDerivative * rightDerivative < 0))
                {
                    result = currentX;
                    context.Variables["x"] = result;
                    functionResult = expression.Evaluate();
                    break;
                }

            }
            return (result, functionResult);
        }

        double NumericalDerivative(ExpressionContext context, IGenericExpression<double> expression, double x, double step)
        {
            double h = step;
            context.Variables["x"] = x + h;
            double fxPlusH = expression.Evaluate();
            context.Variables["x"] = x - h;
            double fxMinusH = expression.Evaluate();
            return (fxPlusH - fxMinusH) / (2 * h); //Центральная разность (метод нахождения 1 производной)
        }

        double NumericalSecondDerivative(ExpressionContext context, IGenericExpression<double> expression, double x, double step)
        {
            double h = step;
            context.Variables["x"] = x + h;
            double fxPlusH = expression.Evaluate();
            context.Variables["x"] = x - h;
            double fxMinusH = expression.Evaluate();
            context.Variables["x"] = x;
            double fxOriginal = expression.Evaluate();
            return (fxPlusH - 2 * fxOriginal + fxMinusH) / (h * h); //Центральная разность (метод нахождения 2 производной)
        }


        public double[] ChooseInput(byte inputChoice, string pathToFile, int leftLimit, int rightLimit, bool IsNeedToDouble, int arraySize = 10)
        {
            double[] numbers = new double[arraySize];
            switch (inputChoice)
            {
                case 1:
                    numbers[0] = double.NaN;
                    return numbers;

                case 2:
                    Random random = new Random();
                    for (int randomIndex = 0; randomIndex < arraySize; ++randomIndex)
                    {
                        if (IsNeedToDouble)
                        {
                            numbers[randomIndex] = random.Next(-leftLimit, rightLimit) + random.NextDouble();
                        }
                        else
                        {
                            numbers[randomIndex] = random.Next(-leftLimit, rightLimit);
                        }

                    }
                    return numbers;

                case 3:
                    if (pathToFile != "temporary")
                    {
                        if (pathToFile.Contains("xlsx"))
                        {
                            using (FileStream file = new FileStream(pathToFile, FileMode.Open, FileAccess.Read))
                            {
                                IWorkbook workbook = new XSSFWorkbook(file);
                                ISheet sheet = workbook.GetSheetAt(0);
                                numbers = new double[sheet.LastRowNum + 1];

                                for (int excelIndex = 0; excelIndex <= sheet.LastRowNum; ++excelIndex)
                                {
                                    IRow currentrow = sheet.GetRow(excelIndex);
                                    if (currentrow != null)
                                    {
                                        ICell cell = currentrow.GetCell(0);
                                        if (cell != null)
                                        {
                                            numbers[excelIndex] = cell.NumericCellValue;
                                        }
                                    }

                                }
                            }
                        }
                        else if (pathToFile.Contains("txt"))
                        {
                            string[] lines = File.ReadAllLines(pathToFile);
                            numbers = new double[lines.Length];
                            for (int inputIndex = 0; inputIndex < lines.Length; ++inputIndex)
                            {
                                numbers[inputIndex] = Convert.ToDouble(lines[inputIndex]);
                            }
                        }

                    }
                    return numbers;

                default:
                    int size = 100000;
                    numbers = new double[size];
                    Random test = new Random();
                    for (int randomIndex = 0; randomIndex < size; ++randomIndex)
                    {
                        numbers[randomIndex] = test.Next(int.MinValue, int.MaxValue) + test.NextDouble();
                    }
                    return numbers;
            }
        }

        public (string[], int[], double[], List<double[]>) Sorting(bool isBubbleActive, bool isInsertsActive, bool isFastActive, bool isShakeActive, bool isSwampActive, double swampIterations, double[] arrayToSort, bool isIncreasingSort)
        {
            string[] namesOfMethods = new string[5];
            int[] iterationsOfMethods = new int[5];
            double[] timeOfMethods = new double[5];
            List<double[]> sortedArrays = new List<double[]>();
            double[] array = new double[arrayToSort.Length];
            MakeNewMassive(arrayToSort, array);
            if (isBubbleActive)
            {
                var output = BubbleSort(array, isIncreasingSort);
                namesOfMethods[0] = output.Item1;
                iterationsOfMethods[0] = output.Item2;
                timeOfMethods[0] = output.Item3;
                MakeNewMassive(output.Item4, array);
                sortedArrays.Add(array.ToArray());
            }
            MakeNewMassive(arrayToSort, array);
            if (isInsertsActive)
            {
                var output = InsertsSort(array, isIncreasingSort);
                namesOfMethods[1] = output.Item1;
                iterationsOfMethods[1] = output.Item2;
                timeOfMethods[1] = output.Item3;
                MakeNewMassive(output.Item4, array);
                sortedArrays.Add(array.ToArray());
            }
            MakeNewMassive(arrayToSort, array);
            if (isFastActive)
            {
                namesOfMethods[2] = "Быстрая сортировка";
                var output = FastSort(array, isIncreasingSort);
                iterationsOfMethods[2] = output.Item1;
                timeOfMethods[2] = output.Item2;
                MakeNewMassive(output.Item3, array);
                sortedArrays.Add(array.ToArray());
            }
            MakeNewMassive(arrayToSort, array);
            if (isShakeActive)
            {
                var output = ShakeSort(array, isIncreasingSort);
                namesOfMethods[3] = output.Item1;
                iterationsOfMethods[3] = output.Item2;
                timeOfMethods[3] = output.Item3;
                MakeNewMassive(output.Item4, array);
                sortedArrays.Add(array.ToArray());
            }
            MakeNewMassive(arrayToSort, array);
            if (isSwampActive)
            {
                var output = SwampSort(array, isIncreasingSort, Convert.ToInt32(swampIterations));
                namesOfMethods[4] = output.Item1;
                iterationsOfMethods[4] = output.Item2;
                timeOfMethods[4] = output.Item3;
                MakeNewMassive(output.Item4, array);
                sortedArrays.Add(array.ToArray());
            }
            return (namesOfMethods, iterationsOfMethods, timeOfMethods, sortedArrays);
        }

        private (string, int, double, double[]) BubbleSort(double[] arrayToSort, bool isIncreasingSort)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            string namesOfBubble = "Сортировка пузырьком";
            int iterationsOfBubble = 0;
            double timeOfBubble = 0;
            if (isIncreasingSort)
            {

                do
                {
                    for (int sortIndex = 0; sortIndex < arrayToSort.Length - 1; ++sortIndex)
                    {

                        if (arrayToSort[sortIndex] > arrayToSort[sortIndex + 1])
                        {
                            double temp = arrayToSort[sortIndex];
                            arrayToSort[sortIndex] = arrayToSort[sortIndex + 1];
                            arrayToSort[sortIndex + 1] = temp;
                        }

                    }
                    ++iterationsOfBubble;
                } while (!isSorted(arrayToSort, isIncreasingSort));

            }
            else
            {
                do
                {
                    for (int sortIndex = 0; sortIndex < arrayToSort.Length - 1; ++sortIndex)
                    {

                        if (arrayToSort[sortIndex] < arrayToSort[sortIndex + 1])
                        {
                            double temp = arrayToSort[sortIndex];
                            arrayToSort[sortIndex] = arrayToSort[sortIndex + 1];
                            arrayToSort[sortIndex + 1] = temp;
                        }

                    }
                    ++iterationsOfBubble;
                } while (!isSorted(arrayToSort, isIncreasingSort));
            }

            timer.Stop();
            timeOfBubble = timer.Elapsed.TotalSeconds;
            return (namesOfBubble, iterationsOfBubble, timeOfBubble, arrayToSort);
        }

        private (string, int, double, double[]) InsertsSort(double[] arrayToSort, bool isIncreasingSort)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            string namesOfInserts = "Сортировка вставками";
            int iterationsOfInserts = 0;
            double timeOfInserts = 0;
            if (isIncreasingSort)
            {
                for (int index = 1; index < arrayToSort.Length; ++index)
                {
                    double key = arrayToSort[index];
                    int temp = index - 1;
                    while (temp >= 0 && arrayToSort[temp] > key)
                    {
                        arrayToSort[temp + 1] = arrayToSort[temp];
                        --temp;
                    }

                    arrayToSort[temp + 1] = key;
                    ++iterationsOfInserts;
                }

            }
            else
            {
                for (int index = 1; index < arrayToSort.Length; ++index)
                {
                    double key = arrayToSort[index];
                    int temp = index - 1;
                    while (temp >= 0 && arrayToSort[temp] < key)
                    {
                        arrayToSort[temp + 1] = arrayToSort[temp];
                        --temp;
                    }

                    arrayToSort[temp + 1] = key;
                    ++iterationsOfInserts;
                }
            }

            timer.Stop();
            timeOfInserts = timer.Elapsed.TotalSeconds;
            return (namesOfInserts, iterationsOfInserts, timeOfInserts, arrayToSort);
        }


        private (int, double, double[]) FastSort(double[] arrayToSort, bool isIncreasingSort)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            double timeOfFast;
            fastIterations = 0;
            Sort(arrayToSort, isIncreasingSort, 0, arrayToSort.Length - 1);
            timer.Stop();
            timeOfFast = timer.Elapsed.TotalSeconds;
            return (fastIterations, timeOfFast, arrayToSort);
        }

        private void Sort(double[] array, bool isIncreasingSort, int lowIndex, int upIndex)
        {
            if (lowIndex < upIndex)
            {
                int pivotIndex = Partition(array, isIncreasingSort, lowIndex, upIndex);

                Sort(array, isIncreasingSort, lowIndex, pivotIndex - 1);
                Sort(array, isIncreasingSort, pivotIndex + 1, upIndex);
            }
            ++fastIterations;
        }
        private static int Partition(double[] array, bool isIncreasingSort, int left, int right)
        {
            double pivot = array[right];
            int index = left - 1;

            for (int sortIndex = left; sortIndex < right; ++sortIndex)
            {
                if (isIncreasingSort ? array[sortIndex] <= pivot : array[sortIndex] >= pivot)
                {
                    ++index;
                    double numberOne = array[index];
                    double numberTwo = array[sortIndex];

                    array[index] = numberTwo;
                    array[sortIndex] = numberOne;
                }
            }
            double tempOne = array[index + 1];
            double tempTwo = array[right];

            array[index + 1] = tempTwo;
            array[right] = tempOne;

            return index + 1;
        }

        private (string, int, double, double[]) ShakeSort(double[] arrayToSort, bool isIncreasingSort)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            string namesOfShake = "Шейкерная сортировка";
            int iterationsOfShake = 0;
            double timeOfShake = 0;
            if (isIncreasingSort)
            {
                do
                {

                    for (int sortIndex = 0; sortIndex < arrayToSort.Length - 1; ++sortIndex)
                    {

                        if (arrayToSort[sortIndex] > arrayToSort[sortIndex + 1])
                        {
                            double temp = arrayToSort[sortIndex];
                            arrayToSort[sortIndex] = arrayToSort[sortIndex + 1];
                            arrayToSort[sortIndex + 1] = temp;

                        }

                    }

                    for (int ReverseSortIndex = arrayToSort.Length - 1; ReverseSortIndex > 0; --ReverseSortIndex)
                    {

                        if (arrayToSort[ReverseSortIndex - 1] > arrayToSort[ReverseSortIndex])
                        {
                            double temp = arrayToSort[ReverseSortIndex - 1];
                            arrayToSort[ReverseSortIndex - 1] = arrayToSort[ReverseSortIndex];
                            arrayToSort[ReverseSortIndex] = temp;

                        }

                    }
                    ++iterationsOfShake;
                } while (!isSorted(arrayToSort, isIncreasingSort));
            }
            else
            {
                do
                {

                    for (int sortIndex = 0; sortIndex < arrayToSort.Length - 1; ++sortIndex)
                    {

                        if (arrayToSort[sortIndex] < arrayToSort[sortIndex + 1])
                        {
                            double temp = arrayToSort[sortIndex];
                            arrayToSort[sortIndex] = arrayToSort[sortIndex + 1];
                            arrayToSort[sortIndex + 1] = temp;

                        }

                    }

                    for (int ReverseSortIndex = arrayToSort.Length - 1; ReverseSortIndex > 0; --ReverseSortIndex)
                    {

                        if (arrayToSort[ReverseSortIndex - 1] < arrayToSort[ReverseSortIndex])
                        {
                            double temp = arrayToSort[ReverseSortIndex - 1];
                            arrayToSort[ReverseSortIndex - 1] = arrayToSort[ReverseSortIndex];
                            arrayToSort[ReverseSortIndex] = temp;

                        }

                    }
                    ++iterationsOfShake;
                } while (!isSorted(arrayToSort, isIncreasingSort));
            }

            timer.Stop();
            timeOfShake = timer.Elapsed.TotalSeconds;
            return (namesOfShake, iterationsOfShake, timeOfShake, arrayToSort);
        }

        private (string, int, double, double[]) SwampSort(double[] arrayToSort, bool isIncreasingSort, int swampIterations)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            string namesOfSwamp = "Болотная сортировка";
            int iterationsOfSwamp = 0;
            double timeOfSwamp = 0;
            while (!isSorted(arrayToSort, isIncreasingSort) && iterationsOfSwamp < swampIterations)
            {

                Random generator = new Random();

                for (int index = 0; index < arrayToSort.Length; ++index)
                {

                    int randomPosition = generator.Next(arrayToSort.Length);
                    double tempVariable = arrayToSort[index];
                    arrayToSort[index] = arrayToSort[randomPosition];
                    arrayToSort[randomPosition] = tempVariable;

                }
                ++iterationsOfSwamp;
            };

            timer.Stop();
            timeOfSwamp = timer.Elapsed.TotalSeconds;
            return (namesOfSwamp, iterationsOfSwamp, timeOfSwamp, arrayToSort);
        }

        private bool isSorted(double[] data, bool isIncreasing)
        {
            bool sorted = true;
            if (isIncreasing)
            {
                for (int index = 1; index < data.Length; ++index)
                {
                    if (data[index] < data[index - 1])
                    {
                        sorted = false;
                    }
                }
            }
            else
            {
                for (int index = 1; index < data.Length; ++index)
                {
                    if (data[index] > data[index - 1])
                    {
                        sorted = false;
                    }
                }
            }
            return sorted;

        }

        private double[] MakeNewMassive(double[] data, double[] output)
        {
            for (int index = 0; index < data.Length; ++index)
            {
                output[index] = data[index];
            }
            return output;
        }

        private int FindStartPoint(double[] arrayToSort, bool isIncreasingSort, int lowIndex, int upIndex)
        {
            double pivot = arrayToSort[upIndex];
            int temp = (lowIndex - 1);
            for (int pivotIndex = 0; pivotIndex < upIndex; ++pivotIndex)
            {
                if (arrayToSort[pivotIndex] < pivot)
                {
                    ++temp;
                }

                double otherTemp = arrayToSort[temp];
                arrayToSort[temp + 1] = arrayToSort[upIndex];
                arrayToSort[upIndex] = otherTemp;
            }
            return temp + 1;
        }

        public PlotModel CreateIntegralGraph(double interval, double downLimitation, double upLimitation, string function)
        {
            double limit = Convert.ToDouble(interval);
            double functionLimit = Convert.ToDouble(downLimitation);
            double upFunctionLimit = Convert.ToDouble(upLimitation);
            List<DataPoint> dot = new List<DataPoint>();

            var plotModel = new PlotModel { Title = "График интеграла f(x)" };


            var dataPoints = new List<double> { 0 };


            var absicc = new LineSeries {
                Title = "Абсцисс",
                Color = OxyColor.FromRgb(255, 0, 0), // Красный цвет
                StrokeThickness = 2
            };

            absicc.Points.Add(new DataPoint(-limit, 0));
            absicc.Points.Add(new DataPoint(limit, 0));

            var ordinate = new LineSeries {
                Title = "Ординат",
                Color = OxyColor.FromRgb(255, 0, 0), // Красный цвет
                StrokeThickness = 2,
            };

            ordinate.Points.Add(new DataPoint(0, limit));
            ordinate.Points.Add(new DataPoint(0, -limit));

            // Создаем серию точек графика
            var lineSeries = new AreaSeries {
                Title = " Интеграл f(x)",
                Color = OxyColor.FromRgb(0, 0, 255) // Синий цвет линии
            };

            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));


            int lowIndex = Convert.ToInt32(functionLimit);
            int upIndex = Convert.ToInt32(upFunctionLimit);
            for (double counterI = lowIndex; counterI <= upIndex; counterI += 0.1)
            {
                context.Variables["x"] = counterI;
                var expression = context.CompileGeneric<double>(function);

                double y = expression.Evaluate();
                lineSeries.Points.Add(new DataPoint(counterI, y));
            }

            // Добавляем все точки в серию
            lineSeries.Points.AddRange(dot);
            lineSeries.Fill = OxyColors.LightBlue;

            // Добавляем серию точек к модели графика
            plotModel.Series.Add(lineSeries);
            plotModel.Series.Add(ordinate);
            plotModel.Series.Add(absicc);

            return plotModel;
        }

        public (double[], List<double[]>, List<double[]>, List<double[]>) CalculateIntegral(string function, double lowBorder, double upBorder, int iterationsCount, bool isRectangleActive, bool isTrapezoidActive, bool isSimpsonActive)
        {
            double[] resultArray = new double[3];
            List<double[]> rectangleList = new List<double[]>();
            List<double[]> trapezoidList = new List<double[]>();
            List<double[]> SimpsonList = new List<double[]>();
            if (isRectangleActive)
            {
                var output = rectangleMethod(function, lowBorder, upBorder, iterationsCount);
                resultArray[0] = output.Item1;
                rectangleList = output.Item2;
            }
            if (isTrapezoidActive)
            {
                var output = trapezoidMethod(function, lowBorder, upBorder, iterationsCount);
                resultArray[1] = output.Item1;
                trapezoidList = output.Item2;
            }
            if (isSimpsonActive)
            {
                var output = SimpsonMethod(function, lowBorder, upBorder, iterationsCount);
                resultArray[2] = output.Item1;
                SimpsonList = output.Item2;
            }



            return (resultArray, rectangleList, trapezoidList, SimpsonList);
        }

        public int ReverseIntegral(string function, double lowBorder, double upBorder, double accuracy)
        {
            int result = 2;
            int bigStep = 100;
            int returnStep = 1;
            double[] methodResults = new double[3];
            bool IsWorking = true;
            while (IsWorking)
            {
                var output = rectangleMethod(function, lowBorder, upBorder, result);
                methodResults[0] = output.Item1;
                output = trapezoidMethod(function, lowBorder, upBorder, result);
                methodResults[1] = output.Item1;
                output = SimpsonMethod(function, lowBorder, upBorder, result);
                methodResults[2] = output.Item1;
                methodResults[0] = Math.Truncate(methodResults[0] * Math.Pow(10, accuracy)) / Math.Pow(10, accuracy);
                methodResults[1] = Math.Truncate(methodResults[1] * Math.Pow(10, accuracy)) / Math.Pow(10, accuracy);
                methodResults[2] = Math.Truncate(methodResults[2] * Math.Pow(10, accuracy)) / Math.Pow(10, accuracy);
                if (methodResults[0] == methodResults[1] && methodResults[0] == methodResults[2] && methodResults[1] == methodResults[2])
                {
                    IsWorking = false;
                }
                else
                {

                    result += bigStep;

                }

            }

            IsWorking = true;
            while (IsWorking)
            {
                var output = rectangleMethod(function, lowBorder, upBorder, result);
                methodResults[0] = output.Item1;
                output = trapezoidMethod(function, lowBorder, upBorder, result);
                methodResults[1] = output.Item1;
                output = SimpsonMethod(function, lowBorder, upBorder, result);
                methodResults[2] = output.Item1;
                methodResults[0] = Math.Truncate(methodResults[0] * Math.Pow(10, accuracy)) / Math.Pow(10, accuracy);
                methodResults[1] = Math.Truncate(methodResults[1] * Math.Pow(10, accuracy)) / Math.Pow(10, accuracy);
                methodResults[2] = Math.Truncate(methodResults[2] * Math.Pow(10, accuracy)) / Math.Pow(10, accuracy);
                if (methodResults[0] != methodResults[1] || methodResults[0] != methodResults[2] || methodResults[1] != methodResults[2])
                {
                    IsWorking = false;
                }
                else
                {

                    result -= returnStep;

                }

            }
            ++result;

            return result;
        }

        private (double, List<double[]>) rectangleMethod(string function, double lowBorder, double upBorder, int intervalCount)
        {
            double result = 0;
            double smallIntegralWidth = (upBorder - lowBorder) / intervalCount;
            double previousX = lowBorder;
            double previousY = 0;
            List<double[]> array = new List<double[]>();
            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));
            for (int rectangleIndex = 0; rectangleIndex < intervalCount; ++rectangleIndex)
            {
                double tempX = lowBorder + rectangleIndex * smallIntegralWidth;
                context.Variables["x"] = tempX;
                var expression = context.CompileGeneric<double>(function);
                double resolvedX = (double)expression.Evaluate();
                array.Add(new double[] { tempX, previousY });
                array.Add(new double[] { tempX, 0 });
                array.Add(new double[] { tempX, resolvedX });
                previousX = tempX;
                previousY = resolvedX;

                if (resolvedX <= 0)
                {
                    resolvedX = Math.Abs(resolvedX);
                }
                result += resolvedX * smallIntegralWidth;
            }
            return (result, array);
        }

        private (double, List<double[]>) trapezoidMethod(string function, double lowBorder, double upBorder, int intervalCount)
        {
            double result = 0;
            double smallIntegralWidth = (upBorder - lowBorder) / intervalCount;
            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));
            List<double[]> array = new List<double[]>();
            for (int trapezoidIndex = 0; trapezoidIndex < intervalCount; ++trapezoidIndex)
            {
                double firstTempX = lowBorder + trapezoidIndex * smallIntegralWidth;
                double secondTempX = lowBorder + (trapezoidIndex + 1) * smallIntegralWidth;

                context.Variables["x"] = firstTempX;
                array.Add(new double[] { firstTempX, 0 });
                var expression = context.CompileGeneric<double>(function);
                double firstResolvedX = (double)expression.Evaluate();
                array.Add(new double[] { firstTempX, firstResolvedX });
                if (firstResolvedX <= 0)
                {
                    firstResolvedX = Math.Abs(firstResolvedX);
                }
                context.Variables["x"] = secondTempX;
                expression = context.CompileGeneric<double>(function);
                double secondResolvedX = (double)expression.Evaluate();
                array.Add(new double[] { secondTempX, secondResolvedX });
                array.Add(new double[] { secondTempX, 0 });
                if (secondResolvedX <= 0)
                {
                    secondResolvedX = Math.Abs(secondResolvedX);
                }
                result += (firstResolvedX + secondResolvedX) / 2 * smallIntegralWidth;
            }
            return (result, array);
        }

        private (double, List<double[]>) SimpsonMethod(string function, double lowBorder, double upBorder, int intervalCount)
        {
            double result = 0;
            int counter = 0;
            double smallIntegralWidth = (upBorder - lowBorder) / intervalCount;
            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));
            List<double[]> array = new List<double[]>();
            List<double[]> center = new List<double[]>();
            List<double[]> right = new List<double[]>();
            List<double[]> left = new List<double[]>();
            List<double> firstXResults = new List<double>();

            double firstTempX = lowBorder;
            while (firstTempX <= upBorder)
            {
                context.Variables["x"] = firstTempX;
                var expression = context.CompileGeneric<double>(function);
                if ((double)expression.Evaluate() < 0)
                {
                    firstXResults.Add(Math.Abs((double)expression.Evaluate()));
                }
                else
                {
                    firstXResults.Add((double)expression.Evaluate());
                }


                firstTempX += smallIntegralWidth;
                center.Add(new double[] { firstTempX, (double)expression.Evaluate() });
            }

            double temporarySumm = 0;
            int index = 1;

            while (index <= firstXResults.Count() - 2)
            {
                temporarySumm += firstXResults[index];
                left.Add(new double[] { index, firstXResults[index] });
                index += 2;
            }

            double secondStageSumm = 4 * temporarySumm;

            double secondTempSumm = 0;
            int secondIndex = 2;

            while (secondIndex <= firstXResults.Count() - 2)
            {
                secondTempSumm += firstXResults[secondIndex];
                right.Add(new double[] { secondIndex, firstXResults[secondIndex] });
                secondIndex += 2;
            }

            while (counter < right.Count)
            {
                array.Add(left[counter]);
                array.Add(center[counter]);
                array.Add(right[counter]);

                array.Add(new double[] { double.NaN, double.NaN });
                ++counter;
            }

            double LastStageSumm = 2 * secondTempSumm;

            result = (smallIntegralWidth / 3) * ((firstXResults[0] + firstXResults[firstXResults.Count - 1]) + LastStageSumm + secondStageSumm);

            //for (int trapezoidIndex = 0; trapezoidIndex < intervalCount; ++trapezoidIndex)
            //{
            //    double firstTempX = lowBorder + trapezoidIndex * smallIntegralWidth;
            //    double secondTempX = lowBorder + (trapezoidIndex + 0.5) * smallIntegralWidth;
            //    double thirdTempX = lowBorder + (trapezoidIndex + 1) * smallIntegralWidth;

            //    context.Variables["x"] = firstTempX;
            //    var expression = context.CompileGeneric<double>(function);
            //    double firstResolvedX = (double)expression.Evaluate();

            //    context.Variables["x"] = secondTempX;
            //    expression = context.CompileGeneric<double>(function);
            //    double secondResolvedX = (double)expression.Evaluate();

            //    context.Variables["x"] = thirdTempX;
            //    expression = context.CompileGeneric<double>(function);
            //    double thirdResolvedX = (double)expression.Evaluate();

            //    result += (firstResolvedX + 4 * secondResolvedX + thirdResolvedX) / 6 * smallIntegralWidth;
            //} Это то, что раньше было методом Симпсона, но как его понял я. Это работало, и даже считало точнее, но я решил снести, т.к. нашёл настоящий метод

            return (result, array);
        }



        public double[] GaussMethod(double[,] matrix, double[] vector)
        {
            int matrixSize = matrix.GetLength(0);
            double[] solution = new double[matrixSize];

            // Прямой ход
            for (int currentRow = 0; currentRow < matrixSize; ++currentRow)
            {
                // Поиск максимального элемента в столбце
                int maxRowIndex = currentRow;
                for (int row = currentRow + 1; row < matrixSize; ++row)
                {
                    if (Math.Abs(matrix[row, currentRow]) > Math.Abs(matrix[maxRowIndex, currentRow]))
                    {
                        maxRowIndex = row;
                    }
                }

                // Перестановка строк
                if (maxRowIndex != currentRow)
                {
                    double[] tempRow = new double[matrixSize];
                    for (int column = 0; column < matrixSize; ++column)
                    {
                        tempRow[column] = matrix[currentRow, column];
                        matrix[currentRow, column] = matrix[maxRowIndex, column];
                        matrix[maxRowIndex, column] = tempRow[column];
                    }
                    double tempVectorValue = vector[currentRow];
                    vector[currentRow] = vector[maxRowIndex];
                    vector[maxRowIndex] = tempVectorValue;
                }

                // Нормализация строки (деление на главный элемент)
                double normalizationFactor = matrix[currentRow, currentRow];
                for (int column = currentRow; column < matrixSize; ++column)
                {
                    matrix[currentRow, column] /= normalizationFactor;
                }
                vector[currentRow] /= normalizationFactor;

                // Вычитание строки из нижележащих строк
                for (int row = currentRow + 1; row < matrixSize; ++row)
                {
                    double coefficient = matrix[row, currentRow];
                    for (int column = currentRow; column < matrixSize; ++column)
                    {
                        matrix[row, column] -= coefficient * matrix[currentRow, column];
                    }
                    vector[row] -= coefficient * vector[currentRow];
                }
            }

            // Обратный ход
            for (int currentRow = matrixSize - 1; currentRow >= 0; --currentRow)
            {
                solution[currentRow] = vector[currentRow];
                for (int row = currentRow - 1; row >= 0; --row)
                {
                    vector[row] -= matrix[row, currentRow] * solution[currentRow];
                }
            }

            return solution;
        }

        public double[] JordanoGaussMethod(double[,] matrix, double[] vector)
        {
            int matrixSize = matrix.GetLength(0);

            // Прямой ход
            for (int matrixIndex = 0; matrixIndex < matrixSize; ++matrixIndex)
            {
                // Нормализация строки (деление на главный элемент)
                double norm = matrix[matrixIndex, matrixIndex];
                for (int normalisationIndex = 0; normalisationIndex < matrixSize; ++normalisationIndex)
                {
                    matrix[matrixIndex, normalisationIndex] /= norm;
                }
                vector[matrixIndex] /= norm;

                // Вычитание строки из всех остальных строк
                for (int currentRowIndex = 0; currentRowIndex < matrixSize; ++currentRowIndex)
                {
                    if (currentRowIndex != matrixIndex)
                    {
                        double coef = matrix[currentRowIndex, matrixIndex];
                        for (int columnIndex = 0; columnIndex < matrixSize; ++columnIndex)
                        {
                            matrix[currentRowIndex, columnIndex] -= coef * matrix[matrixIndex, columnIndex];
                        }
                        vector[currentRowIndex] -= coef * vector[matrixIndex];
                    }
                }
            }

            // Обратный ход (по факту его тут нет, просто запись из вектора в решение)
            double[] solution = new double[matrixSize];
            for (int resultIndex = 0; resultIndex < matrixSize; ++resultIndex)
            {
                solution[resultIndex] = vector[resultIndex];
            }

            return solution;
        }

        public double[] CramerMethod(double[,] matrix, double[] vector)
        {
            int matrixSize = matrix.GetLength(0);
            double[] solution = new double[matrixSize];

            // Рассчитать определитель матрицы коэффициентов
            double determinant = CalculateDeterminant(matrix);

            // Проверить, что определитель не равен нулю
            if (determinant == 0)
            {
                throw new Exception("Определитель матрицы коэффициентов равен нулю");
            }

            // Рассчитать определители для каждой переменной
            for (int determinantIndex = 0; determinantIndex < matrixSize; ++determinantIndex)
            {
                double[,] tempMatrix = CreateTempMatrix(matrix, vector, determinantIndex);
                solution[determinantIndex] = CalculateDeterminant(tempMatrix) / determinant;
            }

            return solution;
        }

        private double CalculateDeterminant(double[,] matrix)
        {
            int matrixSize = matrix.GetLength(0);

            if (matrixSize == 1)
            {
                return matrix[0, 0];
            }
            else if (matrixSize == 2)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            else
            {
                double determinant = 0;
                for (int findDeterminantIndex = 0; findDeterminantIndex < matrixSize; ++findDeterminantIndex)
                {
                    double[,] tempMatrix = CreateTempMatrix(matrix, findDeterminantIndex, 0);
                    determinant += Math.Pow(-1, findDeterminantIndex) * matrix[0, findDeterminantIndex] * CalculateDeterminant(tempMatrix);
                }
                return determinant;
            }
        }

        private double[,] CreateTempMatrix(double[,] matrix, double[] vector, int index)
        {
            int tempMatrixSize = matrix.GetLength(0);
            double[,] tempMatrix = new double[tempMatrixSize, tempMatrixSize];

            for (int rowTempIndex = 0; rowTempIndex < tempMatrixSize; ++rowTempIndex)
            {
                for (int columnTempIndex = 0; columnTempIndex < tempMatrixSize; ++columnTempIndex)
                {
                    if (columnTempIndex != index)
                    {
                        tempMatrix[rowTempIndex, columnTempIndex] = matrix[rowTempIndex, columnTempIndex];
                    }
                    else
                    {
                        tempMatrix[rowTempIndex, columnTempIndex] = vector[rowTempIndex];
                    }
                }
            }

            return tempMatrix;
        }

        private double[,] CreateTempMatrix(double[,] matrix, int row, int column)
        {
            int tempMatrixSize = matrix.GetLength(0);
            double[,] tempMatrix = new double[tempMatrixSize - 1, tempMatrixSize - 1];

            for (int rowTemp = 0; rowTemp < tempMatrixSize; ++rowTemp)
            {
                for (int columnTemp = 0; columnTemp < tempMatrixSize; ++columnTemp)
                {
                    if (rowTemp != row && columnTemp != column)
                    {
                        int newRow;
                        if (rowTemp > row)
                        {
                            newRow = rowTemp - 1;
                        }
                        else
                        {
                            newRow = rowTemp;
                        }
                        int newColumn;
                        if (columnTemp > column)
                        {
                            newColumn = columnTemp - 1;
                        }
                        else
                        {
                            newColumn = columnTemp;
                        }
                        tempMatrix[newRow, newColumn] = matrix[rowTemp, columnTemp];
                    }
                }
            }

            return tempMatrix;
        }
    }


    // Презентер. Извлекает данные из модели, передает в вид. Обрабатывает события
    class Presenter
    {
        private IView mainView;
        private ISortView sortView;
        private IIntegralView integralView;
        private IAlgebraicView algebraicView;
        private Model model;

        public Presenter(IView inputView)
        {
            mainView = inputView;
            model = new Model();

            mainView.StartDichotomy += new EventHandler<EventArgs>(Dichotomy);
            mainView.CreateGraph += new EventHandler<EventArgs>(CreateGraph);
            mainView.StartGoldenRatio += new EventHandler<EventArgs>(GoldenRatio);
            mainView.StartNewton += new EventHandler<EventArgs>(Newton);
            mainView.StartDescent += new EventHandler<EventArgs>(Descent);
        }

        public Presenter(ISortView inputView)
        {
            sortView = inputView;
            model = new Model();

            sortView.AddData += new EventHandler<EventArgs>(AddData);
            sortView.Sort += new EventHandler<EventArgs>(Sort);
        }

        public Presenter(IIntegralView inputView)
        {
            integralView = inputView;
            model = new Model();

            integralView.CreateIntegralGraph += new EventHandler<EventArgs>(IntegralGraph);
            integralView.Calculate += new EventHandler<EventArgs>(CalculateIntegral);
            integralView.ReverseMode += new EventHandler<EventArgs>(StartReverse);
        }

        public Presenter(IAlgebraicView inputView) 
        {
            algebraicView = inputView;
            model = new Model();

            algebraicView.StartGauss += new EventHandler<EventArgs>(CalculateGauss);
            algebraicView.StartJordanoGauss += new EventHandler<EventArgs>(CalculateJordanoGauss);
            algebraicView.StartCramer += new EventHandler<EventArgs>(CalculateCramer);
        }

        private void CalculateGauss(object sender, EventArgs inputEvent) 
        {
            var output = model.GaussMethod(algebraicView.GetMatrix(), algebraicView.GetVector());
            algebraicView.ShowResult(output);
        }

        private void CalculateJordanoGauss(object sender, EventArgs inputEvent)
        {
            var output = model.JordanoGaussMethod(algebraicView.GetMatrix(), algebraicView.GetVector());
            algebraicView.ShowResult(output);
        }

        private void CalculateCramer(object sender, EventArgs inputEvent)
        {
            var output = model.CramerMethod(algebraicView.GetMatrix(), algebraicView.GetVector());
            algebraicView.ShowResult(output);
        }

        private void CalculateIntegral(object sender, EventArgs inputEvent)
        {
            var output = model.CalculateIntegral(integralView.returnFunction(), integralView.lowLimit(), integralView.upLimit(), integralView.IntegralIntervalCount(), integralView.IsRectangleActive(), integralView.IsTrapezoidActive(), integralView.IsSimpsonActive());
            integralView.ShowResult(output.Item1);
            integralView.UpdateGraph(output.Item2, 0);
            integralView.UpdateGraph(output.Item3, 1);
            integralView.UpdateGraph(output.Item4, 2);
        }

        private void StartReverse(object sender, EventArgs inputEvent)
        {
            var output = model.ReverseIntegral(integralView.returnFunction(), integralView.lowLimit(), integralView.upLimit(), integralView.Accuracy());
            integralView.ReverseResult(output);
        }

        private void IntegralGraph(object sender, EventArgs inputEvent)
        {
            var output = model.CreateIntegralGraph(integralView.Interval(), integralView.lowLimit(), integralView.upLimit(), integralView.returnFunction());
            integralView.ShowGraph(output);
        }

        private void AddData(object sender, EventArgs inputEvent)
        {
            var output = model.ChooseInput(sortView.StartInput(), sortView.PathToFile(), sortView.leftInterval(), sortView.rightInterval(), sortView.IsDouble(), sortView.ArraySizeToRandom());
            sortView.ChooseInput(output);
        }

        private void Sort(object sender, EventArgs inputEvent)
        {
            var output = model.Sorting(sortView.IsActiveBubble(), sortView.IsActiveInserts(), sortView.IsActiveFast(), sortView.IsActiveShake(), sortView.IsActiveSwamp(), sortView.SwampsIterations(), sortView.NumbersToSort(), sortView.IsIncreasing());
            sortView.ShowSortResult(output.Item1, output.Item2, output.Item3, output.Item4);
        }

        private void Newton(object sender, EventArgs inputEvent)
        {
            var output = model.Newton(mainView.returnFunction(), mainView.firstSide(), mainView.epsilon(), mainView.secondSide(), mainView.iterationCount(), mainView.Choice());
            mainView.ShowResult(output.Item1, output.Item2);
            mainView.UpdateGraph(output.Item3);
        }

        private void Dichotomy(object sender, EventArgs inputEvent)
        {
            var output = model.Dichotomy(mainView.returnFunction(), mainView.firstSide(), mainView.secondSide(), mainView.epsilon());
            mainView.ShowResult(output.Item1, output.Item2);
        }
        private void CreateGraph(object sender, EventArgs inputEvent)
        {
            var output = model.CreateGraph(mainView.Interval(), mainView.lowLimit(), mainView.upLimit(), mainView.returnFunction());
            mainView.ShowGraph(output);
        }

        private void GoldenRatio(object sender, EventArgs inputEvent)
        {
            var output = model.GoldenRatio(mainView.returnFunction(), mainView.firstSide(), mainView.secondSide(), mainView.epsilon(), mainView.MinimumOrMaximum());
            mainView.ShowResult(output.Item1, output.Item2);
        }

        private void Descent(object sender, EventArgs inputEvent)
        {
            var output = model.Descent(mainView.returnFunction(), mainView.firstSide(), mainView.epsilon(), mainView.secondSide(), mainView.iterationCount(), mainView.Choice(), mainView.MinimumOrMaximum());
            mainView.ShowResult(output.Item1, output.Item2);
        }
    }

    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}


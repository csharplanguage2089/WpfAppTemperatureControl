using System.Windows;

namespace WpfAppTemperatureControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random startSystem = new Random();

        bool reactorStop;

        bool reactorStabilizeOne;
        bool reactorStabilizeTwo;
        bool reactorStabilizeThree;
        bool reactorStabilizeFour;
        bool reactorStabilizeFive;
        bool reactorStabilizeSix;
        bool reactorStabilizeSeven;
        bool reactorStabilizeEight;
        bool reactorStabilizeNine;
        bool reactorStabilizeTen;

        bool reactorStabilizeOff;

        bool isExecuting;

        public MainWindow()
        {
            InitializeComponent();
        }

        // async

        /// <summary>
        /// Ручной запуск турбины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ReactorStart_Click(object sender, RoutedEventArgs e)
        {
            if (isExecuting)
            {
                return;
            }

            isExecuting = true;

            try
            {
                // Info table
                TextInfoOnOff.Text = "Вкл.";

                TemperatureMonitoring.Items.Clear();
                reactorStop = true;
                if (reactorStop)
                {
                    reactorStabilizeOne = true;
                    reactorStabilizeTwo = true;
                    reactorStabilizeThree = true;
                    reactorStabilizeFour = true;
                    reactorStabilizeFive = true;
                    reactorStabilizeSix = true;
                    reactorStabilizeSeven = true;
                    reactorStabilizeEight = true;
                    reactorStabilizeNine = true;
                    reactorStabilizeTen = true;

                    reactorStabilizeOff = false;

                    // Info table
                    TextInfoStabilize.Text = "Выкл.";

                    while (reactorStabilizeOne)
                    {
                        reactorStabilizeOne = false;
                        for (int iOne = 0; iOne < 10; iOne++)
                        {
                            int oneTemperature = startSystem.Next(1, 9);
                            TemperatureMonitoring.Items.Add("> " + oneTemperature + " degrees ");
                            TextInfoCurrentTemperature.Text = oneTemperature.ToString(); // Monitoring t
                            await Task.Delay(200);
                            if (!reactorStop) { return; } // Stop program
                        }
                        if (reactorStabilizeOff) { reactorStabilizeOne = true; } // ReactorStabilizeOn / ReactorStabilizeOff
                    }

                    while (reactorStabilizeTwo)
                    {
                        reactorStabilizeTwo = false;
                        for (int iTwo = 0; iTwo < 10; iTwo++)
                        {
                            int twoTemperature = startSystem.Next(10, 19);
                            TemperatureMonitoring.Items.Add("> " + twoTemperature + " degrees ");
                            TextInfoCurrentTemperature.Text = twoTemperature.ToString(); // Monitoring t
                            await Task.Delay(200);
                            if (!reactorStop) { return; } // Stop program
                        }
                        if (reactorStabilizeOff) { reactorStabilizeTwo = true; } // ReactorStabilizeOn / ReactorStabilizeOff
                    }

                    while (reactorStabilizeThree)
                    {
                        reactorStabilizeThree = false;
                        for (int iThree = 0; iThree < 10; iThree++)
                        {
                            int threeTemperature = startSystem.Next(20, 29);
                            TemperatureMonitoring.Items.Add("> " + threeTemperature + " degrees ");
                            TextInfoCurrentTemperature.Text = threeTemperature.ToString(); // Monitoring t
                            await Task.Delay(200);
                            if (!reactorStop) { return; } // Stop program
                        }
                        if (reactorStabilizeOff) { reactorStabilizeThree = true; } // ReactorStabilizeOn / ReactorStabilizeOff
                    }

                    while (reactorStabilizeFour)
                    {
                        reactorStabilizeFour = false;
                        for (int iFour = 0; iFour < 10; iFour++)
                        {
                            int fourTemperature = startSystem.Next(30, 39);
                            TemperatureMonitoring.Items.Add("> " + fourTemperature + " degrees ");
                            TextInfoCurrentTemperature.Text = fourTemperature.ToString(); // Monitoring t
                            await Task.Delay(200);
                            if (!reactorStop) { return; } // Stop program
                        }
                        if (reactorStabilizeOff) { reactorStabilizeFour = true; } // ReactorStabilizeOn / ReactorStabilizeOff
                    }

                    while (reactorStabilizeFive)
                    {
                        reactorStabilizeFive = false;
                        for (int iFive = 0; iFive < 10; iFive++)
                        {
                            int fiveTemperature = startSystem.Next(40, 49);
                            TemperatureMonitoring.Items.Add("> " + fiveTemperature + " degrees ");
                            TextInfoCurrentTemperature.Text = fiveTemperature.ToString(); // Monitoring t
                            await Task.Delay(200);
                            if (!reactorStop) { return; } // Stop program
                        }
                        if (reactorStabilizeOff) { reactorStabilizeFive = true; } // ReactorStabilizeOn / ReactorStabilizeOff
                    }

                    while (reactorStabilizeSix)
                    {
                        reactorStabilizeSix = false;
                        for (int iSix = 0; iSix < 10; iSix++)
                        {
                            int sixTemperature = startSystem.Next(50, 59);
                            TemperatureMonitoring.Items.Add("> " + sixTemperature + " degrees ");
                            TextInfoCurrentTemperature.Text = sixTemperature.ToString(); // Monitoring t
                            await Task.Delay(200);
                            if (!reactorStop) { return; } // Stop program
                        }
                        if (reactorStabilizeOff) { reactorStabilizeSix = true; } // ReactorStabilizeOn / ReactorStabilizeOff
                    }

                    while (reactorStabilizeSeven)
                    {
                        reactorStabilizeSeven = false;
                        for (int iSeven = 0; iSeven < 10; iSeven++)
                        {
                            int sevenTemperature = startSystem.Next(60, 69);
                            TemperatureMonitoring.Items.Add("> " + sevenTemperature + " degrees ");
                            TextInfoCurrentTemperature.Text = sevenTemperature.ToString(); // Monitoring t
                            await Task.Delay(200);
                            if (!reactorStop) { return; } // Stop program
                        }
                        if (reactorStabilizeOff) { reactorStabilizeSeven = true; } // ReactorStabilizeOn / ReactorStabilizeOff
                    }

                    while (reactorStabilizeEight)
                    {
                        reactorStabilizeEight = false;
                        for (int iEight = 0; iEight < 10; iEight++)
                        {
                            int eightTemperature = startSystem.Next(70, 79);
                            TemperatureMonitoring.Items.Add("> " + eightTemperature + " degrees ");
                            TextInfoCurrentTemperature.Text = eightTemperature.ToString(); // Monitoring t
                            await Task.Delay(200);
                            if (!reactorStop) { return; } // Stop program
                        }
                        if (reactorStabilizeOff) { reactorStabilizeEight = true; } // ReactorStabilizeOn / ReactorStabilizeOff
                    }

                    while (reactorStabilizeNine)
                    {
                        reactorStabilizeNine = false;
                        for (int iNine = 0; iNine < 10; iNine++)
                        {
                            int nineTemperature = startSystem.Next(80, 89);
                            TemperatureMonitoring.Items.Add("> " + nineTemperature + " degrees ");
                            TextInfoCurrentTemperature.Text = nineTemperature.ToString(); // Monitoring t
                            await Task.Delay(200);
                            if (!reactorStop) { return; } // Stop program
                        }
                        if (reactorStabilizeOff) { reactorStabilizeNine = true; } // ReactorStabilizeOn / ReactorStabilizeOff
                    }

                    while (reactorStabilizeTen)
                    {
                        reactorStabilizeTen = false;
                        for (int iTen = 0; iTen < 100; iTen++)
                        {
                            int tenTemperature = startSystem.Next(90, 100);
                            TemperatureMonitoring.Items.Add("> " + tenTemperature + " degrees ");
                            TextInfoCurrentTemperature.Text = tenTemperature.ToString(); // Monitoring t
                            await Task.Delay(200);
                            if (!reactorStop) { return; }

                            if (tenTemperature == 99)
                            {
                                TemperatureMonitoring.Items.Add("> Critical temperature!");
                                TextInfoOnOff.Text = "Остановлена, критическая температура!";
                                TextInfoCurrentTemperature.Text = "_!";
                                TextInfoStabilize.Text = "Выкл.";
                                return;
                            }
                        }
                    }
                }
            }
            finally { isExecuting = false; }
        }

        /// <summary>
        /// Стабилизация на n градусов (вкл.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReactorStabilizeOn_Click(object sender, RoutedEventArgs e)
        {
            reactorStabilizeOff = true;

            // Info table
            TextInfoStabilize.Text = "Вкл.";
        }

        /// <summary>
        /// Стабилизация на n градусов (выкл.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReactorStabilizeOff_Click(object sender, RoutedEventArgs e)
        {
            reactorStabilizeOff = false;

            // Info table
            TextInfoStabilize.Text = "Выкл.";
        }

        /// <summary>
        /// Остановить турбину
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReactorStop_Click(object sender, RoutedEventArgs e)
        {
            TemperatureMonitoring.Items.Clear();
            reactorStop = false;

            // Info table
            TextInfoOnOff.Text = "Выкл.";
            TextInfoCurrentTemperature.Text = "0";
            TextInfoStabilize.Text = "Выкл.";
        }

        /// <summary>
        /// Выйти из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReactorExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TemperatureMonitoring_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}

using RobotWars;
using RobotWars.Event;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using RobotWarsGUI.FileParser;
using RobotWarsGUI.ViewModel;
using RobotWars.GUI.ViewModel;

namespace RobotWarsGUI.View
{
    public partial class MainView : Form
    {
        private readonly AvailableValueViewModel _viewModel;
        private InputViewModel _input;
        private DataGridView _battlefield;
        private Dictionary<string, Color> _colors = new Dictionary<string, Color>
        {
            {"Robot1", Color.Red},
            {"Robot2", Color.Green}
        };

        private readonly IInputFileParser _fileParser;
        private readonly IRobotWarsEngine _robotWarsEngine;

        public MainView()
        {
            InitializeComponent();

            //use a dependence injector (NInject) instead of using a new.
            _fileParser = new InputFileParser();
            _robotWarsEngine = new RobotWarsEngine();
            _robotWarsEngine.StateChanged += UpdateStateOfWar;
            _input = new InputViewModel();
            _input.PropertyChanged += UpdateView;

            _viewModel = new AvailableValueViewModel();
            Height.DataSource = _viewModel.HeightRange;
            Width.DataSource = _viewModel.WidthRange;
            Direction1.DataSource = _viewModel.DirectionsRobot1;
            Direction2.DataSource = _viewModel.DirectionsRobot2;
            X1.DataSource = _viewModel.AvailableValueForX1;
            Y1.DataSource = _viewModel.AvailableValueForY1;
            X2.DataSource = _viewModel.AvailableValueForX2;
            Y2.DataSource = _viewModel.AvailableValueForY2;
        }

        private void HeightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _viewModel.AvailableValueForY1.Clear();
            _viewModel.AvailableValueForY2.Clear();
            for (int i = 0; i < (int)Height.SelectedValue; i++)
            {
                _viewModel.AvailableValueForY1.Add(i);
                _viewModel.AvailableValueForY2.Add(i);
            }
        }

        private void WidthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _viewModel.AvailableValueForX1.Clear();
            _viewModel.AvailableValueForX2.Clear();
            for (int i = 0; i < (int)Width.SelectedValue; i++)
            {
                _viewModel.AvailableValueForX1.Add(i);
                _viewModel.AvailableValueForX2.Add(i);
            }
        }

        private void CommandsButton_Click(object sender, EventArgs e)
        {
            Button senderButton = (sender as Button);
            string command = string.Empty;
            if (senderButton == null) return;
            switch (senderButton.Text)
            {
                case "Left":
                    command = "L";
                    break;
                case "Right":
                    command = "R";
                    break;
                case "Move":
                    command = "M";
                    break;
            }
            if (senderButton.Name.Contains("1"))
            {
                Commands1.AppendText(command);
            }
            else
            {
                Commands2.AppendText(command);
            }
        }

        private void Reset1Button_Click(object sender, EventArgs e)
        {
            Commands1.Clear();
        }

        private void Reset2Button_Click(object sender, EventArgs e)
        {
            Commands2.Clear();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            string fileName = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = @"txt files (*.txt)|*.txt";
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileTextBox.Text = openFileDialog.FileName;
                    fileName = openFileDialog.FileName;
                }
            }
            _fileParser.Parse(fileName, _input);
        }

        private void UpdateView(object sender, FileLoadedEvent e)
        {
            //Code smell, use reflexion
            if (e.MemberName == "Height")
            {
                Height.SelectedItem = e.Value;
            }
            else if (e.MemberName == "Width")
            {
                Width.SelectedItem = e.Value;
            }
            else if (e.MemberName == "X1")
            {
                X1.SelectedItem = e.Value;
            }
            else if (e.MemberName == "Y1")
            {
                Y1.SelectedItem = e.Value;
            }
            else if (e.MemberName == "Direction1")
            {
                Direction1.SelectedItem = e.Value;
            }
            else if (e.MemberName == "Commands1")
            {
                Commands1.Text = (string)e.Value;
            }
            else if (e.MemberName == "X2")
            {
                X2.SelectedItem = e.Value;
            }
            else if (e.MemberName == "Y2")
            {
                Y2.SelectedItem = e.Value;
            }
            else if (e.MemberName == "Direction2")
            {
                Direction2.SelectedItem = e.Value;
            }
            else if (e.MemberName == "Commands2")
            {
                Commands2.Text = (string)e.Value;
            }
        }

        private void StartWarButton_Click(object sender, EventArgs e)
        {
            InverseInputState();
            CreateGrid();

            //has to copy variable to avoid cross Thread
            int localHeight = (int)Height.SelectedItem;
            int localWidth = (int)Width.SelectedItem;
            int localX1 = (int)X1.SelectedItem;
            int localY1 = (int)Y1.SelectedItem;
            string localDirection1 = (string)Direction1.SelectedItem;
            string localCommands1 = Commands1.Text;
            int localX2 = (int)X2.SelectedItem;
            int localY2 = (int)Y2.SelectedItem;
            string localDirection2 = (string)Direction2.SelectedItem;
            string localCommands2 = Commands2.Text;
            Task task = new Task(delegate
            {
                RunEngine(localHeight, localWidth,
                        localX1, localY1, localDirection1, localCommands1,
                        localX2, localY2, localDirection2, localCommands2);
            });
            task.Start();
        }

        private void RunEngine(int height, int width,
            int x1, int y1, string direction1, string commands1,
            int x2, int y2, string diretcion2, string commands2)
        {
            _robotWarsEngine.Start(height, width, x1, y1, direction1, commands1, x2, y2, diretcion2, commands2);
            MessageBox.Show(@"War is over.");
            ResetGui();
        }

        private void ResetGui()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(InverseInputState));
            }
            else
            {
                InverseInputState();
            }
        }

        private void InverseInputState()
        {
            if (StartWarButton.Enabled)
            {
                BrowseButton.Enabled = false;
                StartWarButton.Enabled = false;
                Height.Enabled = false;
                Width.Enabled = false;
                X1.Enabled = false;
                Y1.Enabled = false;
                Direction1.Enabled = false;
                L1Button.Enabled = false;
                R1Button.Enabled = false;
                M1Button.Enabled = false;
                X2.Enabled = false;
                Y2.Enabled = false;
                Direction2.Enabled = false;
                L2Button.Enabled = false;
                R2Button.Enabled = false;
                M2Button.Enabled = false;
            }
            else
            {
                StartWarButton.Enabled = true;
                BrowseButton.Enabled = true;
                Height.Enabled = true;
                Width.Enabled = true;
                X1.Enabled = true;
                Y1.Enabled = true;
                Direction1.Enabled = true;
                L1Button.Enabled = true;
                R1Button.Enabled = true;
                M1Button.Enabled = true;
                X2.Enabled = true;
                Y2.Enabled = true;
                Direction2.Enabled = true;
                L2Button.Enabled = true;
                R2Button.Enabled = true;
                M2Button.Enabled = true;
                _battlefield.Dispose();
            }
        }

        private void CreateGrid()
        {
            _battlefield = new DataGridView { ReadOnly = true };
            for (int i = 1; i <= (int)Width.SelectedItem; i++)
            {
                _battlefield.Columns.Add("", "");
            }
            for (int j = 0; j < (int)Height.SelectedItem; j++)
                _battlefield.Rows.Add();

            _battlefield.Dock = DockStyle.Fill;
            _battlefield.Rows[(int)Height.SelectedItem - (int)Y1.SelectedItem].Cells[(int)X1.SelectedItem].Style.BackColor = Color.Red;
            _battlefield.Rows[(int)Height.SelectedItem - (int)Y2.SelectedItem].Cells[(int)X2.SelectedItem].Style.BackColor = Color.Green;
            RightPanel.Controls.Add(_battlefield);
            _battlefield.Show();
        }

        private void UpdateStateOfWar(object sender, StateCHangedEvent e)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate {
                    Update(e);
                }));
            }
            else
            {
                Update(e);
            }
        }

        private void Update(StateCHangedEvent e)
        {
            _battlefield.Rows[(int)Height.SelectedItem - e.OldPosition.Y].Cells[e.OldPosition.X].Style.BackColor = Color.White;
            _battlefield.Rows[(int)Height.SelectedItem - e.NewPosition.Y].Cells[e.NewPosition.X].Style.BackColor = _colors[e.Robot];
            _battlefield.Update();
            e.Signal.Set();
        }
    }
}
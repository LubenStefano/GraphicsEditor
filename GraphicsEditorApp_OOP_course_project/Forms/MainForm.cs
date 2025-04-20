using System;
using System.Drawing;
using System.Windows.Forms;
using GraphicsEditorForms.UIhelpers;
using GraphicsEditorCore;
using GraphicsEditorServices;
using GraphicsEditorShapes.ShapeClasses;

namespace GraphicsEditorForms
{
    public partial class MainForm : Form
    {
        private readonly CanvasService _canvasService;
        private readonly ToolModeManager _toolManager;
        private readonly UndoRedo _undoRedoService;
        private readonly ShapeSerializer _fileService;
        private readonly MessageHandlerHelper _messageHandlerHelper;

        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);

            // Enable double buffering for the panel
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, panel1, new object[] { true });

            // Initialize services
            _toolManager = new ToolModeManager();
            _fileService = new ShapeSerializer();
            _undoRedoService = new UndoRedo();
            _canvasService = new CanvasService(panel1.Width, panel1.Height, _toolManager, _undoRedoService, _fileService, this);
            _messageHandlerHelper = new MessageHandlerHelper(toolStripStatusLabel, toolsToolStripMenuItem);

            // Setup UI bindings
            colorPictureBox.BackColor = _toolManager.CurrentColor;

            // Event handlers
            panel1.Paint += (s, e) => _canvasService.Render(e.Graphics);
            panel1.MouseDown += Panel1_MouseDown;
            panel1.MouseMove += Panel1_MouseMove;
            panel1.MouseUp += Panel1_MouseUp;
            panel1.MouseDoubleClick += ShapesForm_MouseDoubleClick; // Attach the double-click event
        }

        private void createShapeButton_Click(object sender, EventArgs e)
        {
            // Open the CreateForm and pass the current MainForm instance
            using (var createForm = new CreateForm(_canvasService))
            {
                createForm.ShowDialog(); // Show the CreateForm as a dialog
                // Refresh the MainForm after the CreateForm is closed
                panel1.Invalidate(); // Redraw the panel to show the new shape
            }
        }

        private void penButton_Click(object sender, EventArgs e)
        {
            _toolManager.SetMode(ToolModeManager.ToolMode.Pen);
            UpdateUIState();
        }

        private void brushButton_Click(object sender, EventArgs e)
        {
            _toolManager.SetMode(ToolModeManager.ToolMode.Brush);
            UpdateUIState();
        }

        private void eraserButton_Click(object sender, EventArgs e)
        {
            _toolManager.SetMode(ToolModeManager.ToolMode.Eraser);
            UpdateUIState();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            _toolManager.SetMode(ToolModeManager.ToolMode.Select);
            UpdateUIState();
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            _toolManager.SetMode(ToolModeManager.ToolMode.Fill);
            UpdateUIState();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = _toolManager.CurrentColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    _toolManager.SetColor(colorDialog.Color);
                    colorPictureBox.BackColor = colorDialog.Color;
                }
            }
        }

        private void ShapesForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_toolManager.CurrentMode == ToolModeManager.ToolMode.Select)
            {
                // Check if a shape is selected
                Shape selectedShape = _canvasService.GetShapeAt(e.Location);
                if (selectedShape != null)
                {

                    ShapeInfoForm shapeInfoForm = new ShapeInfoForm(selectedShape, this, _canvasService);
                
                    shapeInfoForm.ShowDialog();
                  
                }
            }
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _canvasService.HandleMouseDown(e.Location, e.Button);
            panel1.Invalidate();
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            mousePositionInfo.Text = $"X: {e.X}, Y: {e.Y}";
            _canvasService.HandleMouseMove(e.Location, e.Button);
            panel1.Invalidate();
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _canvasService.HandleMouseUp();
            panel1.Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _canvasService.ClearCanvas();
            panel1.Invalidate();
            _canvasService.InvalidateCanvas();
            _messageHandlerHelper.ShowStatusMessage("New canvas created");
        }

        private void saveAsJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "JSON Files (*.json)|*.json";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _canvasService.SaveShapesToJson(dlg.FileName);
                        _messageHandlerHelper.ShowStatusMessage("Shapes saved successfully");
                    }
                    catch (Exception ex)
                    {
                        _messageHandlerHelper.ShowError("Save failed:", ex.Message);
                    }
                }
            }
        }

        private void openJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "JSON Files (*.json)|*.json";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _canvasService.LoadShapesFromJson(dlg.FileName);
                        panel1.Invalidate();
                        _canvasService.InvalidateCanvas();
                        _messageHandlerHelper.ShowStatusMessage("Shapes loaded successfully");
                    }
                    catch (Exception ex)
                    {
                        _messageHandlerHelper.ShowError("Save failed:", ex.Message);
                    }
                }
            }
        }

        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "PNG Files (*.png)|*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _canvasService.SaveToImage(dlg.FileName);
                        _messageHandlerHelper.ShowStatusMessage("Canvas saved as image successfully");
                    }
                    catch (Exception ex)
                    {
                        _messageHandlerHelper.ShowError("Save failed:", ex.Message);
                    }
                }
            }
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "PNG Files (*.png)|*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _canvasService.LoadImage(dlg.FileName);
                        panel1.Invalidate();
                        _canvasService.InvalidateCanvas();
                        _messageHandlerHelper.ShowStatusMessage("Canvas loaded from image successfully");
                    }
                    catch (Exception ex)
                    {
                        _messageHandlerHelper.ShowError("Save failed:", ex.Message);
                    }
                }
            }
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolsToolStripMenuItem.Checked)
            {
                toolsToolStripMenuItem.Checked = false;
                toolsPanel.Visible = false;
            }
            else
            {
                toolsToolStripMenuItem.Checked = true;
                toolsPanel.Visible = true;
            }

        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusBarToolStripMenuItem.Checked)
            {
                statusBarToolStripMenuItem.Checked = false;
                infoStatusStrip.Visible = false;
            }
            else
            {
                statusBarToolStripMenuItem.Checked = true;
                infoStatusStrip.Visible = true;
            }
        }

        private void openStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapesStatisticsForm statisticsForm = new ShapesStatisticsForm(_canvasService);
            statisticsForm.ShowDialog();
        }


        private void UpdateUIState()
        {
            panel1.Cursor = _toolManager.GetCurrentCursor();
            // Replace the problematic code with the following:
            penButton.BackColor = _toolManager.CurrentMode == ToolModeManager.ToolMode.Pen ? Color.LightBlue : SystemColors.Control;
            eraseButton.BackColor = _toolManager.CurrentMode == ToolModeManager.ToolMode.Eraser ? Color.LightBlue : SystemColors.Control;
            selectButton.BackColor = _toolManager.CurrentMode == ToolModeManager.ToolMode.Select ? Color.LightBlue : SystemColors.Control;
            fillButton.BackColor = _toolManager.CurrentMode == ToolModeManager.ToolMode.Fill ? Color.LightBlue : SystemColors.Control;
            brushButton.BackColor = _toolManager.CurrentMode == ToolModeManager.ToolMode.Brush ? Color.LightBlue : SystemColors.Control;
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            _canvasService.Undo();
            panel1.Invalidate();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            _canvasService.Redo();
            panel1.Invalidate();
        }
    }
}
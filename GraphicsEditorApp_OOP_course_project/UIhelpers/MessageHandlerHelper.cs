using System;
using System.Windows.Forms;

namespace GraphicsEditorForms.UIhelpers
{
    public class MessageHandlerHelper
    {
        private readonly ToolStripStatusLabel _statusLabel;
        private readonly ToolStripMenuItem _toolsMenuItem;
        private Timer _statusMessageTimer;

        public MessageHandlerHelper(ToolStripStatusLabel statusLabel, ToolStripMenuItem toolsMenuItem)
        {
            _statusLabel = statusLabel ?? throw new ArgumentNullException(nameof(statusLabel));
            _toolsMenuItem = toolsMenuItem ?? throw new ArgumentNullException(nameof(toolsMenuItem));

            InitializeTimer();
        }

        public MessageHandlerHelper()
        {
        }

        private void InitializeTimer()
        {
            _statusMessageTimer = new Timer { Interval = 5000 }; // 5 seconds
            _statusMessageTimer.Tick += (s, e) =>
            {
                _statusLabel.Text = string.Empty;
                _statusMessageTimer.Stop();
            };
        }

        public void ShowError(string title, string message)
        {
            MessageBox.Show(message, title,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
        }

        public void ShowStatusMessage(string message)
        {
            _toolsMenuItem.Visible = true;
            _statusLabel.Text = message;
            _statusMessageTimer.Stop();
            _statusMessageTimer.Start();
        }

        public void Dispose()
        {
            _statusMessageTimer?.Dispose();
        }
    }
}
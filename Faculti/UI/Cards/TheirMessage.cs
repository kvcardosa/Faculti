﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculti.UI.Cards
{
    public partial class TheirMessage : UserControl
    {
        public string Timestamp;

        public TheirMessage(string message, DateTime time)
        {
            InitializeComponent();
            Timestamp = $"{time.Hour}:{time.Minute}";

            MessageLabel.Text = message;
            TimeLabel.Text = time.ToString("hh:mm tt");

            MessageContainer.Size = new Size(MessageLabel.Width + 25, MessageContainer.Size.Height);
            this.Height = MessageLabel.Height + 37;
        }

        public void RemoveImageAndTime()
        {
            TimeLabel.Visible = false;
            MessagePictureBox.Visible = false;
            MessageContainer.Height = MessageLabel.Height + 31;
            this.Height = MessageContainer.Height;
        }
    }
}

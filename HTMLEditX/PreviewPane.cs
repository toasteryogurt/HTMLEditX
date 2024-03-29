﻿/* HTMLEditX - A web development IDE from XT Software
    Copyright (C) 2022 XT Software
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see https://www.gnu.org/licenses/. */
using System;
using System.Windows.Forms;

namespace HTMLEditX
{
    public partial class PreviewPane : Form
    {
        public PreviewPane()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void PreviewPane_Load(object sender, EventArgs e)
        {
            webBrowser1.AllowWebBrowserDrop = false;
            webBrowser1.Navigate(new System.Uri(@"C:/Users/Public/preview.html"));
            
        }
    }
}

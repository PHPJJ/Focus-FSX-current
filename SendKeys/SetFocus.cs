using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Net.Sockets;

namespace SetFocusFSX
{
    public partial class SetFocusFSX : Form
    {
       
        // The HandleData delegate is used by the ListenTread to report
        // Received request to the main program
        public delegate void HandleData(String Received);

        private enum ShowWindowEnum
        {
            Hide = 0,
            ShowNormal = 1, ShowMinimized = 2, ShowMaximized = 3,
            Maximize = 3, ShowNormalNoActivate = 4, Show = 5,
            Minimize = 6, ShowMinNoActivate = 7, ShowNoActivate = 8,
            Restore = 9, ShowDefault = 10, ForceMinimized = 11
        };
          /// <summary>
        /// Default constructor
        /// </summary>
        public SetFocusFSX()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Refresh the combobox list with all the top level windows running on desktop.
        /// </summary>
        private void RefreshWindows()
        {
            cboWindows.Items.Clear();
            GetTaskWindows();
        }

         private void GetTaskWindows()
        {
            // Get the desktopwindow handle
            int nDeshWndHandle = NativeWin32.GetDesktopWindow();

            // Get the first child window
            int nChildHandle = NativeWin32.GetWindow(nDeshWndHandle, NativeWin32.GW_CHILD);

            while (nChildHandle != 0)
            {
                //If the child window is this (Set Focus) application then ignore it.
                if (nChildHandle == this.Handle.ToInt32())
                {
                    nChildHandle = NativeWin32.GetWindow(nChildHandle, NativeWin32.GW_HWNDNEXT);
                }

                // Get only visible windows
                if (NativeWin32.IsWindowVisible(nChildHandle) != 0)
                {
                    StringBuilder sbTitle = new StringBuilder(1024);
                    // Read the Title bar text on the windows to put in combobox
                    NativeWin32.GetWindowText(nChildHandle, sbTitle, sbTitle.Capacity);
                    String sWinTitle = sbTitle.ToString();
                    {
                        if (sWinTitle.Length > 0)
                        {
                            cboWindows.Items.Add(sWinTitle);
                        }
                    }
                }
                // Look for the next child.
                nChildHandle = NativeWin32.GetWindow(nChildHandle, NativeWin32.GW_HWNDNEXT);
            }
        }

 
          private void btnSelect_Click(object sender, EventArgs e)
        {
            cboWindows.Visible = true;
            RefreshWindows();
            txtApplication.Visible = false;
  
        }

          private const int SW_SHOW = 5;
               /// <summary>
        /// Send keystrokes to application after finding it with its windows title and activating it.
        /// </summary>
        private void SetFocus()
        {
            int iHandle = NativeWin32.FindWindow(null, txtApplication.Text);
            
            NativeWin32.SetForegroundWindow(iHandle);
            NativeWin32.SetFocus(iHandle);
            //Application.DoEvents();
          
       }

   
          private void cboWindows_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtApplication.Text = cboWindows.SelectedItem.ToString();
            txtApplication.Visible = true;
            cboWindows.Visible = false;
            Properties.Settings.Default.Application = txtApplication.Text;
            Properties.Settings.Default.Save();
           
        }

 
            private void btExit_Click(object sender, EventArgs e)
        {
  
                 Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void btHide_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button3.Text = "Set FOCUS ON Application Above" ;
                button3.BackColor = Color.Green;
            }
            else
            {
                button3.Text = "SETTING FOCUS, Press to set OFF";
                timer1.Enabled = true;
                button3.BackColor = Color.Red;            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetFocus();
        }

        private void txtVar_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendKeysToApps_Load(object sender, EventArgs e)
        {
            button3.Text = "Set Timer ON";
            button3.BackColor = Color.Green;   
            txtApplication.Text = Properties.Settings.Default.Application;
        }

    }
}
    





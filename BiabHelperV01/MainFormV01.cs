using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiabHelperV01
{
    /// <summary>
    /// This is the main startup form.
    /// </summary>
    public partial class MainFormV01 : Form
    {
        /// <summary>
        /// This is the main constructor.
        /// </summary>
        public MainFormV01()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// This handles the clearing.
        /// </summary>
        /// <param name="sender">This is the event source.</param>
        /// <param name="e">These are the event arguments.</param>
        private void ResetTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.UpdatePageMessage(string.Empty);

                //TODO.

                this.UpdatePageMessage("Note MethodBase.GetCurrentMethod()='" + MethodBase.GetCurrentMethod() + "' is Ok.");

            }
            catch (Exception ex)
            {
                this.UpdatePageMessage(ex);
            }
        }

        /// <summary>
        /// This handles the processing.
        /// </summary>
        /// <param name="sender">This is the event source.</param>
        /// <param name="e">These are the event arguments.</param>
        private void ProcessTestButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.UpdatePageMessage(string.Empty);

                //TODO.

                this.UpdatePageMessage("Note MethodBase.GetCurrentMethod()='" + MethodBase.GetCurrentMethod() + "' is Ok.");

            }
            catch (Exception ex)
            {
                this.UpdatePageMessage(ex);
            }
        }

        /// <summary>
        /// This will set the information on the page for status.
        /// </summary>
        /// <param name="targetMessage">This is the value to use.</param>
        private void UpdatePageMessage(string targetMessage)
        {
            //This is a special case where we NEVER want to fail so try to handle everything gracefully.
            try
            {
                string myMessage = string.Empty;

                if (targetMessage == null)
                {
                    myMessage = "(targetMessage == null)";
                }
                else if (targetMessage.Trim().Length <= 0)
                {
                    myMessage = "(targetMessage.Trim().Length <= 0)";
                }
                else
                {
                    myMessage = (targetMessage + string.Empty).Trim();
                }

                myMessage = Environment.NewLine +
                    "DateTime.Now.ToString(\"o\")='" + DateTime.Now.ToString("o") + "'" + " | " +
                    "myMessage='" + myMessage + "'" + " | " +
                    string.Empty;

                this.MessageTextBox.Text = myMessage + Environment.NewLine + this.MessageTextBox.Text;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                MessageBox.Show(text: ex.ToString(), caption: "Error", buttons: MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// This will set the information on the page for status.
        /// </summary>
        /// <param name="targetMessage">This is the value to use.</param>
        private void UpdatePageMessage(Exception targetException)
        {
            //This is a special case where we NEVER want to fail so try to handle everything gracefully.
            try
            {
                string myMessage = string.Empty;

                if (targetException == null)
                {
                    myMessage = "(targetException == null)";
                }
                else
                {
                    myMessage = targetException.ToString().Trim();
                }

                //Call an overload.
                this.UpdatePageMessage(myMessage);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());                
                MessageBox.Show(text: ex.ToString(), caption: "Error", buttons: MessageBoxButtons.OK);
            }
        }
    }
}


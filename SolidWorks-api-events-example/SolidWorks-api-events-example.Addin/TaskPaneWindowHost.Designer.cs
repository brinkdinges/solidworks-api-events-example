using System.Runtime.InteropServices;
using System.Windows.Forms;
using AngelSix.SolidDna;

namespace SolidWorks_api_events_example.Addin
{
    [ProgId(MyProgId)]
    public partial class TaskPaneWindowHost : UserControl, ITaskpaneControl
    {
        /// <summary>
        /// Our unique ProgId for SolidWorks to find and load us
        /// </summary>
        private const string MyProgId = "SolidWorks_api_events_example.Addin";

        /// <summary>
        /// 
        /// </summary>
        public string ProgId => MyProgId;

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        #endregion
    }
}

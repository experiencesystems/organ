using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organ
{
    public class InputBoxDialogData : System.Windows.Forms.Form

    {

        #region Windows Contols and Constructor

        private System.Windows.Forms.Label lblPrompt;

        private System.Windows.Forms.Button btnOK;

        private System.Windows.Forms.DateTimePicker dtpData;

        /// <summary>

        /// Required designer variable.

        ///

        private System.ComponentModel.Container components = null;

        public InputBoxDialogData()

        {

            //

            // Required for Windows Form Designer support

            //

            InitializeComponent();

            //

            // TODO: Add any constructor code after InitializeComponent call

            //

        }

        #endregion

        #region Dispose

        /// <summary>

        /// Clean up any resources being used.

        ///

        protected override void Dispose(bool disposing)

        {

            if (disposing)

            {

                if (components != null)

                {

                    components.Dispose();

                }

            }

            base.Dispose(disposing);

        }

        #endregion

        #region Windows Form Designer generated code

        /// <summary>

        /// Required method for Designer support - do not modify

        /// the contents of this method with the code editor.

        ///

        private void InitializeComponent()

        {
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrompt.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrompt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(16, 9);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(273, 54);
            this.lblPrompt.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(311, 29);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/yyyy";
            this.dtpData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(20, 68);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(366, 27);
            this.dtpData.TabIndex = 5;
            // 
            // InputBoxDialogData
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(398, 107);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBoxDialogData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputBox";
            this.Load += new System.EventHandler(this.InputBoxData_Load);
            this.ResumeLayout(false);

        }

        //private System.Windows.Forms.Button btnCancel;

        #endregion

        #region Private Variables

        string formCaption = string.Empty;

        string formPrompt = string.Empty;

        string inputResponse = string.Empty;

        string defaultValue = string.Empty;

        #endregion

        #region Public Properties

        public string FormCaption

        {

            get { return formCaption; }

            set { formCaption = value; }

        } // property FormCaption

        public string FormPrompt

        {

            get { return formPrompt; }

            set { formPrompt = value; }

        } // property FormPrompt

        public string InputResponse

        {

            get { return inputResponse; }

            set { inputResponse = value; }

        } // property InputResponse

        public string DefaultValue

        {

            get { return defaultValue; }

            set { defaultValue = value; }

        } // property DefaultValue

        #endregion

        #region Form and Control Events

        private void InputBoxData_Load(object sender, System.EventArgs e)

        {

            this.dtpData.Text = defaultValue;

            this.lblPrompt.Text = formPrompt;

            this.Text = formCaption;

            this.dtpData.Focus();

        }

        #endregion

        void BtnOKClick(object sender, EventArgs e)

        {

            
            DateTime hoje = DateTime.Now;
            bool Valido = dtpData.Value > hoje;
            if (!Valido)
            {
                MessageBox.Show("Selecione uma data válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                InputResponse = this.dtpData.Text;
                this.Close();
            }

        }

        /*void BtnCancelClick(object sender, EventArgs e)

        {

            this.Close();

        }*/

    }

}

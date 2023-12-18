
namespace NETPaint
{
    partial class Form1
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.picSelectedColor = new System.Windows.Forms.PictureBox();
            this.picColorPicker = new System.Windows.Forms.PictureBox();
            this.pnlActionsStrip = new System.Windows.Forms.Panel();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.pnlFoot = new System.Windows.Forms.Panel();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblPencilWidth = new System.Windows.Forms.Label();
            this.tmrShowLabel = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColorPicker)).BeginInit();
            this.pnlActionsStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.pnlTop.Controls.Add(this.btnSave);
            this.pnlTop.Controls.Add(this.btnClear);
            this.pnlTop.Controls.Add(this.picSelectedColor);
            this.pnlTop.Controls.Add(this.picColorPicker);
            this.pnlTop.Controls.Add(this.pnlActionsStrip);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(871, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(784, 57);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(784, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // picSelectedColor
            // 
            this.picSelectedColor.Location = new System.Drawing.Point(186, 29);
            this.picSelectedColor.Name = "picSelectedColor";
            this.picSelectedColor.Size = new System.Drawing.Size(42, 42);
            this.picSelectedColor.TabIndex = 3;
            this.picSelectedColor.TabStop = false;
            // 
            // picColorPicker
            // 
            this.picColorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picColorPicker.Image = global::NETPaint.Properties.Resources.color_palette;
            this.picColorPicker.Location = new System.Drawing.Point(11, 12);
            this.picColorPicker.Name = "picColorPicker";
            this.picColorPicker.Size = new System.Drawing.Size(173, 75);
            this.picColorPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picColorPicker.TabIndex = 3;
            this.picColorPicker.TabStop = false;
            this.picColorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picColorPicker_MouseClick);
            // 
            // pnlActionsStrip
            // 
            this.pnlActionsStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.pnlActionsStrip.Controls.Add(this.btnLine);
            this.pnlActionsStrip.Controls.Add(this.btnRectangle);
            this.pnlActionsStrip.Controls.Add(this.btnEllipse);
            this.pnlActionsStrip.Controls.Add(this.btnEraser);
            this.pnlActionsStrip.Controls.Add(this.btnPencil);
            this.pnlActionsStrip.Controls.Add(this.btnFill);
            this.pnlActionsStrip.Controls.Add(this.btnColor);
            this.pnlActionsStrip.Location = new System.Drawing.Point(234, 12);
            this.pnlActionsStrip.Name = "pnlActionsStrip";
            this.pnlActionsStrip.Size = new System.Drawing.Size(536, 75);
            this.pnlActionsStrip.TabIndex = 3;
            // 
            // btnLine
            // 
            this.btnLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.ForeColor = System.Drawing.Color.White;
            this.btnLine.Image = global::NETPaint.Properties.Resources.line;
            this.btnLine.Location = new System.Drawing.Point(459, 9);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(67, 58);
            this.btnLine.TabIndex = 8;
            this.btnLine.Text = "Line";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.ForeColor = System.Drawing.Color.White;
            this.btnRectangle.Image = global::NETPaint.Properties.Resources.rectangle;
            this.btnRectangle.Location = new System.Drawing.Point(373, 9);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(82, 58);
            this.btnRectangle.TabIndex = 7;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.ForeColor = System.Drawing.Color.White;
            this.btnEllipse.Image = global::NETPaint.Properties.Resources.circle;
            this.btnEllipse.Location = new System.Drawing.Point(300, 9);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(67, 58);
            this.btnEllipse.TabIndex = 6;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.ForeColor = System.Drawing.Color.White;
            this.btnEraser.Image = global::NETPaint.Properties.Resources.eraser;
            this.btnEraser.Location = new System.Drawing.Point(227, 9);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(67, 58);
            this.btnEraser.TabIndex = 5;
            this.btnEraser.Text = "Eraser";
            this.btnEraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencil.ForeColor = System.Drawing.Color.White;
            this.btnPencil.Image = global::NETPaint.Properties.Resources.pencil;
            this.btnPencil.Location = new System.Drawing.Point(154, 9);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(67, 58);
            this.btnPencil.TabIndex = 4;
            this.btnPencil.Text = "Pencil";
            this.btnPencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnFill
            // 
            this.btnFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFill.ForeColor = System.Drawing.Color.White;
            this.btnFill.Image = global::NETPaint.Properties.Resources.bucket;
            this.btnFill.Location = new System.Drawing.Point(81, 9);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(67, 58);
            this.btnFill.TabIndex = 3;
            this.btnFill.Text = "Fill";
            this.btnFill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Image = global::NETPaint.Properties.Resources.color;
            this.btnColor.Location = new System.Drawing.Point(8, 9);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(67, 58);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Color";
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // pnlFoot
            // 
            this.pnlFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.pnlFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFoot.Location = new System.Drawing.Point(0, 483);
            this.pnlFoot.Name = "pnlFoot";
            this.pnlFoot.Size = new System.Drawing.Size(871, 20);
            this.pnlFoot.TabIndex = 1;
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanvas.Location = new System.Drawing.Point(0, 100);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(871, 383);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // lblPencilWidth
            // 
            this.lblPencilWidth.AutoSize = true;
            this.lblPencilWidth.Location = new System.Drawing.Point(843, 466);
            this.lblPencilWidth.Name = "lblPencilWidth";
            this.lblPencilWidth.Size = new System.Drawing.Size(0, 17);
            this.lblPencilWidth.TabIndex = 3;
            this.lblPencilWidth.Visible = false;
            // 
            // tmrShowLabel
            // 
            this.tmrShowLabel.Interval = 2000;
            this.tmrShowLabel.Tick += new System.EventHandler(this.tmrShowLabel_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 503);
            this.Controls.Add(this.lblPencilWidth);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.pnlFoot);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NETPaint";
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseWheel);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColorPicker)).EndInit();
            this.pnlActionsStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlFoot;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Panel pnlActionsStrip;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.PictureBox picColorPicker;
        private System.Windows.Forms.PictureBox picSelectedColor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPencilWidth;
        private System.Windows.Forms.Timer tmrShowLabel;
    }
}


using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Coca_Cola_Project
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MainForm : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picCola = new System.Windows.Forms.PictureBox();
            this.picColaDiet = new System.Windows.Forms.PictureBox();
            this.picColaZero = new System.Windows.Forms.PictureBox();
            this.picFanta = new System.Windows.Forms.PictureBox();
            this.picDrPepper = new System.Windows.Forms.PictureBox();
            this.picSprite = new System.Windows.Forms.PictureBox();
            this.picSpriteZero = new System.Windows.Forms.PictureBox();
            this.picMMLemon = new System.Windows.Forms.PictureBox();
            this.picMMLemonZero = new System.Windows.Forms.PictureBox();
            this.picRootBeer = new System.Windows.Forms.PictureBox();
            this.btnReOrder = new System.Windows.Forms.Button();
            this.btnInventoryRp = new System.Windows.Forms.Button();
            this.btnOrderRp = new System.Windows.Forms.Button();
            this.btnMixDisp = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdThirtyTwoOz = new System.Windows.Forms.RadioButton();
            this.rdTwentyFourOz = new System.Windows.Forms.RadioButton();
            this.rdSixTeenOz = new System.Windows.Forms.RadioButton();
            this.rdEightOz = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResetFlavors = new System.Windows.Forms.Button();
            this.lblFlavorCount = new System.Windows.Forms.Label();
            this.lblCola = new System.Windows.Forms.Label();
            this.lblDietCola = new System.Windows.Forms.Label();
            this.lblZeroCola = new System.Windows.Forms.Label();
            this.lblFanta = new System.Windows.Forms.Label();
            this.lblDrPepper = new System.Windows.Forms.Label();
            this.lblRootBeer = new System.Windows.Forms.Label();
            this.lblMntMaidZero = new System.Windows.Forms.Label();
            this.lblMntMaid = new System.Windows.Forms.Label();
            this.lblSpriteZero = new System.Windows.Forms.Label();
            this.lblSprite = new System.Windows.Forms.Label();
            this.InventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FreeStyleDBDataSet = new Coca_Cola_Project.FreeStyleDBDataSet();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderFluidInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderFluidInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMaintenanceRp = new System.Windows.Forms.Button();
            this.btnLocationMgRp = new System.Windows.Forms.Button();
            this.cklbInventory = new System.Windows.Forms.CheckedListBox();
            this.btnOrderInventoryAfterSelection = new System.Windows.Forms.Button();
            this.DTPStart = new System.Windows.Forms.DateTimePicker();
            this.DTPEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnGetOrderReport = new System.Windows.Forms.Button();
            this.InventoryTableAdapter = new Coca_Cola_Project.FreeStyleDBDataSetTableAdapters.InventoryTableAdapter();
            this.TableAdapterManager = new Coca_Cola_Project.FreeStyleDBDataSetTableAdapters.TableAdapterManager();
            this.OrderFluidInfoTableAdapter = new Coca_Cola_Project.FreeStyleDBDataSetTableAdapters.OrderFluidInfoTableAdapter();
            this.OrdersTableAdapter = new Coca_Cola_Project.FreeStyleDBDataSetTableAdapters.OrdersTableAdapter();
            this.DataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersDataGridViewWDP = new System.Windows.Forms.DataGridView();
            this.StartDateToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.StartDateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.EndDateToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.EndDateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.FillByOrdersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FillByOrdersToolStrip = new System.Windows.Forms.ToolStrip();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.InventoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.InventoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColaDiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColaZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrPepper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpriteZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMMLemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMMLemonZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRootBeer)).BeginInit();
            this.grpSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeStyleDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFluidInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFluidInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridViewWDP)).BeginInit();
            this.FillByOrdersToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryBindingNavigator)).BeginInit();
            this.InventoryBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCola
            // 
            this.picCola.Image = ((System.Drawing.Image)(resources.GetObject("picCola.Image")));
            this.picCola.Location = new System.Drawing.Point(53, 43);
            this.picCola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCola.Name = "picCola";
            this.picCola.Size = new System.Drawing.Size(163, 148);
            this.picCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCola.TabIndex = 0;
            this.picCola.TabStop = false;
            this.picCola.Click += new System.EventHandler(this.picCola_Click);
            // 
            // picColaDiet
            // 
            this.picColaDiet.Image = ((System.Drawing.Image)(resources.GetObject("picColaDiet.Image")));
            this.picColaDiet.Location = new System.Drawing.Point(243, 43);
            this.picColaDiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picColaDiet.Name = "picColaDiet";
            this.picColaDiet.Size = new System.Drawing.Size(163, 148);
            this.picColaDiet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picColaDiet.TabIndex = 1;
            this.picColaDiet.TabStop = false;
            this.picColaDiet.Click += new System.EventHandler(this.picColaDiet_Click);
            // 
            // picColaZero
            // 
            this.picColaZero.Image = ((System.Drawing.Image)(resources.GetObject("picColaZero.Image")));
            this.picColaZero.Location = new System.Drawing.Point(432, 43);
            this.picColaZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picColaZero.Name = "picColaZero";
            this.picColaZero.Size = new System.Drawing.Size(163, 148);
            this.picColaZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picColaZero.TabIndex = 2;
            this.picColaZero.TabStop = false;
            this.picColaZero.Click += new System.EventHandler(this.picColaZero_Click);
            // 
            // picFanta
            // 
            this.picFanta.Image = ((System.Drawing.Image)(resources.GetObject("picFanta.Image")));
            this.picFanta.Location = new System.Drawing.Point(621, 43);
            this.picFanta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFanta.Name = "picFanta";
            this.picFanta.Size = new System.Drawing.Size(163, 148);
            this.picFanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFanta.TabIndex = 3;
            this.picFanta.TabStop = false;
            this.picFanta.Click += new System.EventHandler(this.picFanta_Click);
            // 
            // picDrPepper
            // 
            this.picDrPepper.Image = ((System.Drawing.Image)(resources.GetObject("picDrPepper.Image")));
            this.picDrPepper.Location = new System.Drawing.Point(811, 43);
            this.picDrPepper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picDrPepper.Name = "picDrPepper";
            this.picDrPepper.Size = new System.Drawing.Size(163, 148);
            this.picDrPepper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDrPepper.TabIndex = 4;
            this.picDrPepper.TabStop = false;
            this.picDrPepper.Click += new System.EventHandler(this.picDrPepper_Click);
            // 
            // picSprite
            // 
            this.picSprite.Image = ((System.Drawing.Image)(resources.GetObject("picSprite.Image")));
            this.picSprite.Location = new System.Drawing.Point(53, 233);
            this.picSprite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSprite.Name = "picSprite";
            this.picSprite.Size = new System.Drawing.Size(163, 148);
            this.picSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSprite.TabIndex = 5;
            this.picSprite.TabStop = false;
            this.picSprite.Click += new System.EventHandler(this.picSprite_Click);
            // 
            // picSpriteZero
            // 
            this.picSpriteZero.Image = ((System.Drawing.Image)(resources.GetObject("picSpriteZero.Image")));
            this.picSpriteZero.Location = new System.Drawing.Point(243, 233);
            this.picSpriteZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSpriteZero.Name = "picSpriteZero";
            this.picSpriteZero.Size = new System.Drawing.Size(163, 148);
            this.picSpriteZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSpriteZero.TabIndex = 6;
            this.picSpriteZero.TabStop = false;
            this.picSpriteZero.Click += new System.EventHandler(this.picSpriteZero_Click);
            // 
            // picMMLemon
            // 
            this.picMMLemon.Image = ((System.Drawing.Image)(resources.GetObject("picMMLemon.Image")));
            this.picMMLemon.Location = new System.Drawing.Point(432, 233);
            this.picMMLemon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMMLemon.Name = "picMMLemon";
            this.picMMLemon.Size = new System.Drawing.Size(163, 148);
            this.picMMLemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMMLemon.TabIndex = 7;
            this.picMMLemon.TabStop = false;
            this.picMMLemon.Click += new System.EventHandler(this.picMMLemon_Click);
            // 
            // picMMLemonZero
            // 
            this.picMMLemonZero.Image = ((System.Drawing.Image)(resources.GetObject("picMMLemonZero.Image")));
            this.picMMLemonZero.Location = new System.Drawing.Point(621, 233);
            this.picMMLemonZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMMLemonZero.Name = "picMMLemonZero";
            this.picMMLemonZero.Size = new System.Drawing.Size(163, 148);
            this.picMMLemonZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMMLemonZero.TabIndex = 8;
            this.picMMLemonZero.TabStop = false;
            this.picMMLemonZero.Click += new System.EventHandler(this.picMMLemonZero_Click);
            // 
            // picRootBeer
            // 
            this.picRootBeer.Image = ((System.Drawing.Image)(resources.GetObject("picRootBeer.Image")));
            this.picRootBeer.Location = new System.Drawing.Point(811, 233);
            this.picRootBeer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picRootBeer.Name = "picRootBeer";
            this.picRootBeer.Size = new System.Drawing.Size(163, 148);
            this.picRootBeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRootBeer.TabIndex = 9;
            this.picRootBeer.TabStop = false;
            this.picRootBeer.Click += new System.EventHandler(this.picRootBeer_Click);
            // 
            // btnReOrder
            // 
            this.btnReOrder.BackColor = System.Drawing.Color.Chocolate;
            this.btnReOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReOrder.Location = new System.Drawing.Point(64, 414);
            this.btnReOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReOrder.Name = "btnReOrder";
            this.btnReOrder.Size = new System.Drawing.Size(163, 47);
            this.btnReOrder.TabIndex = 0;
            this.btnReOrder.Text = "&Reorder Inventory";
            this.btnReOrder.UseVisualStyleBackColor = false;
            this.btnReOrder.Click += new System.EventHandler(this.btnReOrder_Click);
            // 
            // btnInventoryRp
            // 
            this.btnInventoryRp.BackColor = System.Drawing.Color.Chocolate;
            this.btnInventoryRp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryRp.Location = new System.Drawing.Point(64, 478);
            this.btnInventoryRp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventoryRp.Name = "btnInventoryRp";
            this.btnInventoryRp.Size = new System.Drawing.Size(163, 47);
            this.btnInventoryRp.TabIndex = 1;
            this.btnInventoryRp.Text = "&Fluid Lvl Report";
            this.btnInventoryRp.UseVisualStyleBackColor = false;
            this.btnInventoryRp.Click += new System.EventHandler(this.btnSyrupSt_Click);
            // 
            // btnOrderRp
            // 
            this.btnOrderRp.BackColor = System.Drawing.Color.Chocolate;
            this.btnOrderRp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderRp.Location = new System.Drawing.Point(64, 602);
            this.btnOrderRp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderRp.Name = "btnOrderRp";
            this.btnOrderRp.Size = new System.Drawing.Size(163, 48);
            this.btnOrderRp.TabIndex = 2;
            this.btnOrderRp.Text = "&Order Report";
            this.btnOrderRp.UseVisualStyleBackColor = false;
            this.btnOrderRp.Click += new System.EventHandler(this.btnSodaSt_Click);
            // 
            // btnMixDisp
            // 
            this.btnMixDisp.BackColor = System.Drawing.Color.Chocolate;
            this.btnMixDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMixDisp.Location = new System.Drawing.Point(781, 551);
            this.btnMixDisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMixDisp.Name = "btnMixDisp";
            this.btnMixDisp.Size = new System.Drawing.Size(181, 119);
            this.btnMixDisp.TabIndex = 5;
            this.btnMixDisp.Text = "&Mix Flavors / Dispense";
            this.btnMixDisp.UseVisualStyleBackColor = false;
            this.btnMixDisp.Click += new System.EventHandler(this.btnMixDisp_Click);
            // 
            // lblSize
            // 
            this.lblSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(21, 39);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(195, 41);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Choose Your Size:";
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rdThirtyTwoOz);
            this.grpSize.Controls.Add(this.rdTwentyFourOz);
            this.grpSize.Controls.Add(this.rdSixTeenOz);
            this.grpSize.Controls.Add(this.rdEightOz);
            this.grpSize.Controls.Add(this.btnBack);
            this.grpSize.Controls.Add(this.lblSize);
            this.grpSize.Location = new System.Drawing.Point(325, 402);
            this.grpSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSize.Name = "grpSize";
            this.grpSize.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSize.Size = new System.Drawing.Size(395, 345);
            this.grpSize.TabIndex = 6;
            this.grpSize.TabStop = false;
            // 
            // rdThirtyTwoOz
            // 
            this.rdThirtyTwoOz.AutoSize = true;
            this.rdThirtyTwoOz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThirtyTwoOz.ForeColor = System.Drawing.Color.White;
            this.rdThirtyTwoOz.Location = new System.Drawing.Point(304, 208);
            this.rdThirtyTwoOz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdThirtyTwoOz.Name = "rdThirtyTwoOz";
            this.rdThirtyTwoOz.Size = new System.Drawing.Size(76, 28);
            this.rdThirtyTwoOz.TabIndex = 8;
            this.rdThirtyTwoOz.TabStop = true;
            this.rdThirtyTwoOz.Text = "32 oz";
            this.rdThirtyTwoOz.UseVisualStyleBackColor = true;
            this.rdThirtyTwoOz.Click += new System.EventHandler(this.rdThirtyTwoOz_Click);
            // 
            // rdTwentyFourOz
            // 
            this.rdTwentyFourOz.AutoSize = true;
            this.rdTwentyFourOz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTwentyFourOz.ForeColor = System.Drawing.Color.White;
            this.rdTwentyFourOz.Location = new System.Drawing.Point(304, 156);
            this.rdTwentyFourOz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdTwentyFourOz.Name = "rdTwentyFourOz";
            this.rdTwentyFourOz.Size = new System.Drawing.Size(76, 28);
            this.rdTwentyFourOz.TabIndex = 7;
            this.rdTwentyFourOz.TabStop = true;
            this.rdTwentyFourOz.Text = "24 oz";
            this.rdTwentyFourOz.UseVisualStyleBackColor = true;
            this.rdTwentyFourOz.Click += new System.EventHandler(this.rdTwentyFourOz_Click);
            // 
            // rdSixTeenOz
            // 
            this.rdSixTeenOz.AutoSize = true;
            this.rdSixTeenOz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSixTeenOz.ForeColor = System.Drawing.Color.White;
            this.rdSixTeenOz.Location = new System.Drawing.Point(304, 103);
            this.rdSixTeenOz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdSixTeenOz.Name = "rdSixTeenOz";
            this.rdSixTeenOz.Size = new System.Drawing.Size(76, 28);
            this.rdSixTeenOz.TabIndex = 6;
            this.rdSixTeenOz.TabStop = true;
            this.rdSixTeenOz.Text = "16 oz";
            this.rdSixTeenOz.UseVisualStyleBackColor = true;
            this.rdSixTeenOz.Click += new System.EventHandler(this.rdSixTeenOz_Click);
            // 
            // rdEightOz
            // 
            this.rdEightOz.AutoSize = true;
            this.rdEightOz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEightOz.ForeColor = System.Drawing.Color.White;
            this.rdEightOz.Location = new System.Drawing.Point(304, 52);
            this.rdEightOz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdEightOz.Name = "rdEightOz";
            this.rdEightOz.Size = new System.Drawing.Size(66, 28);
            this.rdEightOz.TabIndex = 5;
            this.rdEightOz.TabStop = true;
            this.rdEightOz.Text = "8 oz";
            this.rdEightOz.UseVisualStyleBackColor = true;
            this.rdEightOz.Click += new System.EventHandler(this.rdEightOz_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(21, 222);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(159, 47);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Chocolate;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(800, 699);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 48);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnResetFlavors
            // 
            this.btnResetFlavors.BackColor = System.Drawing.Color.Chocolate;
            this.btnResetFlavors.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFlavors.ForeColor = System.Drawing.Color.Black;
            this.btnResetFlavors.Location = new System.Drawing.Point(781, 466);
            this.btnResetFlavors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetFlavors.Name = "btnResetFlavors";
            this.btnResetFlavors.Size = new System.Drawing.Size(181, 68);
            this.btnResetFlavors.TabIndex = 4;
            this.btnResetFlavors.Text = "R&eset Flavors";
            this.btnResetFlavors.UseVisualStyleBackColor = false;
            this.btnResetFlavors.Click += new System.EventHandler(this.btnResetFlavors_Click);
            // 
            // lblFlavorCount
            // 
            this.lblFlavorCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlavorCount.ForeColor = System.Drawing.Color.White;
            this.lblFlavorCount.Location = new System.Drawing.Point(781, 414);
            this.lblFlavorCount.Name = "lblFlavorCount";
            this.lblFlavorCount.Size = new System.Drawing.Size(182, 39);
            this.lblFlavorCount.TabIndex = 10;
            this.lblFlavorCount.Text = "Flavors Picked: 0";
            // 
            // lblCola
            // 
            this.lblCola.BackColor = System.Drawing.Color.White;
            this.lblCola.ForeColor = System.Drawing.Color.White;
            this.lblCola.Location = new System.Drawing.Point(47, 36);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(176, 164);
            this.lblCola.TabIndex = 20;
            this.lblCola.Text = "Label10";
            // 
            // lblDietCola
            // 
            this.lblDietCola.BackColor = System.Drawing.Color.White;
            this.lblDietCola.ForeColor = System.Drawing.Color.White;
            this.lblDietCola.Location = new System.Drawing.Point(236, 36);
            this.lblDietCola.Name = "lblDietCola";
            this.lblDietCola.Size = new System.Drawing.Size(176, 164);
            this.lblDietCola.TabIndex = 21;
            this.lblDietCola.Text = "Label1";
            // 
            // lblZeroCola
            // 
            this.lblZeroCola.BackColor = System.Drawing.Color.White;
            this.lblZeroCola.ForeColor = System.Drawing.Color.White;
            this.lblZeroCola.Location = new System.Drawing.Point(425, 36);
            this.lblZeroCola.Name = "lblZeroCola";
            this.lblZeroCola.Size = new System.Drawing.Size(176, 164);
            this.lblZeroCola.TabIndex = 22;
            this.lblZeroCola.Text = "Label2";
            // 
            // lblFanta
            // 
            this.lblFanta.BackColor = System.Drawing.Color.White;
            this.lblFanta.ForeColor = System.Drawing.Color.White;
            this.lblFanta.Location = new System.Drawing.Point(613, 36);
            this.lblFanta.Name = "lblFanta";
            this.lblFanta.Size = new System.Drawing.Size(176, 164);
            this.lblFanta.TabIndex = 23;
            this.lblFanta.Text = "Label3";
            // 
            // lblDrPepper
            // 
            this.lblDrPepper.BackColor = System.Drawing.Color.White;
            this.lblDrPepper.ForeColor = System.Drawing.Color.White;
            this.lblDrPepper.Location = new System.Drawing.Point(803, 36);
            this.lblDrPepper.Name = "lblDrPepper";
            this.lblDrPepper.Size = new System.Drawing.Size(176, 164);
            this.lblDrPepper.TabIndex = 24;
            this.lblDrPepper.Text = "Label4";
            // 
            // lblRootBeer
            // 
            this.lblRootBeer.BackColor = System.Drawing.Color.White;
            this.lblRootBeer.ForeColor = System.Drawing.Color.White;
            this.lblRootBeer.Location = new System.Drawing.Point(803, 226);
            this.lblRootBeer.Name = "lblRootBeer";
            this.lblRootBeer.Size = new System.Drawing.Size(176, 164);
            this.lblRootBeer.TabIndex = 25;
            this.lblRootBeer.Text = "Label5";
            // 
            // lblMntMaidZero
            // 
            this.lblMntMaidZero.BackColor = System.Drawing.Color.White;
            this.lblMntMaidZero.ForeColor = System.Drawing.Color.White;
            this.lblMntMaidZero.Location = new System.Drawing.Point(613, 226);
            this.lblMntMaidZero.Name = "lblMntMaidZero";
            this.lblMntMaidZero.Size = new System.Drawing.Size(176, 164);
            this.lblMntMaidZero.TabIndex = 26;
            this.lblMntMaidZero.Text = "Label6";
            // 
            // lblMntMaid
            // 
            this.lblMntMaid.BackColor = System.Drawing.Color.White;
            this.lblMntMaid.ForeColor = System.Drawing.Color.White;
            this.lblMntMaid.Location = new System.Drawing.Point(425, 226);
            this.lblMntMaid.Name = "lblMntMaid";
            this.lblMntMaid.Size = new System.Drawing.Size(176, 164);
            this.lblMntMaid.TabIndex = 27;
            this.lblMntMaid.Text = "Label7";
            // 
            // lblSpriteZero
            // 
            this.lblSpriteZero.BackColor = System.Drawing.Color.White;
            this.lblSpriteZero.ForeColor = System.Drawing.Color.White;
            this.lblSpriteZero.Location = new System.Drawing.Point(236, 226);
            this.lblSpriteZero.Name = "lblSpriteZero";
            this.lblSpriteZero.Size = new System.Drawing.Size(176, 164);
            this.lblSpriteZero.TabIndex = 28;
            this.lblSpriteZero.Text = "Label8";
            // 
            // lblSprite
            // 
            this.lblSprite.BackColor = System.Drawing.Color.White;
            this.lblSprite.ForeColor = System.Drawing.Color.White;
            this.lblSprite.Location = new System.Drawing.Point(47, 226);
            this.lblSprite.Name = "lblSprite";
            this.lblSprite.Size = new System.Drawing.Size(176, 164);
            this.lblSprite.TabIndex = 29;
            this.lblSprite.Text = "Label9";
            // 
            // InventoryBindingSource
            // 
            this.InventoryBindingSource.DataMember = "Inventory";
            this.InventoryBindingSource.DataSource = this.FreeStyleDBDataSet;
            // 
            // FreeStyleDBDataSet
            // 
            this.FreeStyleDBDataSet.DataSetName = "FreeStyleDBDataSet";
            this.FreeStyleDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.AutoGenerateColumns = false;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn1,
            this.DataGridViewTextBoxColumn2,
            this.DataGridViewTextBoxColumn3});
            this.OrdersDataGridView.DataSource = this.OrdersBindingSource;
            this.OrdersDataGridView.Location = new System.Drawing.Point(1009, 293);
            this.OrdersDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.RowHeadersWidth = 51;
            this.OrdersDataGridView.RowTemplate.Height = 24;
            this.OrdersDataGridView.Size = new System.Drawing.Size(432, 206);
            this.OrdersDataGridView.TabIndex = 30;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.DataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.DataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            this.DataGridViewTextBoxColumn1.Width = 125;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.DataPropertyName = "OrderAmount";
            this.DataGridViewTextBoxColumn2.HeaderText = "OrderAmount";
            this.DataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            this.DataGridViewTextBoxColumn2.Width = 125;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.DataPropertyName = "DateOfOrder";
            this.DataGridViewTextBoxColumn3.HeaderText = "DateOfOrder";
            this.DataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            this.DataGridViewTextBoxColumn3.Width = 125;
            // 
            // OrdersBindingSource
            // 
            this.OrdersBindingSource.DataMember = "Orders";
            this.OrdersBindingSource.DataSource = this.FreeStyleDBDataSet;
            // 
            // OrderFluidInfoDataGridView
            // 
            this.OrderFluidInfoDataGridView.AutoGenerateColumns = false;
            this.OrderFluidInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderFluidInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn10,
            this.DataGridViewTextBoxColumn11,
            this.DataGridViewTextBoxColumn12,
            this.DataGridViewTextBoxColumn13});
            this.OrderFluidInfoDataGridView.DataSource = this.OrderFluidInfoBindingSource;
            this.OrderFluidInfoDataGridView.Location = new System.Drawing.Point(1009, 527);
            this.OrderFluidInfoDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderFluidInfoDataGridView.Name = "OrderFluidInfoDataGridView";
            this.OrderFluidInfoDataGridView.RowHeadersWidth = 51;
            this.OrderFluidInfoDataGridView.RowTemplate.Height = 24;
            this.OrderFluidInfoDataGridView.Size = new System.Drawing.Size(432, 220);
            this.OrderFluidInfoDataGridView.TabIndex = 31;
            // 
            // DataGridViewTextBoxColumn10
            // 
            this.DataGridViewTextBoxColumn10.DataPropertyName = "OrderID";
            this.DataGridViewTextBoxColumn10.HeaderText = "OrderID";
            this.DataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
            this.DataGridViewTextBoxColumn10.Width = 125;
            // 
            // DataGridViewTextBoxColumn11
            // 
            this.DataGridViewTextBoxColumn11.DataPropertyName = "FluidID";
            this.DataGridViewTextBoxColumn11.HeaderText = "FluidID";
            this.DataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            this.DataGridViewTextBoxColumn11.Width = 125;
            // 
            // DataGridViewTextBoxColumn12
            // 
            this.DataGridViewTextBoxColumn12.DataPropertyName = "IsFluidMix";
            this.DataGridViewTextBoxColumn12.HeaderText = "IsFluidMix";
            this.DataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
            this.DataGridViewTextBoxColumn12.Width = 125;
            // 
            // DataGridViewTextBoxColumn13
            // 
            this.DataGridViewTextBoxColumn13.DataPropertyName = "UsedOz";
            this.DataGridViewTextBoxColumn13.HeaderText = "UsedOz";
            this.DataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            this.DataGridViewTextBoxColumn13.Width = 125;
            // 
            // OrderFluidInfoBindingSource
            // 
            this.OrderFluidInfoBindingSource.DataMember = "OrderFluidInfo";
            this.OrderFluidInfoBindingSource.DataSource = this.FreeStyleDBDataSet;
            // 
            // InventoryDataGridView
            // 
            this.InventoryDataGridView.AutoGenerateColumns = false;
            this.InventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn6,
            this.DataGridViewTextBoxColumn7,
            this.DataGridViewTextBoxColumn8,
            this.DataGridViewTextBoxColumn9,
            this.DataGridViewTextBoxColumn14});
            this.InventoryDataGridView.DataSource = this.InventoryBindingSource;
            this.InventoryDataGridView.Location = new System.Drawing.Point(1009, 50);
            this.InventoryDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InventoryDataGridView.Name = "InventoryDataGridView";
            this.InventoryDataGridView.RowHeadersWidth = 51;
            this.InventoryDataGridView.RowTemplate.Height = 24;
            this.InventoryDataGridView.Size = new System.Drawing.Size(432, 220);
            this.InventoryDataGridView.TabIndex = 31;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.DataPropertyName = "FluidID";
            this.DataGridViewTextBoxColumn4.HeaderText = "FluidID";
            this.DataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.Width = 125;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.DataPropertyName = "FluidName";
            this.DataGridViewTextBoxColumn5.HeaderText = "FluidName";
            this.DataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.Width = 125;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.DataPropertyName = "FluidType";
            this.DataGridViewTextBoxColumn6.HeaderText = "FluidType";
            this.DataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.Width = 125;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.DataPropertyName = "Capacity(oz)";
            this.DataGridViewTextBoxColumn7.HeaderText = "Capacity(oz)";
            this.DataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.Width = 125;
            // 
            // DataGridViewTextBoxColumn8
            // 
            this.DataGridViewTextBoxColumn8.DataPropertyName = "CurrentAmount";
            this.DataGridViewTextBoxColumn8.HeaderText = "CurrentAmount";
            this.DataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            this.DataGridViewTextBoxColumn8.Width = 125;
            // 
            // DataGridViewTextBoxColumn9
            // 
            this.DataGridViewTextBoxColumn9.DataPropertyName = "ExpirationDate";
            this.DataGridViewTextBoxColumn9.HeaderText = "ExpirationDate";
            this.DataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
            this.DataGridViewTextBoxColumn9.Width = 125;
            // 
            // DataGridViewTextBoxColumn14
            // 
            this.DataGridViewTextBoxColumn14.DataPropertyName = "Last Fill Date";
            this.DataGridViewTextBoxColumn14.HeaderText = "Last Fill Date";
            this.DataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
            this.DataGridViewTextBoxColumn14.Width = 125;
            // 
            // btnMaintenanceRp
            // 
            this.btnMaintenanceRp.BackColor = System.Drawing.Color.Chocolate;
            this.btnMaintenanceRp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenanceRp.Location = new System.Drawing.Point(64, 539);
            this.btnMaintenanceRp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaintenanceRp.Name = "btnMaintenanceRp";
            this.btnMaintenanceRp.Size = new System.Drawing.Size(163, 47);
            this.btnMaintenanceRp.TabIndex = 32;
            this.btnMaintenanceRp.Text = "M&aintenance Report";
            this.btnMaintenanceRp.UseVisualStyleBackColor = false;
            this.btnMaintenanceRp.Click += new System.EventHandler(this.btnMaintenanceRp_Click);
            // 
            // btnLocationMgRp
            // 
            this.btnLocationMgRp.BackColor = System.Drawing.Color.Chocolate;
            this.btnLocationMgRp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocationMgRp.Location = new System.Drawing.Point(64, 668);
            this.btnLocationMgRp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLocationMgRp.Name = "btnLocationMgRp";
            this.btnLocationMgRp.Size = new System.Drawing.Size(163, 47);
            this.btnLocationMgRp.TabIndex = 33;
            this.btnLocationMgRp.Text = "&Location Management Report";
            this.btnLocationMgRp.UseVisualStyleBackColor = false;
            this.btnLocationMgRp.Click += new System.EventHandler(this.btnLocationMgRp_Click);
            // 
            // cklbInventory
            // 
            this.cklbInventory.FormattingEnabled = true;
            this.cklbInventory.Items.AddRange(new object[] {
            "Cola",
            "Diet Cola",
            "Zero Cola",
            "Fanta",
            "DrPepper",
            "Sprite",
            "Zero Sprite",
            "Minute Maid",
            "Zero Minute Maid",
            "RootBeer",
            "Co2"});
            this.cklbInventory.Location = new System.Drawing.Point(233, 410);
            this.cklbInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cklbInventory.Name = "cklbInventory";
            this.cklbInventory.Size = new System.Drawing.Size(173, 191);
            this.cklbInventory.TabIndex = 9;
            // 
            // btnOrderInventoryAfterSelection
            // 
            this.btnOrderInventoryAfterSelection.Location = new System.Drawing.Point(239, 624);
            this.btnOrderInventoryAfterSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderInventoryAfterSelection.Name = "btnOrderInventoryAfterSelection";
            this.btnOrderInventoryAfterSelection.Size = new System.Drawing.Size(124, 32);
            this.btnOrderInventoryAfterSelection.TabIndex = 34;
            this.btnOrderInventoryAfterSelection.Text = "Order &Inventory";
            this.btnOrderInventoryAfterSelection.UseVisualStyleBackColor = true;
            this.btnOrderInventoryAfterSelection.Click += new System.EventHandler(this.btnOrderInventoryAfterSelection_Click);
            // 
            // DTPStart
            // 
            this.DTPStart.Location = new System.Drawing.Point(233, 598);
            this.DTPStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPStart.Name = "DTPStart";
            this.DTPStart.Size = new System.Drawing.Size(272, 22);
            this.DTPStart.TabIndex = 35;
            this.DTPStart.Visible = false;
            // 
            // DTPEnd
            // 
            this.DTPEnd.Location = new System.Drawing.Point(233, 654);
            this.DTPEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPEnd.Name = "DTPEnd";
            this.DTPEnd.Size = new System.Drawing.Size(272, 22);
            this.DTPEnd.TabIndex = 36;
            this.DTPEnd.Visible = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStartDate.Location = new System.Drawing.Point(235, 575);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 16);
            this.lblStartDate.TabIndex = 37;
            this.lblStartDate.Text = "&Start Date:";
            this.lblStartDate.Visible = false;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEndDate.Location = new System.Drawing.Point(235, 626);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(66, 16);
            this.lblEndDate.TabIndex = 38;
            this.lblEndDate.Text = "&End Date:";
            this.lblEndDate.Visible = false;
            // 
            // btnGetOrderReport
            // 
            this.btnGetOrderReport.Location = new System.Drawing.Point(239, 681);
            this.btnGetOrderReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetOrderReport.Name = "btnGetOrderReport";
            this.btnGetOrderReport.Size = new System.Drawing.Size(124, 34);
            this.btnGetOrderReport.TabIndex = 39;
            this.btnGetOrderReport.Text = "&Get Report";
            this.btnGetOrderReport.UseVisualStyleBackColor = true;
            this.btnGetOrderReport.Visible = false;
            this.btnGetOrderReport.Click += new System.EventHandler(this.btnGetOrderReport_Click);
            // 
            // InventoryTableAdapter
            // 
            this.InventoryTableAdapter.ClearBeforeFill = true;
            // 
            // TableAdapterManager
            // 
            this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.TableAdapterManager.InventoryTableAdapter = this.InventoryTableAdapter;
            this.TableAdapterManager.OrderFluidInfoTableAdapter = this.OrderFluidInfoTableAdapter;
            this.TableAdapterManager.OrdersTableAdapter = this.OrdersTableAdapter;
            this.TableAdapterManager.UpdateOrder = Coca_Cola_Project.FreeStyleDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // OrderFluidInfoTableAdapter
            // 
            this.OrderFluidInfoTableAdapter.ClearBeforeFill = true;
            // 
            // OrdersTableAdapter
            // 
            this.OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // DataGridViewTextBoxColumn17
            // 
            this.DataGridViewTextBoxColumn17.DataPropertyName = "DateOfOrder";
            this.DataGridViewTextBoxColumn17.HeaderText = "DateOfOrder";
            this.DataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
            this.DataGridViewTextBoxColumn17.Width = 125;
            // 
            // DataGridViewTextBoxColumn16
            // 
            this.DataGridViewTextBoxColumn16.DataPropertyName = "OrderAmount";
            this.DataGridViewTextBoxColumn16.HeaderText = "OrderAmount";
            this.DataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
            this.DataGridViewTextBoxColumn16.Width = 125;
            // 
            // DataGridViewTextBoxColumn15
            // 
            this.DataGridViewTextBoxColumn15.DataPropertyName = "OrderID";
            this.DataGridViewTextBoxColumn15.HeaderText = "OrderID";
            this.DataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
            this.DataGridViewTextBoxColumn15.ReadOnly = true;
            this.DataGridViewTextBoxColumn15.Width = 125;
            // 
            // OrdersDataGridViewWDP
            // 
            this.OrdersDataGridViewWDP.AutoGenerateColumns = false;
            this.OrdersDataGridViewWDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridViewWDP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn15,
            this.DataGridViewTextBoxColumn16,
            this.DataGridViewTextBoxColumn17});
            this.OrdersDataGridViewWDP.DataSource = this.OrdersBindingSource;
            this.OrdersDataGridViewWDP.Location = new System.Drawing.Point(1461, 93);
            this.OrdersDataGridViewWDP.Name = "OrdersDataGridViewWDP";
            this.OrdersDataGridViewWDP.RowHeadersWidth = 51;
            this.OrdersDataGridViewWDP.RowTemplate.Height = 24;
            this.OrdersDataGridViewWDP.Size = new System.Drawing.Size(388, 233);
            this.OrdersDataGridViewWDP.TabIndex = 41;
            // 
            // StartDateToolStripLabel
            // 
            this.StartDateToolStripLabel.Name = "StartDateToolStripLabel";
            this.StartDateToolStripLabel.Size = new System.Drawing.Size(75, 28);
            this.StartDateToolStripLabel.Text = "StartDate:";
            // 
            // StartDateToolStripTextBox
            // 
            this.StartDateToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartDateToolStripTextBox.Name = "StartDateToolStripTextBox";
            this.StartDateToolStripTextBox.Size = new System.Drawing.Size(100, 31);
            // 
            // EndDateToolStripLabel
            // 
            this.EndDateToolStripLabel.Name = "EndDateToolStripLabel";
            this.EndDateToolStripLabel.Size = new System.Drawing.Size(69, 28);
            this.EndDateToolStripLabel.Text = "EndDate:";
            // 
            // EndDateToolStripTextBox
            // 
            this.EndDateToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EndDateToolStripTextBox.Name = "EndDateToolStripTextBox";
            this.EndDateToolStripTextBox.Size = new System.Drawing.Size(100, 31);
            // 
            // FillByOrdersToolStripButton
            // 
            this.FillByOrdersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FillByOrdersToolStripButton.Name = "FillByOrdersToolStripButton";
            this.FillByOrdersToolStripButton.Size = new System.Drawing.Size(92, 28);
            this.FillByOrdersToolStripButton.Text = "FillByOrders";
            this.FillByOrdersToolStripButton.Click += new System.EventHandler(this.FillByOrdersToolStripButton_Click_1);
            // 
            // FillByOrdersToolStrip
            // 
            this.FillByOrdersToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FillByOrdersToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartDateToolStripLabel,
            this.StartDateToolStripTextBox,
            this.EndDateToolStripLabel,
            this.EndDateToolStripTextBox,
            this.FillByOrdersToolStripButton});
            this.FillByOrdersToolStrip.Location = new System.Drawing.Point(0, 31);
            this.FillByOrdersToolStrip.Name = "FillByOrdersToolStrip";
            this.FillByOrdersToolStrip.Size = new System.Drawing.Size(1002, 31);
            this.FillByOrdersToolStrip.TabIndex = 42;
            this.FillByOrdersToolStrip.Text = "FillByOrdersToolStrip";
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.BindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMovePreviousItem.Image")));
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.BindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "Position";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 27);
            this.BindingNavigatorPositionItem.Text = "0";
            this.BindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.BindingNavigatorCountItem.Text = "of {0}";
            this.BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.BindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveLastItem.Image")));
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.BindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // BindingNavigatorAddNewItem
            // 
            this.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorAddNewItem.Image")));
            this.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem";
            this.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.BindingNavigatorAddNewItem.Text = "Add new";
            // 
            // BindingNavigatorDeleteItem
            // 
            this.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorDeleteItem.Image")));
            this.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
            this.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.BindingNavigatorDeleteItem.Text = "Delete";
            // 
            // InventoryBindingNavigatorSaveItem
            // 
            this.InventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InventoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("InventoryBindingNavigatorSaveItem.Image")));
            this.InventoryBindingNavigatorSaveItem.Name = "InventoryBindingNavigatorSaveItem";
            this.InventoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.InventoryBindingNavigatorSaveItem.Text = "Save Data";
            this.InventoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.InventoryBindingNavigatorSaveItem_Click);
            // 
            // InventoryBindingNavigator
            // 
            this.InventoryBindingNavigator.AddNewItem = this.BindingNavigatorAddNewItem;
            this.InventoryBindingNavigator.BindingSource = this.InventoryBindingSource;
            this.InventoryBindingNavigator.CountItem = this.BindingNavigatorCountItem;
            this.InventoryBindingNavigator.DeleteItem = this.BindingNavigatorDeleteItem;
            this.InventoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.InventoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorMoveFirstItem,
            this.BindingNavigatorMovePreviousItem,
            this.BindingNavigatorSeparator,
            this.BindingNavigatorPositionItem,
            this.BindingNavigatorCountItem,
            this.BindingNavigatorSeparator1,
            this.BindingNavigatorMoveNextItem,
            this.BindingNavigatorMoveLastItem,
            this.BindingNavigatorSeparator2,
            this.BindingNavigatorAddNewItem,
            this.BindingNavigatorDeleteItem,
            this.InventoryBindingNavigatorSaveItem});
            this.InventoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.InventoryBindingNavigator.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.InventoryBindingNavigator.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.InventoryBindingNavigator.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.InventoryBindingNavigator.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.InventoryBindingNavigator.Name = "InventoryBindingNavigator";
            this.InventoryBindingNavigator.PositionItem = this.BindingNavigatorPositionItem;
            this.InventoryBindingNavigator.Size = new System.Drawing.Size(1002, 31);
            this.InventoryBindingNavigator.TabIndex = 30;
            this.InventoryBindingNavigator.Text = "BindingNavigator1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1002, 785);
            this.Controls.Add(this.FillByOrdersToolStrip);
            this.Controls.Add(this.OrdersDataGridViewWDP);
            this.Controls.Add(this.btnGetOrderReport);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.DTPEnd);
            this.Controls.Add(this.DTPStart);
            this.Controls.Add(this.btnOrderInventoryAfterSelection);
            this.Controls.Add(this.cklbInventory);
            this.Controls.Add(this.btnLocationMgRp);
            this.Controls.Add(this.btnMaintenanceRp);
            this.Controls.Add(this.InventoryDataGridView);
            this.Controls.Add(this.OrderFluidInfoDataGridView);
            this.Controls.Add(this.OrdersDataGridView);
            this.Controls.Add(this.InventoryBindingNavigator);
            this.Controls.Add(this.lblFlavorCount);
            this.Controls.Add(this.btnResetFlavors);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.btnMixDisp);
            this.Controls.Add(this.btnOrderRp);
            this.Controls.Add(this.btnInventoryRp);
            this.Controls.Add(this.btnReOrder);
            this.Controls.Add(this.picRootBeer);
            this.Controls.Add(this.picMMLemonZero);
            this.Controls.Add(this.picMMLemon);
            this.Controls.Add(this.picSpriteZero);
            this.Controls.Add(this.picSprite);
            this.Controls.Add(this.picDrPepper);
            this.Controls.Add(this.picFanta);
            this.Controls.Add(this.picColaZero);
            this.Controls.Add(this.picColaDiet);
            this.Controls.Add(this.picCola);
            this.Controls.Add(this.lblSprite);
            this.Controls.Add(this.lblSpriteZero);
            this.Controls.Add(this.lblMntMaid);
            this.Controls.Add(this.lblMntMaidZero);
            this.Controls.Add(this.lblRootBeer);
            this.Controls.Add(this.lblDrPepper);
            this.Controls.Add(this.lblFanta);
            this.Controls.Add(this.lblZeroCola);
            this.Controls.Add(this.lblDietCola);
            this.Controls.Add(this.lblCola);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Free Style";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColaDiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColaZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrPepper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpriteZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMMLemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMMLemonZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRootBeer)).EndInit();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeStyleDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFluidInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFluidInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridViewWDP)).EndInit();
            this.FillByOrdersToolStrip.ResumeLayout(false);
            this.FillByOrdersToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryBindingNavigator)).EndInit();
            this.InventoryBindingNavigator.ResumeLayout(false);
            this.InventoryBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal PictureBox picCola;
        internal PictureBox picColaDiet;
        internal PictureBox picColaZero;
        internal PictureBox picFanta;
        internal PictureBox picDrPepper;
        internal PictureBox picSprite;
        internal PictureBox picSpriteZero;
        internal PictureBox picMMLemon;
        internal PictureBox picMMLemonZero;
        internal PictureBox picRootBeer;
        internal Button btnReOrder;
        internal Button btnInventoryRp;
        internal Button btnOrderRp;
        internal Button btnMixDisp;
        internal Label lblSize;
        internal GroupBox grpSize;
        internal Button btnBack;
        internal Button btnExit;
        internal Button btnResetFlavors;
        internal Label lblFlavorCount;
        internal RadioButton rdThirtyTwoOz;
        internal RadioButton rdTwentyFourOz;
        internal RadioButton rdSixTeenOz;
        internal RadioButton rdEightOz;
        internal Label lblCola;
        internal Label lblDietCola;
        internal Label lblZeroCola;
        internal Label lblFanta;
        internal Label lblDrPepper;
        internal Label lblRootBeer;
        internal Label lblMntMaidZero;
        internal Label lblMntMaid;
        internal Label lblSpriteZero;
        internal Label lblSprite;
        internal FreeStyleDBDataSet FreeStyleDBDataSet;
        internal BindingSource InventoryBindingSource;
        internal FreeStyleDBDataSetTableAdapters.InventoryTableAdapter InventoryTableAdapter;
        internal FreeStyleDBDataSetTableAdapters.TableAdapterManager TableAdapterManager;
        internal FreeStyleDBDataSetTableAdapters.OrderFluidInfoTableAdapter OrderFluidInfoTableAdapter;
        internal BindingSource OrderFluidInfoBindingSource;
        internal FreeStyleDBDataSetTableAdapters.OrdersTableAdapter OrdersTableAdapter;
        internal BindingSource OrdersBindingSource;
        internal DataGridView OrdersDataGridView;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridView OrderFluidInfoDataGridView;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
        internal DataGridView InventoryDataGridView;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn14;
        internal Button btnMaintenanceRp;
        internal Button btnLocationMgRp;
        internal CheckedListBox cklbInventory;
        internal Button btnOrderInventoryAfterSelection;
        internal DateTimePicker DTPStart;
        internal DateTimePicker DTPEnd;
        internal Label lblStartDate;
        internal Label lblEndDate;
        internal Button btnGetOrderReport;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn17;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn16;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn15;
        internal DataGridView OrdersDataGridViewWDP;
        internal ToolStripLabel StartDateToolStripLabel;
        internal ToolStripTextBox StartDateToolStripTextBox;
        internal ToolStripLabel EndDateToolStripLabel;
        internal ToolStripTextBox EndDateToolStripTextBox;
        internal ToolStripButton FillByOrdersToolStripButton;
        internal ToolStrip FillByOrdersToolStrip;
        internal ToolStripButton BindingNavigatorMoveFirstItem;
        internal ToolStripButton BindingNavigatorMovePreviousItem;
        internal ToolStripSeparator BindingNavigatorSeparator;
        internal ToolStripTextBox BindingNavigatorPositionItem;
        internal ToolStripLabel BindingNavigatorCountItem;
        internal ToolStripSeparator BindingNavigatorSeparator1;
        internal ToolStripButton BindingNavigatorMoveNextItem;
        internal ToolStripButton BindingNavigatorMoveLastItem;
        internal ToolStripSeparator BindingNavigatorSeparator2;
        internal ToolStripButton BindingNavigatorAddNewItem;
        internal ToolStripButton BindingNavigatorDeleteItem;
        internal ToolStripButton InventoryBindingNavigatorSaveItem;
        internal BindingNavigator InventoryBindingNavigator;
    }
}
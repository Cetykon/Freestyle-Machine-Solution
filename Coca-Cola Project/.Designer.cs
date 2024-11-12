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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            picCola = new PictureBox();
            picCola.Click += new EventHandler(picCola_Click);
            picColaDiet = new PictureBox();
            picColaDiet.Click += new EventHandler(picColaDiet_Click);
            picColaZero = new PictureBox();
            picColaZero.Click += new EventHandler(picColaZero_Click);
            picFanta = new PictureBox();
            picFanta.Click += new EventHandler(picFanta_Click);
            picDrPepper = new PictureBox();
            picDrPepper.Click += new EventHandler(picDrPepper_Click);
            picSprite = new PictureBox();
            picSprite.Click += new EventHandler(picSprite_Click);
            picSpriteZero = new PictureBox();
            picSpriteZero.Click += new EventHandler(picSpriteZero_Click);
            picMMLemon = new PictureBox();
            picMMLemon.Click += new EventHandler(picMMLemon_Click);
            picMMLemonZero = new PictureBox();
            picMMLemonZero.Click += new EventHandler(picMMLemonZero_Click);
            picRootBeer = new PictureBox();
            picRootBeer.Click += new EventHandler(picRootBeer_Click);
            btnReOrder = new Button();
            btnReOrder.Click += new EventHandler(btnReOrder_Click);
            btnInventoryRp = new Button();
            btnInventoryRp.Click += new EventHandler(btnSyrupSt_Click);
            btnOrderRp = new Button();
            btnOrderRp.Click += new EventHandler(btnSodaSt_Click);
            btnMixDisp = new Button();
            btnMixDisp.Click += new EventHandler(btnMixDisp_Click);
            lblSize = new Label();
            grpSize = new GroupBox();
            rdThirtyTwoOz = new RadioButton();
            rdThirtyTwoOz.Click += new EventHandler(rdThirtyTwoOz_Click);
            rdTwentyFourOz = new RadioButton();
            rdTwentyFourOz.Click += new EventHandler(rdTwentyFourOz_Click);
            rdSixTeenOz = new RadioButton();
            rdSixTeenOz.Click += new EventHandler(rdSixTeenOz_Click);
            rdEightOz = new RadioButton();
            rdEightOz.Click += new EventHandler(rdEightOz_Click);
            btnBack = new Button();
            btnBack.Click += new EventHandler(btnBack_Click);
            btnExit = new Button();
            btnExit.Click += new EventHandler(Button1_Click);
            btnResetFlavors = new Button();
            btnResetFlavors.Click += new EventHandler(btnResetFlavors_Click);
            lblFlavorCount = new Label();
            lblCola = new Label();
            lblDietCola = new Label();
            lblZeroCola = new Label();
            lblFanta = new Label();
            lblDrPepper = new Label();
            lblRootBeer = new Label();
            lblMntMaidZero = new Label();
            lblMntMaid = new Label();
            lblSpriteZero = new Label();
            lblSprite = new Label();
            InventoryBindingSource = new BindingSource(components);
            FreeStyleDBDataSet = new FreeStyleDBDataSet();
            OrdersDataGridView = new DataGridView();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            OrdersBindingSource = new BindingSource(components);
            OrderFluidInfoDataGridView = new DataGridView();
            DataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            OrderFluidInfoBindingSource = new BindingSource(components);
            InventoryDataGridView = new DataGridView();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            btnMaintenanceRp = new Button();
            btnMaintenanceRp.Click += new EventHandler(btnMaintenanceRp_Click);
            btnLocationMgRp = new Button();
            btnLocationMgRp.Click += new EventHandler(btnLocationMgRp_Click);
            cklbInventory = new CheckedListBox();
            btnOrderInventoryAfterSelection = new Button();
            btnOrderInventoryAfterSelection.Click += new EventHandler(btnOrderInventoryAfterSelection_Click);
            DTPStart = new DateTimePicker();
            DTPEnd = new DateTimePicker();
            lblStartDate = new Label();
            lblEndDate = new Label();
            btnGetOrderReport = new Button();
            btnGetOrderReport.Click += new EventHandler(btnGetOrderReport_Click);
            InventoryTableAdapter = new FreeStyleDBDataSetTableAdapters.InventoryTableAdapter();
            TableAdapterManager = new FreeStyleDBDataSetTableAdapters.TableAdapterManager();
            OrderFluidInfoTableAdapter = new FreeStyleDBDataSetTableAdapters.OrderFluidInfoTableAdapter();
            OrdersTableAdapter = new FreeStyleDBDataSetTableAdapters.OrdersTableAdapter();
            DataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            OrdersDataGridViewWDP = new DataGridView();
            StartDateToolStripLabel = new ToolStripLabel();
            StartDateToolStripTextBox = new ToolStripTextBox();
            EndDateToolStripLabel = new ToolStripLabel();
            EndDateToolStripTextBox = new ToolStripTextBox();
            FillByOrdersToolStripButton = new ToolStripButton();
            FillByOrdersToolStripButton.Click += new EventHandler(FillByOrdersToolStripButton_Click_1);
            FillByOrdersToolStrip = new ToolStrip();
            BindingNavigatorMoveFirstItem = new ToolStripButton();
            BindingNavigatorMovePreviousItem = new ToolStripButton();
            BindingNavigatorSeparator = new ToolStripSeparator();
            BindingNavigatorPositionItem = new ToolStripTextBox();
            BindingNavigatorCountItem = new ToolStripLabel();
            BindingNavigatorSeparator1 = new ToolStripSeparator();
            BindingNavigatorMoveNextItem = new ToolStripButton();
            BindingNavigatorMoveLastItem = new ToolStripButton();
            BindingNavigatorSeparator2 = new ToolStripSeparator();
            BindingNavigatorAddNewItem = new ToolStripButton();
            BindingNavigatorDeleteItem = new ToolStripButton();
            InventoryBindingNavigatorSaveItem = new ToolStripButton();
            InventoryBindingNavigatorSaveItem.Click += new EventHandler(InventoryBindingNavigatorSaveItem_Click);
            InventoryBindingNavigator = new BindingNavigator(components);
            ((System.ComponentModel.ISupportInitialize)picCola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picColaDiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picColaZero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFanta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDrPepper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSprite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSpriteZero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMMLemon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMMLemonZero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRootBeer).BeginInit();
            grpSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InventoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FreeStyleDBDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrdersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderFluidInfoDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderFluidInfoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InventoryDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridViewWDP).BeginInit();
            FillByOrdersToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InventoryBindingNavigator).BeginInit();
            InventoryBindingNavigator.SuspendLayout();
            SuspendLayout();
            // 
            // picCola
            // 
            picCola.Image = (Image)resources.GetObject("picCola.Image");
            picCola.Location = new Point(53, 43);
            picCola.Margin = new Padding(3, 2, 3, 2);
            picCola.Name = "picCola";
            picCola.Size = new Size(163, 148);
            picCola.SizeMode = PictureBoxSizeMode.Zoom;
            picCola.TabIndex = 0;
            picCola.TabStop = false;
            // 
            // picColaDiet
            // 
            picColaDiet.Image = (Image)resources.GetObject("picColaDiet.Image");
            picColaDiet.Location = new Point(243, 43);
            picColaDiet.Margin = new Padding(3, 2, 3, 2);
            picColaDiet.Name = "picColaDiet";
            picColaDiet.Size = new Size(163, 148);
            picColaDiet.SizeMode = PictureBoxSizeMode.Zoom;
            picColaDiet.TabIndex = 1;
            picColaDiet.TabStop = false;
            // 
            // picColaZero
            // 
            picColaZero.Image = (Image)resources.GetObject("picColaZero.Image");
            picColaZero.Location = new Point(432, 43);
            picColaZero.Margin = new Padding(3, 2, 3, 2);
            picColaZero.Name = "picColaZero";
            picColaZero.Size = new Size(163, 148);
            picColaZero.SizeMode = PictureBoxSizeMode.Zoom;
            picColaZero.TabIndex = 2;
            picColaZero.TabStop = false;
            // 
            // picFanta
            // 
            picFanta.Image = (Image)resources.GetObject("picFanta.Image");
            picFanta.Location = new Point(621, 43);
            picFanta.Margin = new Padding(3, 2, 3, 2);
            picFanta.Name = "picFanta";
            picFanta.Size = new Size(163, 148);
            picFanta.SizeMode = PictureBoxSizeMode.Zoom;
            picFanta.TabIndex = 3;
            picFanta.TabStop = false;
            // 
            // picDrPepper
            // 
            picDrPepper.Image = (Image)resources.GetObject("picDrPepper.Image");
            picDrPepper.Location = new Point(811, 43);
            picDrPepper.Margin = new Padding(3, 2, 3, 2);
            picDrPepper.Name = "picDrPepper";
            picDrPepper.Size = new Size(163, 148);
            picDrPepper.SizeMode = PictureBoxSizeMode.Zoom;
            picDrPepper.TabIndex = 4;
            picDrPepper.TabStop = false;
            // 
            // picSprite
            // 
            picSprite.Image = (Image)resources.GetObject("picSprite.Image");
            picSprite.Location = new Point(53, 233);
            picSprite.Margin = new Padding(3, 2, 3, 2);
            picSprite.Name = "picSprite";
            picSprite.Size = new Size(163, 148);
            picSprite.SizeMode = PictureBoxSizeMode.Zoom;
            picSprite.TabIndex = 5;
            picSprite.TabStop = false;
            // 
            // picSpriteZero
            // 
            picSpriteZero.Image = (Image)resources.GetObject("picSpriteZero.Image");
            picSpriteZero.Location = new Point(243, 233);
            picSpriteZero.Margin = new Padding(3, 2, 3, 2);
            picSpriteZero.Name = "picSpriteZero";
            picSpriteZero.Size = new Size(163, 148);
            picSpriteZero.SizeMode = PictureBoxSizeMode.Zoom;
            picSpriteZero.TabIndex = 6;
            picSpriteZero.TabStop = false;
            // 
            // picMMLemon
            // 
            picMMLemon.Image = (Image)resources.GetObject("picMMLemon.Image");
            picMMLemon.Location = new Point(432, 233);
            picMMLemon.Margin = new Padding(3, 2, 3, 2);
            picMMLemon.Name = "picMMLemon";
            picMMLemon.Size = new Size(163, 148);
            picMMLemon.SizeMode = PictureBoxSizeMode.Zoom;
            picMMLemon.TabIndex = 7;
            picMMLemon.TabStop = false;
            // 
            // picMMLemonZero
            // 
            picMMLemonZero.Image = (Image)resources.GetObject("picMMLemonZero.Image");
            picMMLemonZero.Location = new Point(621, 233);
            picMMLemonZero.Margin = new Padding(3, 2, 3, 2);
            picMMLemonZero.Name = "picMMLemonZero";
            picMMLemonZero.Size = new Size(163, 148);
            picMMLemonZero.SizeMode = PictureBoxSizeMode.Zoom;
            picMMLemonZero.TabIndex = 8;
            picMMLemonZero.TabStop = false;
            // 
            // picRootBeer
            // 
            picRootBeer.Image = (Image)resources.GetObject("picRootBeer.Image");
            picRootBeer.Location = new Point(811, 233);
            picRootBeer.Margin = new Padding(3, 2, 3, 2);
            picRootBeer.Name = "picRootBeer";
            picRootBeer.Size = new Size(163, 148);
            picRootBeer.SizeMode = PictureBoxSizeMode.Zoom;
            picRootBeer.TabIndex = 9;
            picRootBeer.TabStop = false;
            // 
            // btnReOrder
            // 
            btnReOrder.Location = new Point(64, 414);
            btnReOrder.Margin = new Padding(3, 2, 3, 2);
            btnReOrder.Name = "btnReOrder";
            btnReOrder.Size = new Size(163, 47);
            btnReOrder.TabIndex = 0;
            btnReOrder.Text = "&Reorder Inventory";
            btnReOrder.UseVisualStyleBackColor = true;
            // 
            // btnInventoryRp
            // 
            btnInventoryRp.Location = new Point(64, 478);
            btnInventoryRp.Margin = new Padding(3, 2, 3, 2);
            btnInventoryRp.Name = "btnInventoryRp";
            btnInventoryRp.Size = new Size(163, 47);
            btnInventoryRp.TabIndex = 1;
            btnInventoryRp.Text = "&Fluid Lvl Report";
            btnInventoryRp.UseVisualStyleBackColor = true;
            // 
            // btnOrderRp
            // 
            btnOrderRp.Location = new Point(64, 602);
            btnOrderRp.Margin = new Padding(3, 2, 3, 2);
            btnOrderRp.Name = "btnOrderRp";
            btnOrderRp.Size = new Size(163, 48);
            btnOrderRp.TabIndex = 2;
            btnOrderRp.Text = "&Order Report";
            btnOrderRp.UseVisualStyleBackColor = true;
            // 
            // btnMixDisp
            // 
            btnMixDisp.Location = new Point(781, 551);
            btnMixDisp.Margin = new Padding(3, 2, 3, 2);
            btnMixDisp.Name = "btnMixDisp";
            btnMixDisp.Size = new Size(181, 119);
            btnMixDisp.TabIndex = 5;
            btnMixDisp.Text = "&Mix Flavors / Dispense";
            btnMixDisp.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            lblSize.BorderStyle = BorderStyle.FixedSingle;
            lblSize.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSize.ForeColor = Color.White;
            lblSize.Location = new Point(21, 39);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(195, 41);
            lblSize.TabIndex = 0;
            lblSize.Text = "Choose Your Size:";
            // 
            // grpSize
            // 
            grpSize.Controls.Add(rdThirtyTwoOz);
            grpSize.Controls.Add(rdTwentyFourOz);
            grpSize.Controls.Add(rdSixTeenOz);
            grpSize.Controls.Add(rdEightOz);
            grpSize.Controls.Add(btnBack);
            grpSize.Controls.Add(lblSize);
            grpSize.Location = new Point(325, 402);
            grpSize.Margin = new Padding(3, 2, 3, 2);
            grpSize.Name = "grpSize";
            grpSize.Padding = new Padding(3, 2, 3, 2);
            grpSize.Size = new Size(395, 345);
            grpSize.TabIndex = 6;
            grpSize.TabStop = false;
            // 
            // rdThirtyTwoOz
            // 
            rdThirtyTwoOz.AutoSize = true;
            rdThirtyTwoOz.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdThirtyTwoOz.ForeColor = Color.White;
            rdThirtyTwoOz.Location = new Point(304, 208);
            rdThirtyTwoOz.Margin = new Padding(3, 2, 3, 2);
            rdThirtyTwoOz.Name = "rdThirtyTwoOz";
            rdThirtyTwoOz.Size = new Size(76, 28);
            rdThirtyTwoOz.TabIndex = 8;
            rdThirtyTwoOz.TabStop = true;
            rdThirtyTwoOz.Text = "32 oz";
            rdThirtyTwoOz.UseVisualStyleBackColor = true;
            // 
            // rdTwentyFourOz
            // 
            rdTwentyFourOz.AutoSize = true;
            rdTwentyFourOz.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdTwentyFourOz.ForeColor = Color.White;
            rdTwentyFourOz.Location = new Point(304, 156);
            rdTwentyFourOz.Margin = new Padding(3, 2, 3, 2);
            rdTwentyFourOz.Name = "rdTwentyFourOz";
            rdTwentyFourOz.Size = new Size(76, 28);
            rdTwentyFourOz.TabIndex = 7;
            rdTwentyFourOz.TabStop = true;
            rdTwentyFourOz.Text = "24 oz";
            rdTwentyFourOz.UseVisualStyleBackColor = true;
            // 
            // rdSixTeenOz
            // 
            rdSixTeenOz.AutoSize = true;
            rdSixTeenOz.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdSixTeenOz.ForeColor = Color.White;
            rdSixTeenOz.Location = new Point(304, 103);
            rdSixTeenOz.Margin = new Padding(3, 2, 3, 2);
            rdSixTeenOz.Name = "rdSixTeenOz";
            rdSixTeenOz.Size = new Size(76, 28);
            rdSixTeenOz.TabIndex = 6;
            rdSixTeenOz.TabStop = true;
            rdSixTeenOz.Text = "16 oz";
            rdSixTeenOz.UseVisualStyleBackColor = true;
            // 
            // rdEightOz
            // 
            rdEightOz.AutoSize = true;
            rdEightOz.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdEightOz.ForeColor = Color.White;
            rdEightOz.Location = new Point(304, 52);
            rdEightOz.Margin = new Padding(3, 2, 3, 2);
            rdEightOz.Name = "rdEightOz";
            rdEightOz.Size = new Size(66, 28);
            rdEightOz.TabIndex = 5;
            rdEightOz.TabStop = true;
            rdEightOz.Text = "8 oz";
            rdEightOz.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(21, 222);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(159, 47);
            btnBack.TabIndex = 4;
            btnBack.Text = "&Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(800, 699);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(163, 48);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnResetFlavors
            // 
            btnResetFlavors.Location = new Point(781, 466);
            btnResetFlavors.Margin = new Padding(3, 2, 3, 2);
            btnResetFlavors.Name = "btnResetFlavors";
            btnResetFlavors.Size = new Size(181, 68);
            btnResetFlavors.TabIndex = 4;
            btnResetFlavors.Text = "R&eset Flavors";
            btnResetFlavors.UseVisualStyleBackColor = true;
            // 
            // lblFlavorCount
            // 
            lblFlavorCount.BorderStyle = BorderStyle.FixedSingle;
            lblFlavorCount.ForeColor = Color.White;
            lblFlavorCount.Location = new Point(781, 414);
            lblFlavorCount.Name = "lblFlavorCount";
            lblFlavorCount.Size = new Size(182, 39);
            lblFlavorCount.TabIndex = 10;
            lblFlavorCount.Text = "Flavors Picked: 0";
            // 
            // lblCola
            // 
            lblCola.BackColor = Color.White;
            lblCola.ForeColor = Color.White;
            lblCola.Location = new Point(47, 36);
            lblCola.Name = "lblCola";
            lblCola.Size = new Size(176, 164);
            lblCola.TabIndex = 20;
            lblCola.Text = "Label10";
            // 
            // lblDietCola
            // 
            lblDietCola.BackColor = Color.White;
            lblDietCola.ForeColor = Color.White;
            lblDietCola.Location = new Point(236, 36);
            lblDietCola.Name = "lblDietCola";
            lblDietCola.Size = new Size(176, 164);
            lblDietCola.TabIndex = 21;
            lblDietCola.Text = "Label1";
            // 
            // lblZeroCola
            // 
            lblZeroCola.BackColor = Color.White;
            lblZeroCola.ForeColor = Color.White;
            lblZeroCola.Location = new Point(425, 36);
            lblZeroCola.Name = "lblZeroCola";
            lblZeroCola.Size = new Size(176, 164);
            lblZeroCola.TabIndex = 22;
            lblZeroCola.Text = "Label2";
            // 
            // lblFanta
            // 
            lblFanta.BackColor = Color.White;
            lblFanta.ForeColor = Color.White;
            lblFanta.Location = new Point(613, 36);
            lblFanta.Name = "lblFanta";
            lblFanta.Size = new Size(176, 164);
            lblFanta.TabIndex = 23;
            lblFanta.Text = "Label3";
            // 
            // lblDrPepper
            // 
            lblDrPepper.BackColor = Color.White;
            lblDrPepper.ForeColor = Color.White;
            lblDrPepper.Location = new Point(803, 36);
            lblDrPepper.Name = "lblDrPepper";
            lblDrPepper.Size = new Size(176, 164);
            lblDrPepper.TabIndex = 24;
            lblDrPepper.Text = "Label4";
            // 
            // lblRootBeer
            // 
            lblRootBeer.BackColor = Color.White;
            lblRootBeer.ForeColor = Color.White;
            lblRootBeer.Location = new Point(803, 226);
            lblRootBeer.Name = "lblRootBeer";
            lblRootBeer.Size = new Size(176, 164);
            lblRootBeer.TabIndex = 25;
            lblRootBeer.Text = "Label5";
            // 
            // lblMntMaidZero
            // 
            lblMntMaidZero.BackColor = Color.White;
            lblMntMaidZero.ForeColor = Color.White;
            lblMntMaidZero.Location = new Point(613, 226);
            lblMntMaidZero.Name = "lblMntMaidZero";
            lblMntMaidZero.Size = new Size(176, 164);
            lblMntMaidZero.TabIndex = 26;
            lblMntMaidZero.Text = "Label6";
            // 
            // lblMntMaid
            // 
            lblMntMaid.BackColor = Color.White;
            lblMntMaid.ForeColor = Color.White;
            lblMntMaid.Location = new Point(425, 226);
            lblMntMaid.Name = "lblMntMaid";
            lblMntMaid.Size = new Size(176, 164);
            lblMntMaid.TabIndex = 27;
            lblMntMaid.Text = "Label7";
            // 
            // lblSpriteZero
            // 
            lblSpriteZero.BackColor = Color.White;
            lblSpriteZero.ForeColor = Color.White;
            lblSpriteZero.Location = new Point(236, 226);
            lblSpriteZero.Name = "lblSpriteZero";
            lblSpriteZero.Size = new Size(176, 164);
            lblSpriteZero.TabIndex = 28;
            lblSpriteZero.Text = "Label8";
            // 
            // lblSprite
            // 
            lblSprite.BackColor = Color.White;
            lblSprite.ForeColor = Color.White;
            lblSprite.Location = new Point(47, 226);
            lblSprite.Name = "lblSprite";
            lblSprite.Size = new Size(176, 164);
            lblSprite.TabIndex = 29;
            lblSprite.Text = "Label9";
            // 
            // InventoryBindingSource
            // 
            InventoryBindingSource.DataMember = "Inventory";
            InventoryBindingSource.DataSource = FreeStyleDBDataSet;
            // 
            // FreeStyleDBDataSet
            // 
            FreeStyleDBDataSet.DataSetName = "FreeStyleDBDataSet";
            FreeStyleDBDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.AutoGenerateColumns = false;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3 });
            OrdersDataGridView.DataSource = OrdersBindingSource;
            OrdersDataGridView.Location = new Point(1009, 293);
            OrdersDataGridView.Margin = new Padding(3, 2, 3, 2);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.RowTemplate.Height = 24;
            OrdersDataGridView.Size = new Size(432, 206);
            OrdersDataGridView.TabIndex = 30;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            DataGridViewTextBoxColumn1.HeaderText = "OrderID";
            DataGridViewTextBoxColumn1.MinimumWidth = 6;
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            DataGridViewTextBoxColumn1.Width = 125;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.DataPropertyName = "OrderAmount";
            DataGridViewTextBoxColumn2.HeaderText = "OrderAmount";
            DataGridViewTextBoxColumn2.MinimumWidth = 6;
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.ReadOnly = true;
            DataGridViewTextBoxColumn2.Width = 125;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.DataPropertyName = "DateOfOrder";
            DataGridViewTextBoxColumn3.HeaderText = "DateOfOrder";
            DataGridViewTextBoxColumn3.MinimumWidth = 6;
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            DataGridViewTextBoxColumn3.Width = 125;
            // 
            // OrdersBindingSource
            // 
            OrdersBindingSource.DataMember = "Orders";
            OrdersBindingSource.DataSource = FreeStyleDBDataSet;
            // 
            // OrderFluidInfoDataGridView
            // 
            OrderFluidInfoDataGridView.AutoGenerateColumns = false;
            OrderFluidInfoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderFluidInfoDataGridView.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn10, DataGridViewTextBoxColumn11, DataGridViewTextBoxColumn12, DataGridViewTextBoxColumn13 });
            OrderFluidInfoDataGridView.DataSource = OrderFluidInfoBindingSource;
            OrderFluidInfoDataGridView.Location = new Point(1009, 527);
            OrderFluidInfoDataGridView.Margin = new Padding(3, 2, 3, 2);
            OrderFluidInfoDataGridView.Name = "OrderFluidInfoDataGridView";
            OrderFluidInfoDataGridView.RowHeadersWidth = 51;
            OrderFluidInfoDataGridView.RowTemplate.Height = 24;
            OrderFluidInfoDataGridView.Size = new Size(432, 220);
            OrderFluidInfoDataGridView.TabIndex = 31;
            // 
            // DataGridViewTextBoxColumn10
            // 
            DataGridViewTextBoxColumn10.DataPropertyName = "OrderID";
            DataGridViewTextBoxColumn10.HeaderText = "OrderID";
            DataGridViewTextBoxColumn10.MinimumWidth = 6;
            DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
            DataGridViewTextBoxColumn10.Width = 125;
            // 
            // DataGridViewTextBoxColumn11
            // 
            DataGridViewTextBoxColumn11.DataPropertyName = "FluidID";
            DataGridViewTextBoxColumn11.HeaderText = "FluidID";
            DataGridViewTextBoxColumn11.MinimumWidth = 6;
            DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            DataGridViewTextBoxColumn11.Width = 125;
            // 
            // DataGridViewTextBoxColumn12
            // 
            DataGridViewTextBoxColumn12.DataPropertyName = "IsFluidMix";
            DataGridViewTextBoxColumn12.HeaderText = "IsFluidMix";
            DataGridViewTextBoxColumn12.MinimumWidth = 6;
            DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
            DataGridViewTextBoxColumn12.Width = 125;
            // 
            // DataGridViewTextBoxColumn13
            // 
            DataGridViewTextBoxColumn13.DataPropertyName = "UsedOz";
            DataGridViewTextBoxColumn13.HeaderText = "UsedOz";
            DataGridViewTextBoxColumn13.MinimumWidth = 6;
            DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            DataGridViewTextBoxColumn13.Width = 125;
            // 
            // OrderFluidInfoBindingSource
            // 
            OrderFluidInfoBindingSource.DataMember = "OrderFluidInfo";
            OrderFluidInfoBindingSource.DataSource = FreeStyleDBDataSet;
            // 
            // InventoryDataGridView
            // 
            InventoryDataGridView.AutoGenerateColumns = false;
            InventoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7, DataGridViewTextBoxColumn8, DataGridViewTextBoxColumn9, DataGridViewTextBoxColumn14 });
            InventoryDataGridView.DataSource = InventoryBindingSource;
            InventoryDataGridView.Location = new Point(1009, 50);
            InventoryDataGridView.Margin = new Padding(3, 2, 3, 2);
            InventoryDataGridView.Name = "InventoryDataGridView";
            InventoryDataGridView.RowHeadersWidth = 51;
            InventoryDataGridView.RowTemplate.Height = 24;
            InventoryDataGridView.Size = new Size(432, 220);
            InventoryDataGridView.TabIndex = 31;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewTextBoxColumn4.DataPropertyName = "FluidID";
            DataGridViewTextBoxColumn4.HeaderText = "FluidID";
            DataGridViewTextBoxColumn4.MinimumWidth = 6;
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            DataGridViewTextBoxColumn4.Width = 125;
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewTextBoxColumn5.DataPropertyName = "FluidName";
            DataGridViewTextBoxColumn5.HeaderText = "FluidName";
            DataGridViewTextBoxColumn5.MinimumWidth = 6;
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            DataGridViewTextBoxColumn5.Width = 125;
            // 
            // DataGridViewTextBoxColumn6
            // 
            DataGridViewTextBoxColumn6.DataPropertyName = "FluidType";
            DataGridViewTextBoxColumn6.HeaderText = "FluidType";
            DataGridViewTextBoxColumn6.MinimumWidth = 6;
            DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            DataGridViewTextBoxColumn6.Width = 125;
            // 
            // DataGridViewTextBoxColumn7
            // 
            DataGridViewTextBoxColumn7.DataPropertyName = "Capacity(oz)";
            DataGridViewTextBoxColumn7.HeaderText = "Capacity(oz)";
            DataGridViewTextBoxColumn7.MinimumWidth = 6;
            DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            DataGridViewTextBoxColumn7.Width = 125;
            // 
            // DataGridViewTextBoxColumn8
            // 
            DataGridViewTextBoxColumn8.DataPropertyName = "CurrentAmount";
            DataGridViewTextBoxColumn8.HeaderText = "CurrentAmount";
            DataGridViewTextBoxColumn8.MinimumWidth = 6;
            DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            DataGridViewTextBoxColumn8.Width = 125;
            // 
            // DataGridViewTextBoxColumn9
            // 
            DataGridViewTextBoxColumn9.DataPropertyName = "ExpirationDate";
            DataGridViewTextBoxColumn9.HeaderText = "ExpirationDate";
            DataGridViewTextBoxColumn9.MinimumWidth = 6;
            DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
            DataGridViewTextBoxColumn9.Width = 125;
            // 
            // DataGridViewTextBoxColumn14
            // 
            DataGridViewTextBoxColumn14.DataPropertyName = "Last Fill Date";
            DataGridViewTextBoxColumn14.HeaderText = "Last Fill Date";
            DataGridViewTextBoxColumn14.MinimumWidth = 6;
            DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
            DataGridViewTextBoxColumn14.Width = 125;
            // 
            // btnMaintenanceRp
            // 
            btnMaintenanceRp.Location = new Point(64, 539);
            btnMaintenanceRp.Margin = new Padding(3, 2, 3, 2);
            btnMaintenanceRp.Name = "btnMaintenanceRp";
            btnMaintenanceRp.Size = new Size(163, 47);
            btnMaintenanceRp.TabIndex = 32;
            btnMaintenanceRp.Text = "M&aintenance Report";
            btnMaintenanceRp.UseVisualStyleBackColor = true;
            // 
            // btnLocationMgRp
            // 
            btnLocationMgRp.Location = new Point(64, 668);
            btnLocationMgRp.Margin = new Padding(3, 2, 3, 2);
            btnLocationMgRp.Name = "btnLocationMgRp";
            btnLocationMgRp.Size = new Size(163, 47);
            btnLocationMgRp.TabIndex = 33;
            btnLocationMgRp.Text = "&Location Management Report";
            btnLocationMgRp.UseVisualStyleBackColor = true;
            // 
            // cklbInventory
            // 
            cklbInventory.FormattingEnabled = true;
            cklbInventory.Items.AddRange(new object[] { "Cola", "Diet Cola", "Zero Cola", "Fanta", "DrPepper", "Sprite", "Zero Sprite", "Minute Maid", "Zero Minute Maid", "RootBeer", "Co2" });
            cklbInventory.Location = new Point(233, 410);
            cklbInventory.Margin = new Padding(3, 2, 3, 2);
            cklbInventory.Name = "cklbInventory";
            cklbInventory.Size = new Size(173, 191);
            cklbInventory.TabIndex = 9;
            // 
            // btnOrderInventoryAfterSelection
            // 
            btnOrderInventoryAfterSelection.Location = new Point(239, 624);
            btnOrderInventoryAfterSelection.Margin = new Padding(3, 2, 3, 2);
            btnOrderInventoryAfterSelection.Name = "btnOrderInventoryAfterSelection";
            btnOrderInventoryAfterSelection.Size = new Size(124, 32);
            btnOrderInventoryAfterSelection.TabIndex = 34;
            btnOrderInventoryAfterSelection.Text = "Order &Inventory";
            btnOrderInventoryAfterSelection.UseVisualStyleBackColor = true;
            // 
            // DTPStart
            // 
            DTPStart.Location = new Point(233, 598);
            DTPStart.Margin = new Padding(3, 2, 3, 2);
            DTPStart.Name = "DTPStart";
            DTPStart.Size = new Size(272, 22);
            DTPStart.TabIndex = 35;
            DTPStart.Visible = false;
            // 
            // DTPEnd
            // 
            DTPEnd.Location = new Point(233, 654);
            DTPEnd.Margin = new Padding(3, 2, 3, 2);
            DTPEnd.Name = "DTPEnd";
            DTPEnd.Size = new Size(272, 22);
            DTPEnd.TabIndex = 36;
            DTPEnd.Visible = false;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.ForeColor = SystemColors.ButtonHighlight;
            lblStartDate.Location = new Point(235, 575);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(76, 17);
            lblStartDate.TabIndex = 37;
            lblStartDate.Text = "&Start Date:";
            lblStartDate.Visible = false;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.ForeColor = SystemColors.ButtonHighlight;
            lblEndDate.Location = new Point(235, 626);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(71, 17);
            lblEndDate.TabIndex = 38;
            lblEndDate.Text = "&End Date:";
            lblEndDate.Visible = false;
            // 
            // btnGetOrderReport
            // 
            btnGetOrderReport.Location = new Point(239, 681);
            btnGetOrderReport.Margin = new Padding(3, 2, 3, 2);
            btnGetOrderReport.Name = "btnGetOrderReport";
            btnGetOrderReport.Size = new Size(124, 34);
            btnGetOrderReport.TabIndex = 39;
            btnGetOrderReport.Text = "&Get Report";
            btnGetOrderReport.UseVisualStyleBackColor = true;
            btnGetOrderReport.Visible = false;
            // 
            // InventoryTableAdapter
            // 
            InventoryTableAdapter.ClearBeforeFill = true;
            // 
            // TableAdapterManager
            // 
            TableAdapterManager.BackupDataSetBeforeUpdate = false;
            TableAdapterManager.InventoryTableAdapter = InventoryTableAdapter;
            TableAdapterManager.OrderFluidInfoTableAdapter = OrderFluidInfoTableAdapter;
            TableAdapterManager.OrdersTableAdapter = OrdersTableAdapter;
            TableAdapterManager.UpdateOrder = FreeStyleDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // OrderFluidInfoTableAdapter
            // 
            OrderFluidInfoTableAdapter.ClearBeforeFill = true;
            // 
            // OrdersTableAdapter
            // 
            OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // DataGridViewTextBoxColumn17
            // 
            DataGridViewTextBoxColumn17.DataPropertyName = "DateOfOrder";
            DataGridViewTextBoxColumn17.HeaderText = "DateOfOrder";
            DataGridViewTextBoxColumn17.MinimumWidth = 6;
            DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
            DataGridViewTextBoxColumn17.Width = 125;
            // 
            // DataGridViewTextBoxColumn16
            // 
            DataGridViewTextBoxColumn16.DataPropertyName = "OrderAmount";
            DataGridViewTextBoxColumn16.HeaderText = "OrderAmount";
            DataGridViewTextBoxColumn16.MinimumWidth = 6;
            DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
            DataGridViewTextBoxColumn16.Width = 125;
            // 
            // DataGridViewTextBoxColumn15
            // 
            DataGridViewTextBoxColumn15.DataPropertyName = "OrderID";
            DataGridViewTextBoxColumn15.HeaderText = "OrderID";
            DataGridViewTextBoxColumn15.MinimumWidth = 6;
            DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
            DataGridViewTextBoxColumn15.ReadOnly = true;
            DataGridViewTextBoxColumn15.Width = 125;
            // 
            // OrdersDataGridViewWDP
            // 
            OrdersDataGridViewWDP.AutoGenerateColumns = false;
            OrdersDataGridViewWDP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridViewWDP.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn15, DataGridViewTextBoxColumn16, DataGridViewTextBoxColumn17 });
            OrdersDataGridViewWDP.DataSource = OrdersBindingSource;
            OrdersDataGridViewWDP.Location = new Point(1461, 93);
            OrdersDataGridViewWDP.Name = "OrdersDataGridViewWDP";
            OrdersDataGridViewWDP.RowHeadersWidth = 51;
            OrdersDataGridViewWDP.RowTemplate.Height = 24;
            OrdersDataGridViewWDP.Size = new Size(388, 233);
            OrdersDataGridViewWDP.TabIndex = 41;
            // 
            // StartDateToolStripLabel
            // 
            StartDateToolStripLabel.Name = "StartDateToolStripLabel";
            StartDateToolStripLabel.Size = new Size(75, 24);
            StartDateToolStripLabel.Text = "StartDate:";
            // 
            // StartDateToolStripTextBox
            // 
            StartDateToolStripTextBox.Font = new Font("Segoe UI", 9.0f);
            StartDateToolStripTextBox.Name = "StartDateToolStripTextBox";
            StartDateToolStripTextBox.Size = new Size(100, 27);
            // 
            // EndDateToolStripLabel
            // 
            EndDateToolStripLabel.Name = "EndDateToolStripLabel";
            EndDateToolStripLabel.Size = new Size(69, 24);
            EndDateToolStripLabel.Text = "EndDate:";
            // 
            // EndDateToolStripTextBox
            // 
            EndDateToolStripTextBox.Font = new Font("Segoe UI", 9.0f);
            EndDateToolStripTextBox.Name = "EndDateToolStripTextBox";
            EndDateToolStripTextBox.Size = new Size(100, 27);
            // 
            // FillByOrdersToolStripButton
            // 
            FillByOrdersToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            FillByOrdersToolStripButton.Name = "FillByOrdersToolStripButton";
            FillByOrdersToolStripButton.Size = new Size(92, 24);
            FillByOrdersToolStripButton.Text = "FillByOrders";
            // 
            // FillByOrdersToolStrip
            // 
            FillByOrdersToolStrip.ImageScalingSize = new Size(20, 20);
            FillByOrdersToolStrip.Items.AddRange(new ToolStripItem[] { StartDateToolStripLabel, StartDateToolStripTextBox, EndDateToolStripLabel, EndDateToolStripTextBox, FillByOrdersToolStripButton });
            FillByOrdersToolStrip.Location = new Point(0, 27);
            FillByOrdersToolStrip.Name = "FillByOrdersToolStrip";
            FillByOrdersToolStrip.Size = new Size(1002, 27);
            FillByOrdersToolStrip.TabIndex = 42;
            FillByOrdersToolStrip.Text = "FillByOrdersToolStrip";
            // 
            // BindingNavigatorMoveFirstItem
            // 
            BindingNavigatorMoveFirstItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BindingNavigatorMoveFirstItem.Image = (Image)resources.GetObject("BindingNavigatorMoveFirstItem.Image");
            BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorMoveFirstItem.Size = new Size(29, 24);
            BindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // BindingNavigatorMovePreviousItem
            // 
            BindingNavigatorMovePreviousItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BindingNavigatorMovePreviousItem.Image = (Image)resources.GetObject("BindingNavigatorMovePreviousItem.Image");
            BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorMovePreviousItem.Size = new Size(29, 24);
            BindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // BindingNavigatorSeparator
            // 
            BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            BindingNavigatorSeparator.Size = new Size(6, 27);
            // 
            // BindingNavigatorPositionItem
            // 
            BindingNavigatorPositionItem.AccessibleName = "Position";
            BindingNavigatorPositionItem.AutoSize = false;
            BindingNavigatorPositionItem.Font = new Font("Segoe UI", 9.0f);
            BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            BindingNavigatorPositionItem.Size = new Size(49, 27);
            BindingNavigatorPositionItem.Text = "0";
            BindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // BindingNavigatorCountItem
            // 
            BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            BindingNavigatorCountItem.Size = new Size(45, 24);
            BindingNavigatorCountItem.Text = "of {0}";
            BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // BindingNavigatorSeparator1
            // 
            BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            BindingNavigatorSeparator1.Size = new Size(6, 27);
            // 
            // BindingNavigatorMoveNextItem
            // 
            BindingNavigatorMoveNextItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BindingNavigatorMoveNextItem.Image = (Image)resources.GetObject("BindingNavigatorMoveNextItem.Image");
            BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorMoveNextItem.Size = new Size(29, 24);
            BindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // BindingNavigatorMoveLastItem
            // 
            BindingNavigatorMoveLastItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BindingNavigatorMoveLastItem.Image = (Image)resources.GetObject("BindingNavigatorMoveLastItem.Image");
            BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorMoveLastItem.Size = new Size(29, 24);
            BindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // BindingNavigatorSeparator2
            // 
            BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            BindingNavigatorSeparator2.Size = new Size(6, 27);
            // 
            // BindingNavigatorAddNewItem
            // 
            BindingNavigatorAddNewItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BindingNavigatorAddNewItem.Image = (Image)resources.GetObject("BindingNavigatorAddNewItem.Image");
            BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem";
            BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorAddNewItem.Size = new Size(29, 24);
            BindingNavigatorAddNewItem.Text = "Add new";
            // 
            // BindingNavigatorDeleteItem
            // 
            BindingNavigatorDeleteItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BindingNavigatorDeleteItem.Image = (Image)resources.GetObject("BindingNavigatorDeleteItem.Image");
            BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
            BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorDeleteItem.Size = new Size(29, 24);
            BindingNavigatorDeleteItem.Text = "Delete";
            // 
            // InventoryBindingNavigatorSaveItem
            // 
            InventoryBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            InventoryBindingNavigatorSaveItem.Image = (Image)resources.GetObject("InventoryBindingNavigatorSaveItem.Image");
            InventoryBindingNavigatorSaveItem.Name = "InventoryBindingNavigatorSaveItem";
            InventoryBindingNavigatorSaveItem.Size = new Size(29, 24);
            InventoryBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // InventoryBindingNavigator
            // 
            InventoryBindingNavigator.AddNewItem = BindingNavigatorAddNewItem;
            InventoryBindingNavigator.BindingSource = InventoryBindingSource;
            InventoryBindingNavigator.CountItem = BindingNavigatorCountItem;
            InventoryBindingNavigator.DeleteItem = BindingNavigatorDeleteItem;
            InventoryBindingNavigator.ImageScalingSize = new Size(20, 20);
            InventoryBindingNavigator.Items.AddRange(new ToolStripItem[] { BindingNavigatorMoveFirstItem, BindingNavigatorMovePreviousItem, BindingNavigatorSeparator, BindingNavigatorPositionItem, BindingNavigatorCountItem, BindingNavigatorSeparator1, BindingNavigatorMoveNextItem, BindingNavigatorMoveLastItem, BindingNavigatorSeparator2, BindingNavigatorAddNewItem, BindingNavigatorDeleteItem, InventoryBindingNavigatorSaveItem });
            InventoryBindingNavigator.Location = new Point(0, 0);
            InventoryBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem;
            InventoryBindingNavigator.MoveLastItem = BindingNavigatorMoveLastItem;
            InventoryBindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem;
            InventoryBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem;
            InventoryBindingNavigator.Name = "InventoryBindingNavigator";
            InventoryBindingNavigator.PositionItem = BindingNavigatorPositionItem;
            InventoryBindingNavigator.Size = new Size(1002, 27);
            InventoryBindingNavigator.TabIndex = 30;
            InventoryBindingNavigator.Text = "BindingNavigator1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1002, 785);
            Controls.Add(FillByOrdersToolStrip);
            Controls.Add(OrdersDataGridViewWDP);
            Controls.Add(btnGetOrderReport);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(DTPEnd);
            Controls.Add(DTPStart);
            Controls.Add(btnOrderInventoryAfterSelection);
            Controls.Add(cklbInventory);
            Controls.Add(btnLocationMgRp);
            Controls.Add(btnMaintenanceRp);
            Controls.Add(InventoryDataGridView);
            Controls.Add(OrderFluidInfoDataGridView);
            Controls.Add(OrdersDataGridView);
            Controls.Add(InventoryBindingNavigator);
            Controls.Add(lblFlavorCount);
            Controls.Add(btnResetFlavors);
            Controls.Add(btnExit);
            Controls.Add(grpSize);
            Controls.Add(btnMixDisp);
            Controls.Add(btnOrderRp);
            Controls.Add(btnInventoryRp);
            Controls.Add(btnReOrder);
            Controls.Add(picRootBeer);
            Controls.Add(picMMLemonZero);
            Controls.Add(picMMLemon);
            Controls.Add(picSpriteZero);
            Controls.Add(picSprite);
            Controls.Add(picDrPepper);
            Controls.Add(picFanta);
            Controls.Add(picColaZero);
            Controls.Add(picColaDiet);
            Controls.Add(picCola);
            Controls.Add(lblSprite);
            Controls.Add(lblSpriteZero);
            Controls.Add(lblMntMaid);
            Controls.Add(lblMntMaidZero);
            Controls.Add(lblRootBeer);
            Controls.Add(lblDrPepper);
            Controls.Add(lblFanta);
            Controls.Add(lblZeroCola);
            Controls.Add(lblDietCola);
            Controls.Add(lblCola);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Free Style";
            ((System.ComponentModel.ISupportInitialize)picCola).EndInit();
            ((System.ComponentModel.ISupportInitialize)picColaDiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)picColaZero).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFanta).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDrPepper).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSprite).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSpriteZero).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMMLemon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMMLemonZero).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRootBeer).EndInit();
            grpSize.ResumeLayout(false);
            grpSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InventoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)FreeStyleDBDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrdersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderFluidInfoDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderFluidInfoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)InventoryDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridViewWDP).EndInit();
            FillByOrdersToolStrip.ResumeLayout(false);
            FillByOrdersToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InventoryBindingNavigator).EndInit();
            InventoryBindingNavigator.ResumeLayout(false);
            InventoryBindingNavigator.PerformLayout();
            Load += new EventHandler(MainForm_Load);
            ResumeLayout(false);
            PerformLayout();

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
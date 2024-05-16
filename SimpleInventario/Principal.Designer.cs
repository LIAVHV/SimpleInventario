
namespace SimpleInventario
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.existenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportes = new SimpleInventario.Reportes.dsReportes();
            this.kardexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnModificarProducto = new MaterialSkin.Controls.MaterialButton();
            this.txtCatProdNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.btnEliminarProducto = new MaterialSkin.Controls.MaterialButton();
            this.lblCatProductoId = new MaterialSkin.Controls.MaterialLabel();
            this.lblTitCatProd = new MaterialSkin.Controls.MaterialLabel();
            this.btnProducto = new MaterialSkin.Controls.MaterialButton();
            this.ddlCatProdUnidad = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.tabUnidades = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btnModificarUnidad = new MaterialSkin.Controls.MaterialButton();
            this.lblUnidadesId = new MaterialSkin.Controls.MaterialLabel();
            this.BtnUnidadEliminar = new MaterialSkin.Controls.MaterialButton();
            this.dgUnidades = new System.Windows.Forms.DataGridView();
            this.lblTitCatUnidades = new MaterialSkin.Controls.MaterialLabel();
            this.btnUnidad = new MaterialSkin.Controls.MaterialButton();
            this.txtUnidad = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.tabExistencias = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabEntradas = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.ddlEntradaProducto = new System.Windows.Forms.ComboBox();
            this.lbExistenciaEntrada = new MaterialSkin.Controls.MaterialLabel();
            this.txtEntradaPrecio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEntradaCantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.lblTitEntradas = new MaterialSkin.Controls.MaterialLabel();
            this.btnEntrada = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tabSalidas = new System.Windows.Forms.TabPage();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.ddlSalidaProducto = new System.Windows.Forms.ComboBox();
            this.lbExistenciaSalida = new MaterialSkin.Controls.MaterialLabel();
            this.lbPrecioSalida = new MaterialSkin.Controls.MaterialLabel();
            this.txtSalidaCantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.lblTitSalidas = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalida = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabKardex = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.existenciasTableAdapter = new SimpleInventario.Reportes.dsReportesTableAdapters.ExistenciasTableAdapter();
            this.kardexTableAdapter = new SimpleInventario.Reportes.dsReportesTableAdapters.KardexTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.existenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kardexBindingSource)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.tabProductos.SuspendLayout();
            this.tabUnidades.SuspendLayout();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnidades)).BeginInit();
            this.tabExistencias.SuspendLayout();
            this.tabEntradas.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tabSalidas.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabKardex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // existenciasBindingSource
            // 
            this.existenciasBindingSource.DataMember = "Existencias";
            this.existenciasBindingSource.DataSource = this.dsReportes;
            // 
            // dsReportes
            // 
            this.dsReportes.DataSetName = "dsReportes";
            this.dsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kardexBindingSource
            // 
            this.kardexBindingSource.DataMember = "Kardex";
            this.kardexBindingSource.DataSource = this.dsReportes;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnModificarProducto);
            this.materialCard1.Controls.Add(this.txtCatProdNombre);
            this.materialCard1.Controls.Add(this.dgProductos);
            this.materialCard1.Controls.Add(this.btnEliminarProducto);
            this.materialCard1.Controls.Add(this.lblCatProductoId);
            this.materialCard1.Controls.Add(this.lblTitCatProd);
            this.materialCard1.Controls.Add(this.btnProducto);
            this.materialCard1.Controls.Add(this.ddlCatProdUnidad);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 17);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1035, 348);
            this.materialCard1.TabIndex = 0;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificarProducto.Depth = 0;
            this.btnModificarProducto.HighEmphasis = true;
            this.btnModificarProducto.Icon = null;
            this.btnModificarProducto.Location = new System.Drawing.Point(152, 230);
            this.btnModificarProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificarProducto.Size = new System.Drawing.Size(99, 36);
            this.btnModificarProducto.TabIndex = 12;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificarProducto.UseAccentColor = false;
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // txtCatProdNombre
            // 
            this.txtCatProdNombre.AnimateReadOnly = false;
            this.txtCatProdNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCatProdNombre.Depth = 0;
            this.txtCatProdNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCatProdNombre.LeadingIcon = null;
            this.txtCatProdNombre.Location = new System.Drawing.Point(17, 87);
            this.txtCatProdNombre.MaxLength = 300;
            this.txtCatProdNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCatProdNombre.Multiline = false;
            this.txtCatProdNombre.Name = "txtCatProdNombre";
            this.txtCatProdNombre.Size = new System.Drawing.Size(362, 50);
            this.txtCatProdNombre.TabIndex = 11;
            this.txtCatProdNombre.Text = "";
            this.txtCatProdNombre.TrailingIcon = null;
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.AllowUserToDeleteRows = false;
            this.dgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(454, 14);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgProductos.Size = new System.Drawing.Size(531, 254);
            this.dgProductos.TabIndex = 10;
            this.dgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellClick);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarProducto.Depth = 0;
            this.btnEliminarProducto.HighEmphasis = true;
            this.btnEliminarProducto.Icon = null;
            this.btnEliminarProducto.Location = new System.Drawing.Point(896, 277);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarProducto.Size = new System.Drawing.Size(88, 36);
            this.btnEliminarProducto.TabIndex = 9;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarProducto.UseAccentColor = true;
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // lblCatProductoId
            // 
            this.lblCatProductoId.AutoSize = true;
            this.lblCatProductoId.Depth = 0;
            this.lblCatProductoId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCatProductoId.Location = new System.Drawing.Point(17, 48);
            this.lblCatProductoId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCatProductoId.Name = "lblCatProductoId";
            this.lblCatProductoId.Size = new System.Drawing.Size(1, 0);
            this.lblCatProductoId.TabIndex = 8;
            // 
            // lblTitCatProd
            // 
            this.lblTitCatProd.AutoSize = true;
            this.lblTitCatProd.Depth = 0;
            this.lblTitCatProd.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitCatProd.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTitCatProd.Location = new System.Drawing.Point(17, 14);
            this.lblTitCatProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitCatProd.Name = "lblTitCatProd";
            this.lblTitCatProd.Size = new System.Drawing.Size(204, 24);
            this.lblTitCatProd.TabIndex = 5;
            this.lblTitCatProd.Text = "Catálogo de Productos";
            // 
            // btnProducto
            // 
            this.btnProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProducto.Depth = 0;
            this.btnProducto.HighEmphasis = true;
            this.btnProducto.Icon = null;
            this.btnProducto.Location = new System.Drawing.Point(291, 230);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProducto.Size = new System.Drawing.Size(88, 36);
            this.btnProducto.TabIndex = 4;
            this.btnProducto.Text = "Guardar";
            this.btnProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProducto.UseAccentColor = false;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // ddlCatProdUnidad
            // 
            this.ddlCatProdUnidad.AutoResize = false;
            this.ddlCatProdUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ddlCatProdUnidad.Depth = 0;
            this.ddlCatProdUnidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ddlCatProdUnidad.DropDownHeight = 174;
            this.ddlCatProdUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCatProdUnidad.DropDownWidth = 121;
            this.ddlCatProdUnidad.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ddlCatProdUnidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ddlCatProdUnidad.FormattingEnabled = true;
            this.ddlCatProdUnidad.IntegralHeight = false;
            this.ddlCatProdUnidad.ItemHeight = 43;
            this.ddlCatProdUnidad.Location = new System.Drawing.Point(17, 170);
            this.ddlCatProdUnidad.MaxDropDownItems = 4;
            this.ddlCatProdUnidad.MouseState = MaterialSkin.MouseState.OUT;
            this.ddlCatProdUnidad.Name = "ddlCatProdUnidad";
            this.ddlCatProdUnidad.Size = new System.Drawing.Size(204, 49);
            this.ddlCatProdUnidad.StartIndex = 0;
            this.ddlCatProdUnidad.TabIndex = 3;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 148);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(129, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Unidad de Medida";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 65);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Nombre";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "entradas.png");
            this.imageList1.Images.SetKeyName(1, "productos.png");
            this.imageList1.Images.SetKeyName(2, "repExistencias.png");
            this.imageList1.Images.SetKeyName(3, "repKardex.png");
            this.imageList1.Images.SetKeyName(4, "salidas.png");
            this.imageList1.Images.SetKeyName(5, "unidades.png");
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.materialCard1);
            this.tabProductos.ImageKey = "productos.png";
            this.tabProductos.Location = new System.Drawing.Point(4, 39);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(1078, 397);
            this.tabProductos.TabIndex = 4;
            this.tabProductos.Text = "2. Cat.Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // tabUnidades
            // 
            this.tabUnidades.Controls.Add(this.materialCard3);
            this.tabUnidades.ImageKey = "unidades.png";
            this.tabUnidades.Location = new System.Drawing.Point(4, 39);
            this.tabUnidades.Name = "tabUnidades";
            this.tabUnidades.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnidades.Size = new System.Drawing.Size(1078, 397);
            this.tabUnidades.TabIndex = 3;
            this.tabUnidades.Text = "1. Cat.Unidades";
            this.tabUnidades.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btnModificarUnidad);
            this.materialCard3.Controls.Add(this.lblUnidadesId);
            this.materialCard3.Controls.Add(this.BtnUnidadEliminar);
            this.materialCard3.Controls.Add(this.dgUnidades);
            this.materialCard3.Controls.Add(this.lblTitCatUnidades);
            this.materialCard3.Controls.Add(this.btnUnidad);
            this.materialCard3.Controls.Add(this.txtUnidad);
            this.materialCard3.Controls.Add(this.materialLabel11);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(17, 17);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(974, 348);
            this.materialCard3.TabIndex = 1;
            // 
            // btnModificarUnidad
            // 
            this.btnModificarUnidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarUnidad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificarUnidad.Depth = 0;
            this.btnModificarUnidad.HighEmphasis = true;
            this.btnModificarUnidad.Icon = null;
            this.btnModificarUnidad.Location = new System.Drawing.Point(222, 140);
            this.btnModificarUnidad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarUnidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarUnidad.Name = "btnModificarUnidad";
            this.btnModificarUnidad.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificarUnidad.Size = new System.Drawing.Size(99, 36);
            this.btnModificarUnidad.TabIndex = 12;
            this.btnModificarUnidad.Text = "Modificar";
            this.btnModificarUnidad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificarUnidad.UseAccentColor = false;
            this.btnModificarUnidad.UseVisualStyleBackColor = true;
            this.btnModificarUnidad.Click += new System.EventHandler(this.btnModificarUnidad_Click);
            // 
            // lblUnidadesId
            // 
            this.lblUnidadesId.AutoSize = true;
            this.lblUnidadesId.Depth = 0;
            this.lblUnidadesId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUnidadesId.Location = new System.Drawing.Point(75, 56);
            this.lblUnidadesId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUnidadesId.Name = "lblUnidadesId";
            this.lblUnidadesId.Size = new System.Drawing.Size(1, 0);
            this.lblUnidadesId.TabIndex = 11;
            // 
            // BtnUnidadEliminar
            // 
            this.BtnUnidadEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnUnidadEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnUnidadEliminar.Depth = 0;
            this.BtnUnidadEliminar.HighEmphasis = true;
            this.BtnUnidadEliminar.Icon = null;
            this.BtnUnidadEliminar.Location = new System.Drawing.Point(838, 274);
            this.BtnUnidadEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnUnidadEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnUnidadEliminar.Name = "BtnUnidadEliminar";
            this.BtnUnidadEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnUnidadEliminar.Size = new System.Drawing.Size(88, 36);
            this.BtnUnidadEliminar.TabIndex = 10;
            this.BtnUnidadEliminar.Text = "Eliminar";
            this.BtnUnidadEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnUnidadEliminar.UseAccentColor = true;
            this.BtnUnidadEliminar.UseVisualStyleBackColor = false;
            this.BtnUnidadEliminar.Click += new System.EventHandler(this.BtnUnidadEliminar_Click);
            // 
            // dgUnidades
            // 
            this.dgUnidades.AllowUserToAddRows = false;
            this.dgUnidades.AllowUserToDeleteRows = false;
            this.dgUnidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUnidades.Location = new System.Drawing.Point(479, 17);
            this.dgUnidades.Name = "dgUnidades";
            this.dgUnidades.ReadOnly = true;
            this.dgUnidades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgUnidades.Size = new System.Drawing.Size(447, 248);
            this.dgUnidades.TabIndex = 6;
            this.dgUnidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUnidades_CellClick);
            // 
            // lblTitCatUnidades
            // 
            this.lblTitCatUnidades.AutoSize = true;
            this.lblTitCatUnidades.Depth = 0;
            this.lblTitCatUnidades.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitCatUnidades.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTitCatUnidades.Location = new System.Drawing.Point(17, 14);
            this.lblTitCatUnidades.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitCatUnidades.Name = "lblTitCatUnidades";
            this.lblTitCatUnidades.Size = new System.Drawing.Size(196, 24);
            this.lblTitCatUnidades.TabIndex = 5;
            this.lblTitCatUnidades.Text = "Catálogo de Unidades";
            // 
            // btnUnidad
            // 
            this.btnUnidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUnidad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUnidad.Depth = 0;
            this.btnUnidad.HighEmphasis = true;
            this.btnUnidad.Icon = null;
            this.btnUnidad.Location = new System.Drawing.Point(347, 140);
            this.btnUnidad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUnidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUnidad.Name = "btnUnidad";
            this.btnUnidad.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUnidad.Size = new System.Drawing.Size(88, 36);
            this.btnUnidad.TabIndex = 4;
            this.btnUnidad.Text = "Guardar";
            this.btnUnidad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUnidad.UseAccentColor = false;
            this.btnUnidad.UseVisualStyleBackColor = true;
            this.btnUnidad.Click += new System.EventHandler(this.btnUnidad_Click);
            // 
            // txtUnidad
            // 
            this.txtUnidad.AnimateReadOnly = false;
            this.txtUnidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnidad.Depth = 0;
            this.txtUnidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUnidad.LeadingIcon = null;
            this.txtUnidad.Location = new System.Drawing.Point(75, 81);
            this.txtUnidad.MaxLength = 50;
            this.txtUnidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUnidad.Multiline = false;
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(360, 50);
            this.txtUnidad.TabIndex = 2;
            this.txtUnidad.Text = "";
            this.txtUnidad.TrailingIcon = null;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(12, 112);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(57, 19);
            this.materialLabel11.TabIndex = 0;
            this.materialLabel11.Text = "Nombre";
            // 
            // tabExistencias
            // 
            this.tabExistencias.Controls.Add(this.reportViewer1);
            this.tabExistencias.ImageKey = "repExistencias.png";
            this.tabExistencias.Location = new System.Drawing.Point(4, 39);
            this.tabExistencias.Name = "tabExistencias";
            this.tabExistencias.Padding = new System.Windows.Forms.Padding(3);
            this.tabExistencias.Size = new System.Drawing.Size(1078, 397);
            this.tabExistencias.TabIndex = 2;
            this.tabExistencias.Text = "Rep.Existencias";
            this.tabExistencias.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSetReporte";
            reportDataSource5.Value = this.existenciasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SimpleInventario.Reportes.ReportExistencias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1072, 391);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabEntradas
            // 
            this.tabEntradas.Controls.Add(this.materialCard2);
            this.tabEntradas.ImageKey = "entradas.png";
            this.tabEntradas.Location = new System.Drawing.Point(4, 39);
            this.tabEntradas.Name = "tabEntradas";
            this.tabEntradas.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntradas.Size = new System.Drawing.Size(1078, 397);
            this.tabEntradas.TabIndex = 1;
            this.tabEntradas.Text = "3. Entradas";
            this.tabEntradas.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.pictureBox2);
            this.materialCard2.Controls.Add(this.ddlEntradaProducto);
            this.materialCard2.Controls.Add(this.lbExistenciaEntrada);
            this.materialCard2.Controls.Add(this.txtEntradaPrecio);
            this.materialCard2.Controls.Add(this.txtEntradaCantidad);
            this.materialCard2.Controls.Add(this.lblTitEntradas);
            this.materialCard2.Controls.Add(this.btnEntrada);
            this.materialCard2.Controls.Add(this.materialLabel9);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Controls.Add(this.materialLabel6);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 17);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(938, 335);
            this.materialCard2.TabIndex = 1;
            // 
            // ddlEntradaProducto
            // 
            this.ddlEntradaProducto.BackColor = System.Drawing.SystemColors.Control;
            this.ddlEntradaProducto.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ddlEntradaProducto.FormattingEnabled = true;
            this.ddlEntradaProducto.Location = new System.Drawing.Point(103, 79);
            this.ddlEntradaProducto.Name = "ddlEntradaProducto";
            this.ddlEntradaProducto.Size = new System.Drawing.Size(217, 30);
            this.ddlEntradaProducto.TabIndex = 9;
            // 
            // lbExistenciaEntrada
            // 
            this.lbExistenciaEntrada.AutoSize = true;
            this.lbExistenciaEntrada.Depth = 0;
            this.lbExistenciaEntrada.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbExistenciaEntrada.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbExistenciaEntrada.Location = new System.Drawing.Point(338, 128);
            this.lbExistenciaEntrada.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbExistenciaEntrada.Name = "lbExistenciaEntrada";
            this.lbExistenciaEntrada.Size = new System.Drawing.Size(92, 24);
            this.lbExistenciaEntrada.TabIndex = 8;
            this.lbExistenciaEntrada.Text = "Existencia";
            // 
            // txtEntradaPrecio
            // 
            this.txtEntradaPrecio.AnimateReadOnly = false;
            this.txtEntradaPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntradaPrecio.Depth = 0;
            this.txtEntradaPrecio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEntradaPrecio.LeadingIcon = null;
            this.txtEntradaPrecio.Location = new System.Drawing.Point(103, 128);
            this.txtEntradaPrecio.MaxLength = 19;
            this.txtEntradaPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEntradaPrecio.Multiline = false;
            this.txtEntradaPrecio.Name = "txtEntradaPrecio";
            this.txtEntradaPrecio.Size = new System.Drawing.Size(217, 50);
            this.txtEntradaPrecio.TabIndex = 6;
            this.txtEntradaPrecio.Text = "";
            this.txtEntradaPrecio.TrailingIcon = null;
            // 
            // txtEntradaCantidad
            // 
            this.txtEntradaCantidad.AnimateReadOnly = false;
            this.txtEntradaCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntradaCantidad.Depth = 0;
            this.txtEntradaCantidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEntradaCantidad.LeadingIcon = null;
            this.txtEntradaCantidad.Location = new System.Drawing.Point(103, 184);
            this.txtEntradaCantidad.MaxLength = 50;
            this.txtEntradaCantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEntradaCantidad.Multiline = false;
            this.txtEntradaCantidad.Name = "txtEntradaCantidad";
            this.txtEntradaCantidad.Size = new System.Drawing.Size(217, 50);
            this.txtEntradaCantidad.TabIndex = 6;
            this.txtEntradaCantidad.Text = "";
            this.txtEntradaCantidad.TrailingIcon = null;
            // 
            // lblTitEntradas
            // 
            this.lblTitEntradas.AutoSize = true;
            this.lblTitEntradas.Depth = 0;
            this.lblTitEntradas.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitEntradas.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTitEntradas.Location = new System.Drawing.Point(17, 14);
            this.lblTitEntradas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitEntradas.Name = "lblTitEntradas";
            this.lblTitEntradas.Size = new System.Drawing.Size(80, 24);
            this.lblTitEntradas.TabIndex = 5;
            this.lblTitEntradas.Text = "Entradas";
            // 
            // btnEntrada
            // 
            this.btnEntrada.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEntrada.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEntrada.Depth = 0;
            this.btnEntrada.HighEmphasis = true;
            this.btnEntrada.Icon = null;
            this.btnEntrada.Location = new System.Drawing.Point(232, 270);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEntrada.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEntrada.Size = new System.Drawing.Size(88, 36);
            this.btnEntrada.TabIndex = 4;
            this.btnEntrada.Text = "Guardar";
            this.btnEntrada.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEntrada.UseAccentColor = false;
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(52, 149);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(45, 19);
            this.materialLabel9.TabIndex = 1;
            this.materialLabel9.Text = "Precio";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(24, 204);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(65, 19);
            this.materialLabel5.TabIndex = 1;
            this.materialLabel5.Text = "Cantidad";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(32, 87);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(65, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Producto";
            // 
            // tabSalidas
            // 
            this.tabSalidas.Controls.Add(this.materialCard4);
            this.tabSalidas.ImageKey = "salidas.png";
            this.tabSalidas.Location = new System.Drawing.Point(4, 39);
            this.tabSalidas.Name = "tabSalidas";
            this.tabSalidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalidas.Size = new System.Drawing.Size(1078, 397);
            this.tabSalidas.TabIndex = 0;
            this.tabSalidas.Text = "4. Salidas";
            this.tabSalidas.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.pictureBox1);
            this.materialCard4.Controls.Add(this.ddlSalidaProducto);
            this.materialCard4.Controls.Add(this.lbExistenciaSalida);
            this.materialCard4.Controls.Add(this.lbPrecioSalida);
            this.materialCard4.Controls.Add(this.txtSalidaCantidad);
            this.materialCard4.Controls.Add(this.lblTitSalidas);
            this.materialCard4.Controls.Add(this.btnSalida);
            this.materialCard4.Controls.Add(this.materialLabel13);
            this.materialCard4.Controls.Add(this.materialLabel14);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(17, 17);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(947, 338);
            this.materialCard4.TabIndex = 5;
            // 
            // ddlSalidaProducto
            // 
            this.ddlSalidaProducto.BackColor = System.Drawing.SystemColors.Control;
            this.ddlSalidaProducto.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ddlSalidaProducto.FormattingEnabled = true;
            this.ddlSalidaProducto.Location = new System.Drawing.Point(90, 67);
            this.ddlSalidaProducto.Name = "ddlSalidaProducto";
            this.ddlSalidaProducto.Size = new System.Drawing.Size(217, 30);
            this.ddlSalidaProducto.TabIndex = 10;
            // 
            // lbExistenciaSalida
            // 
            this.lbExistenciaSalida.AutoSize = true;
            this.lbExistenciaSalida.Depth = 0;
            this.lbExistenciaSalida.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbExistenciaSalida.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbExistenciaSalida.Location = new System.Drawing.Point(17, 274);
            this.lbExistenciaSalida.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbExistenciaSalida.Name = "lbExistenciaSalida";
            this.lbExistenciaSalida.Size = new System.Drawing.Size(92, 24);
            this.lbExistenciaSalida.TabIndex = 8;
            this.lbExistenciaSalida.Text = "Existencia";
            // 
            // lbPrecioSalida
            // 
            this.lbPrecioSalida.AutoSize = true;
            this.lbPrecioSalida.Depth = 0;
            this.lbPrecioSalida.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbPrecioSalida.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbPrecioSalida.Location = new System.Drawing.Point(51, 249);
            this.lbPrecioSalida.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPrecioSalida.Name = "lbPrecioSalida";
            this.lbPrecioSalida.Size = new System.Drawing.Size(58, 24);
            this.lbPrecioSalida.TabIndex = 7;
            this.lbPrecioSalida.Text = "Precio";
            // 
            // txtSalidaCantidad
            // 
            this.txtSalidaCantidad.AnimateReadOnly = false;
            this.txtSalidaCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalidaCantidad.Depth = 0;
            this.txtSalidaCantidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSalidaCantidad.LeadingIcon = null;
            this.txtSalidaCantidad.Location = new System.Drawing.Point(90, 113);
            this.txtSalidaCantidad.MaxLength = 50;
            this.txtSalidaCantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSalidaCantidad.Multiline = false;
            this.txtSalidaCantidad.Name = "txtSalidaCantidad";
            this.txtSalidaCantidad.Size = new System.Drawing.Size(217, 50);
            this.txtSalidaCantidad.TabIndex = 6;
            this.txtSalidaCantidad.Text = "";
            this.txtSalidaCantidad.TrailingIcon = null;
            // 
            // lblTitSalidas
            // 
            this.lblTitSalidas.AutoSize = true;
            this.lblTitSalidas.Depth = 0;
            this.lblTitSalidas.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitSalidas.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTitSalidas.Location = new System.Drawing.Point(17, 14);
            this.lblTitSalidas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitSalidas.Name = "lblTitSalidas";
            this.lblTitSalidas.Size = new System.Drawing.Size(66, 24);
            this.lblTitSalidas.TabIndex = 5;
            this.lblTitSalidas.Text = "Salidas";
            // 
            // btnSalida
            // 
            this.btnSalida.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalida.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalida.Depth = 0;
            this.btnSalida.HighEmphasis = true;
            this.btnSalida.Icon = null;
            this.btnSalida.Location = new System.Drawing.Point(219, 186);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalida.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalida.Size = new System.Drawing.Size(88, 36);
            this.btnSalida.TabIndex = 4;
            this.btnSalida.Text = "Guardar";
            this.btnSalida.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalida.UseAccentColor = false;
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(11, 133);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(65, 19);
            this.materialLabel13.TabIndex = 1;
            this.materialLabel13.Text = "Cantidad";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(19, 78);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(65, 19);
            this.materialLabel14.TabIndex = 0;
            this.materialLabel14.Text = "Producto";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabUnidades);
            this.materialTabControl1.Controls.Add(this.tabProductos);
            this.materialTabControl1.Controls.Add(this.tabEntradas);
            this.materialTabControl1.Controls.Add(this.tabSalidas);
            this.materialTabControl1.Controls.Add(this.tabExistencias);
            this.materialTabControl1.Controls.Add(this.tabKardex);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1086, 440);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabKardex
            // 
            this.tabKardex.Controls.Add(this.reportViewer2);
            this.tabKardex.ImageKey = "repKardex.png";
            this.tabKardex.Location = new System.Drawing.Point(4, 39);
            this.tabKardex.Name = "tabKardex";
            this.tabKardex.Padding = new System.Windows.Forms.Padding(3);
            this.tabKardex.Size = new System.Drawing.Size(1078, 397);
            this.tabKardex.TabIndex = 5;
            this.tabKardex.Text = "Rep.Movimientos";
            this.tabKardex.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "dsKardex";
            reportDataSource6.Value = this.kardexBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "SimpleInventario.Reportes.ReportKardex.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1072, 391);
            this.reportViewer2.TabIndex = 0;
            // 
            // existenciasTableAdapter
            // 
            this.existenciasTableAdapter.ClearBeforeFill = true;
            // 
            // kardexTableAdapter
            // 
            this.kardexTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(574, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(569, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 507);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerUseColors = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Inventarios";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.existenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kardexBindingSource)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.tabProductos.ResumeLayout(false);
            this.tabUnidades.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnidades)).EndInit();
            this.tabExistencias.ResumeLayout(false);
            this.tabEntradas.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.tabSalidas.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tabKardex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox ddlCatProdUnidad;
        private MaterialSkin.Controls.MaterialLabel lblTitCatProd;
        private MaterialSkin.Controls.MaterialButton btnProducto;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialLabel lblCatProductoId;
        private MaterialSkin.Controls.MaterialButton btnEliminarProducto;
        private System.Windows.Forms.DataGridView dgProductos;
        private MaterialSkin.Controls.MaterialTextBox txtCatProdNombre;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.TabPage tabUnidades;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel lblUnidadesId;
        private MaterialSkin.Controls.MaterialButton BtnUnidadEliminar;
        private System.Windows.Forms.DataGridView dgUnidades;
        private MaterialSkin.Controls.MaterialLabel lblTitCatUnidades;
        private MaterialSkin.Controls.MaterialButton btnUnidad;
        private MaterialSkin.Controls.MaterialTextBox txtUnidad;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.TabPage tabExistencias;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabEntradas;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel lbExistenciaEntrada;
        private MaterialSkin.Controls.MaterialTextBox txtEntradaPrecio;
        private MaterialSkin.Controls.MaterialTextBox txtEntradaCantidad;
        private MaterialSkin.Controls.MaterialLabel lblTitEntradas;
        private MaterialSkin.Controls.MaterialButton btnEntrada;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TabPage tabSalidas;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel lbExistenciaSalida;
        private MaterialSkin.Controls.MaterialLabel lbPrecioSalida;
        private MaterialSkin.Controls.MaterialTextBox txtSalidaCantidad;
        private MaterialSkin.Controls.MaterialLabel lblTitSalidas;
        private MaterialSkin.Controls.MaterialButton btnSalida;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private Reportes.dsReportes dsReportes;
        private System.Windows.Forms.BindingSource existenciasBindingSource;
        private Reportes.dsReportesTableAdapters.ExistenciasTableAdapter existenciasTableAdapter;
        private System.Windows.Forms.TabPage tabKardex;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource kardexBindingSource;
        private Reportes.dsReportesTableAdapters.KardexTableAdapter kardexTableAdapter;
        private System.Windows.Forms.ComboBox ddlEntradaProducto;
        private System.Windows.Forms.ComboBox ddlSalidaProducto;
        private MaterialSkin.Controls.MaterialButton btnModificarUnidad;
        private MaterialSkin.Controls.MaterialButton btnModificarProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

